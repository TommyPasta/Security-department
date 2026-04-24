using Newtonsoft.Json;
using Security_department.Repositories.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace Security_department.Repositories.Classes
{
    public class SecurityPatrolRepository : ISecurityPatrolRepository
    {
        private readonly string filePath = "patrols.json";

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
            return JsonConvert.DeserializeObject<List<SecurityPatrol>>(json) ?? new List<SecurityPatrol>();
        }

        public SecurityPatrol GetPatrolById(int id)
        {
            var patrols = GetAllPatrols();
            return patrols.Find(p => p.PatrolId == id);
        }

        private void SavePatrols(List<SecurityPatrol> patrols)
        {
            var json = JsonConvert.SerializeObject(patrols, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}