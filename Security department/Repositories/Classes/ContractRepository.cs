using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Security_department.Repositories.Interfaces;
using Security_department;
using Security_department.Repositories.Classes;
using Formatting = Newtonsoft.Json.Formatting;

public class ContractRepository : IContractRepository
{
    private readonly string filePath = "contracts.json";

    private JsonSerializerSettings GetSerializerSettings()
    {
        var settings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            Converters = new List<JsonConverter>
            {
                new ObjectConverter(),
                new ContractConverter()
            }
        };
        return settings;
    }

    public void Add(Contract contract)
    {
        var contracts = GetAll();
        contracts.Add(contract);
        SaveContracts(contracts);
    }

    public void Remove(int id)
    {
        var contracts = GetAll();
        var contractToRemove = contracts.Find(c => c.Id == id);
        if (contractToRemove != null)
        {
            contracts.Remove(contractToRemove);
            SaveContracts(contracts);
        }
    }

    public Contract GetById(int id)
    {
        var contracts = GetAll();
        return contracts.Find(c => c.Id == id);
    }

    public List<Contract> GetAll()
    {
        if (!File.Exists(filePath))
            return new List<Contract>();

        var json = File.ReadAllText(filePath);
        var settings = GetSerializerSettings();
        return JsonConvert.DeserializeObject<List<Contract>>(json, settings) ?? new List<Contract>();
    }

    private void SaveContracts(List<Contract> contracts)
    {
        var settings = GetSerializerSettings();
        var json = JsonConvert.SerializeObject(contracts, settings);
        File.WriteAllText(filePath, json);
    }
}
