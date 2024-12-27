using Security_department.Repositories.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Security_department;

public class ObjectRepository : IObjectRepository
{
    private readonly string filePath = "objects.json";

    public void Add(Object obj)
    {
        var objects = GetAll();
        objects.Add(obj);
        File.WriteAllText(filePath, JsonSerializer.Serialize(objects, new JsonSerializerOptions { WriteIndented = true }));
    }

    public void Remove(int id)
    {
        var objects = GetAll();
        var objectToRemove = objects.Find(o => o.Id == id);
        if (objectToRemove != null)
        {
            objects.Remove(objectToRemove);
            File.WriteAllText(filePath, JsonSerializer.Serialize(objects, new JsonSerializerOptions { WriteIndented = true }));
        }
    }

    public Object GetById(int id)
    {
        var objects = GetAll();
        return objects.Find(o => o.Id == id);
    }

    public List<Object> GetAll()
    {
        if (!File.Exists(filePath))
            return new List<Object>();

        var json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<Object>>(json);
    }
}