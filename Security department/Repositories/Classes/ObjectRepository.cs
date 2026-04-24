using Security_department.Repositories.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Security_department;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;
public class ObjectRepository : IObjectRepository
{
    private readonly string filePath = "objects.json";

    private JsonSerializerSettings GetSerializerSettings()
    {
        var settings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented
        };
        return settings;
    }

    public void Add(Object obj)
    {
        var objects = GetAll();
        objects.Add(obj);
        SaveObjects(objects);
    }

    public void Remove(int id)
    {
        var objects = GetAll();
        var objectToRemove = objects.Find(o => o.Id == id);
        if (objectToRemove != null)
        {
            objects.Remove(objectToRemove);
            SaveObjects(objects);
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
        var settings = GetSerializerSettings();
        return JsonConvert.DeserializeObject<List<Object>>(json, settings) ?? new List<Object>();
    }

    public void Update(Object obj)
    {
        var objects = GetAll();
        var existingObject = objects.Find(o => o.Id == obj.Id);
        if (existingObject != null)
        {
            existingObject.Update(obj.Address, obj.Floor, obj.EntranceCode, obj.HasEntranceCode,
                                  obj.HouseType, obj.TotalFloors, obj.DoorType, obj.BalconyType,
                                  obj.ApartmentPlan);
            SaveObjects(objects);
        }
    }

    private void SaveObjects(List<Object> objects)
    {
        var settings = GetSerializerSettings();
        var json = JsonConvert.SerializeObject(objects, settings);
        File.WriteAllText(filePath, json);
    }
}