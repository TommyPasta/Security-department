using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Security_department.Repositories.Interfaces;
using Security_department;

public class ContractRepository : IContractRepository
{
    private readonly string filePath = "contracts.json";

    public void Add(Contract contract)
    {
        var contracts = GetAll();
        contracts.Add(contract);
        File.WriteAllText(filePath, JsonConvert.SerializeObject(contracts, Formatting.Indented));
    }

    public void Remove(int id)
    {
        var contracts = GetAll();
        var contractToRemove = contracts.Find(c => c.Id == id);
        if (contractToRemove != null)
        {
            contracts.Remove(contractToRemove);
            File.WriteAllText(filePath, JsonConvert.SerializeObject(contracts, Formatting.Indented));
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
        return JsonConvert.DeserializeObject<List<Contract>>(json);
    }
}
