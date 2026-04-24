using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Security_department;
using Security_department.Repositories.Classes;
using Security_department.Repositories.Interfaces;
using Formatting = Newtonsoft.Json.Formatting;

public class ClientRepository : IClientRepository
{
    private readonly string filePath = "clients.json";

    private JsonSerializerSettings GetSerializerSettings()
    {
        var settings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            Converters = new List<JsonConverter>
            {
                new PassportConverter()
            }
        };
        return settings;
    }

    public void Add(Client client)
    {
        var clients = GetAll();
        clients.Add(client);
        SaveClients(clients);
    }

    public void Remove(int id)
    {
        var clients = GetAll();
        var clientToRemove = clients.Find(c => c.Id == id);
        if (clientToRemove != null)
        {
            clients.Remove(clientToRemove);
            SaveClients(clients);
        }
    }

    public Client GetById(int id)
    {
        var clients = GetAll();
        return clients.Find(c => c.Id == id);
    }

    public List<Client> GetAll()
    {
        if (!File.Exists(filePath))
            return new List<Client>();

        var json = File.ReadAllText(filePath);
        var settings = GetSerializerSettings();
        return JsonConvert.DeserializeObject<List<Client>>(json, settings) ?? new List<Client>();
    }

    public void Update(Client client)
    {
        var clients = GetAll();
        var clientToUpdate = clients.Find(c => c.Id == client.Id);
        if (clientToUpdate != null)
        {
            clientToUpdate.Update(client.FirstName, client.SecondName, client.Surname,
                                client.Address, client.Phone, client.Passport);
            SaveClients(clients);
        }
    }

    private void SaveClients(List<Client> clients)
    {
        var settings = GetSerializerSettings();
        var json = JsonConvert.SerializeObject(clients, settings);
        File.WriteAllText(filePath, json);
    }
}