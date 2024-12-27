using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using System.Xml;
using Newtonsoft.Json;
using Security_department.Repositories.Interfaces;
using Security_department;
using Formatting = Newtonsoft.Json.Formatting;
using Security_department.DTOs;
using Security_department.Mappers;
using System;

public class ClientRepository : IClientRepository
{
    private readonly string filePath = "clients.json";

    public void Add(Client client)
    {
        var clients = GetAll();
        clients.Add(client);
        File.WriteAllText(filePath, JsonConvert.SerializeObject(clients, Formatting.Indented));
    }

    public void Remove(int id)
    {
        var clients = GetAll();
        var clientToRemove = clients.Find(c => c.Id == id);
        if (clientToRemove != null)
        {
            clients.Remove(clientToRemove);
            File.WriteAllText(filePath, JsonConvert.SerializeObject(clients, Formatting.Indented));
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
        return JsonConvert.DeserializeObject<List<Client>>(json);
    }

    public void Update(Client client)
    {
        var clients = GetAll();
        var clientToUpdate = clients.Find(c => c.Id == client.Id);
        if (clientToUpdate != null)
        {
            // Обновление данных клиента через метод Update
            clientToUpdate.Update(client.FirstName, client.SecondName, client.Surname, client.Address, client.Phone, client.Passport);

            // Сохранение изменений в файл
            File.WriteAllText(filePath, JsonConvert.SerializeObject(clients, Formatting.Indented));
        }
    }
}