using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Security_department;
using Security_department.Entities.Classes;
using Security_department.Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace Security_department.Repositories.Classes
{
        public class PassportConverter : JsonConverter<IPassport>
        {
            public override IPassport ReadJson(JsonReader reader, Type objectType,
                IPassport existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                // Проверка на null в JSON
                if (reader.TokenType == JsonToken.Null)
                    return null;

                try
                {
                    JObject obj = JObject.Load(reader);

                    // Безопасное чтение с проверкой на null для каждого поля
                    string passportNumber = obj["PassportNumber"]?.Value<string>() ?? "";
                    string issuingAuthority = obj["IssuingAuthority"]?.Value<string>() ?? "";
                    DateTime dateOfIssue = obj["DateOfIssue"]?.Value<DateTime>() ?? DateTime.Now;
                    DateTime dateOfExpiry = obj["DateOfExpiry"]?.Value<DateTime>() ?? DateTime.Now.AddYears(10);

                    return new Passport(passportNumber, issuingAuthority, dateOfIssue, dateOfExpiry);
                }
                catch
                {
                    // Если не удалось прочитать — возвращаем null
                    return null;
                }
            }

            public override void WriteJson(JsonWriter writer, IPassport value, JsonSerializer serializer)
            {
                if (value == null)
                {
                    writer.WriteNull();
                    return;
                }

                var passport = value as Passport;
                if (passport != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("PassportNumber");
                    writer.WriteValue(passport.PassportNumber ?? "");
                    writer.WritePropertyName("IssuingAuthority");
                    writer.WriteValue(passport.IssuingAuthority ?? "");
                    writer.WritePropertyName("DateOfIssue");
                    writer.WriteValue(passport.DateOfIssue);
                    writer.WritePropertyName("DateOfExpiry");
                    writer.WriteValue(passport.DateOfExpiry);
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull();
                }
            }
        }

        public class ObjectConverter : JsonConverter<IObject>
        {
            public override IObject ReadJson(JsonReader reader, Type objectType,
                IObject existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                // Проверка на null в JSON
                if (reader.TokenType == JsonToken.Null)
                    return null;

                try
                {
                    JObject obj = JObject.Load(reader);

                    int id = obj["Id"]?.Value<int>() ?? 0;
                    string address = obj["Address"]?.Value<string>() ?? "";
                    int floor = obj["Floor"]?.Value<int>() ?? 0;
                    string entranceCode = obj["EntranceCode"]?.Value<string>() ?? "";
                    bool hasEntranceCode = obj["HasEntranceCode"]?.Value<bool>() ?? false;
                    string houseType = obj["HouseType"]?.Value<string>() ?? "";
                    int totalFloors = obj["TotalFloors"]?.Value<int>() ?? 0;
                    string doorType = obj["DoorType"]?.Value<string>() ?? "";
                    string balconyType = obj["BalconyType"]?.Value<string>() ?? "";
                    string apartmentPlan = obj["ApartmentPlan"]?.Value<string>() ?? "";

                    return new Object(id, address, floor, entranceCode, hasEntranceCode,
                        houseType, totalFloors, doorType, balconyType, apartmentPlan);
                }
                catch
                {
                    return null;
                }
            }

            public override void WriteJson(JsonWriter writer, IObject value, JsonSerializer serializer)
            {
                if (value == null)
                {
                    writer.WriteNull();
                    return;
                }

                var obj = value as Object;
                if (obj != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("Id");
                    writer.WriteValue(obj.Id);
                    writer.WritePropertyName("Address");
                    writer.WriteValue(obj.Address ?? "");
                    writer.WritePropertyName("Floor");
                    writer.WriteValue(obj.Floor);
                    writer.WritePropertyName("EntranceCode");
                    writer.WriteValue(obj.EntranceCode ?? "");
                    writer.WritePropertyName("HasEntranceCode");
                    writer.WriteValue(obj.HasEntranceCode);
                    writer.WritePropertyName("HouseType");
                    writer.WriteValue(obj.HouseType ?? "");
                    writer.WritePropertyName("TotalFloors");
                    writer.WriteValue(obj.TotalFloors);
                    writer.WritePropertyName("DoorType");
                    writer.WriteValue(obj.DoorType ?? "");
                    writer.WritePropertyName("BalconyType");
                    writer.WriteValue(obj.BalconyType ?? "");
                    writer.WritePropertyName("ApartmentPlan");
                    writer.WriteValue(obj.ApartmentPlan ?? "");
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull();
                }
            }
        }
        public class ContractConverter : JsonConverter<IContract>
        {
            public override IContract ReadJson(JsonReader reader, Type objectType,
          IContract existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null)
                    return null;

                try
                {
                    JObject obj = JObject.Load(reader);

                    int id = obj["Id"]?.Value<int>() ?? 0;
                    int clientId = obj["ClientId"]?.Value<int>() ?? 0;

                    // Безопасная десериализация вложенного объекта
                    IObject objectItem = null;
                    var objectToken = obj["Object"];
                    if (objectToken != null && objectToken.Type != JTokenType.Null)
                    {
                        objectItem = objectToken.ToObject<Object>(serializer);
                    }

                    DateTime startDate = obj["StartDate"]?.Value<DateTime>() ?? DateTime.Now;
                    DateTime endDate = obj["EndDate"]?.Value<DateTime>() ?? DateTime.Now;
                    int penalty = obj["Penalty"]?.Value<int>() ?? 0;
                    float interestRate = obj["InterestRate"]?.Value<float>() ?? 0f;
                    string additionalConditions = obj["AdditionalConditions"]?.Value<string>() ?? "";
                    float paymentAmount = obj["PaymentAmount"]?.Value<float>() ?? 0f;

                    return new Contract(id, clientId, objectItem, startDate, endDate,
                        penalty, interestRate, additionalConditions, paymentAmount);
                }
                catch
                {
                    return null;
                }
            }

            public override void WriteJson(JsonWriter writer, IContract value, JsonSerializer serializer)
            {
                if (value == null)
                {
                    writer.WriteNull();
                    return;
                }

                var contract = value as Contract;
                if (contract != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("Id");
                    writer.WriteValue(contract.Id);
                    writer.WritePropertyName("ClientId");
                    writer.WriteValue(contract.ClientId);
                    writer.WritePropertyName("Object");
                    serializer.Serialize(writer, contract.Object);
                    writer.WritePropertyName("StartDate");
                    writer.WriteValue(contract.StartDate);
                    writer.WritePropertyName("EndDate");
                    writer.WriteValue(contract.EndDate);
                    writer.WritePropertyName("Penalty");
                    writer.WriteValue(contract.Penalty);
                    writer.WritePropertyName("InterestRate");
                    writer.WriteValue(contract.InterestRate);
                    writer.WritePropertyName("AdditionalConditions");
                    writer.WriteValue(contract.AdditionalConditions ?? "");
                    writer.WritePropertyName("PaymentAmount");
                    writer.WriteValue(contract.PaymentAmount);
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull();
                }
            }
        }

        public class StolenItemConverter : JsonConverter<IStolenItem>
        {
            public override IStolenItem ReadJson(JsonReader reader, Type objectType,
                IStolenItem existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null)
                    return null;

                try
                {
                    JObject obj = JObject.Load(reader);

                    string itemName = obj["ItemName"]?.Value<string>() ?? "";
                    decimal estimatedValue = obj["EstimatedValue"]?.Value<decimal>() ?? 0;

                    return new StolenItem(itemName, estimatedValue);
                }
                catch
                {
                    return null;
                }
            }

            public override void WriteJson(JsonWriter writer, IStolenItem value, JsonSerializer serializer)
            {
                if (value == null)
                {
                    writer.WriteNull();
                    return;
                }

                var item = value as StolenItem;
                if (item != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("ItemName");
                    writer.WriteValue(item.ItemName ?? "");
                    writer.WritePropertyName("EstimatedValue");
                    writer.WriteValue(item.EstimatedValue);
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull();
                }
            }
        }


        public class ArrestDetailsConverter : JsonConverter<IArrestDetails>
        {
            public override IArrestDetails ReadJson(JsonReader reader, Type objectType,
                IArrestDetails existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null)
                    return null;

                try
                {
                    JObject obj = JObject.Load(reader);

                    string documentNumber = obj["DocumentNumber"]?.Value<string>() ?? "";
                    string issuingAuthority = obj["IssuingAuthority"]?.Value<string>() ?? "";
                    DateTime dateOfIssue = obj["DateOfIssue"]?.Value<DateTime>() ?? DateTime.Now;

                    return new ArrestDetails(documentNumber, issuingAuthority, dateOfIssue);
                }
                catch
                {
                    return null;
                }
            }

            public override void WriteJson(JsonWriter writer, IArrestDetails value, JsonSerializer serializer)
            {
                if (value == null)
                {
                    writer.WriteNull();
                    return;
                }

                var details = value as ArrestDetails;
                if (details != null)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("DocumentNumber");
                    writer.WriteValue(details.DocumentNumber ?? "");
                    writer.WritePropertyName("IssuingAuthority");
                    writer.WriteValue(details.IssuingAuthority ?? "");
                    writer.WritePropertyName("DateOfIssue");
                    writer.WriteValue(details.DateOfIssue);
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull();
                }
            }
        }
}