using Security_department.Repositories.Interfaces;
using Security_department;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class PassportRepository : IPassportRepository
{
    private readonly string filePath = "passports.json";

    public void Add(Passport passport)
    {
        var passports = GetAll();
        passports.Add(passport);
        File.WriteAllText(filePath, JsonSerializer.Serialize(passports, new JsonSerializerOptions { WriteIndented = true }));
    }

    public void Remove(string passportNumber)
    {
        var passports = GetAll();
        var passportToRemove = passports.Find(p => p.PassportNumber == passportNumber);
        if (passportToRemove != null)
        {
            passports.Remove(passportToRemove);
            File.WriteAllText(filePath, JsonSerializer.Serialize(passports, new JsonSerializerOptions { WriteIndented = true }));
        }
    }

    public Passport GetByNumber(string passportNumber)
    {
        var passports = GetAll();
        return passports.Find(p => p.PassportNumber == passportNumber);
    }

    public List<Passport> GetAll()
    {
        if (!File.Exists(filePath))
            return new List<Passport>();

        var json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<Passport>>(json);
    }
}