using Newtonsoft.Json;
using Security_department.Repositories.Interfaces;
using System.Collections.Generic;
using System.IO;
using Formatting = Newtonsoft.Json.Formatting;

namespace Security_department.Repositories.Classes
{
    public class SecurityPatrolRepository : ISecurityPatrolRepository
    {
        private readonly string filePath = "patrols.json";

        private JsonSerializerSettings GetSerializerSettings()
        {
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                Converters = new List<JsonConverter>
                {
                    new StolenItemConverter(),
                    new ArrestDetailsConverter(),
                    new ObjectConverter(),
                    new ContractConverter()
                }
            };
            return settings;
        }

        public void AddPatrol(SecurityPatrol patrol)
        {
            var patrols = GetAllPatrols();
            patrols.Add(patrol);
            SavePatrols(patrols);
        }

        public List<SecurityPatrol> GetAllPatrols()
        {
            if (!File.Exists(filePath))
                return new List<SecurityPatrol>();

            var json = File.ReadAllText(filePath);
            var settings = GetSerializerSettings();
            return JsonConvert.DeserializeObject<List<SecurityPatrol>>(json, settings) ?? new List<SecurityPatrol>();
        }

        public SecurityPatrol GetPatrolById(int id)
        {
            var patrols = GetAllPatrols();
            return patrols.Find(p => p.PatrolId == id);
        }

        private void SavePatrols(List<SecurityPatrol> patrols)
        {
            var settings = GetSerializerSettings();
            var json = JsonConvert.SerializeObject(patrols, settings);
            File.WriteAllText(filePath, json);
        }
    }
}