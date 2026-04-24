using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Security_department.Entities.Classes;
using Security_department.Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace Security_department.Repositories.Classes
{
    public class PassportConverter : JsonConverter<IPassport>
    {
        public override IPassport ReadJson(JsonReader reader, Type objectType, IPassport existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            JObject obj = JObject.Load(reader);
            return new Passport(
                obj["PassportNumber"]?.Value<string>(),
                obj["IssuingAuthority"]?.Value<string>(),
                obj["DateOfIssue"]?.Value<DateTime>() ?? DateTime.Now,
                obj["DateOfExpiry"]?.Value<DateTime>() ?? DateTime.Now
            );
        }

        public override void WriteJson(JsonWriter writer, IPassport value, JsonSerializer serializer)
        {
            var passport = value as Passport;
            if (passport != null)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("PassportNumber");
                writer.WriteValue(passport.PassportNumber);
                writer.WritePropertyName("IssuingAuthority");
                writer.WriteValue(passport.IssuingAuthority);
                writer.WritePropertyName("DateOfIssue");
                writer.WriteValue(passport.DateOfIssue);
                writer.WritePropertyName("DateOfExpiry");
                writer.WriteValue(passport.DateOfExpiry);
                writer.WriteEndObject();
            }
        }
    }

    public class ObjectConverter : JsonConverter<IObject>
    {
        public override IObject ReadJson(JsonReader reader, Type objectType, IObject existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            JObject obj = JObject.Load(reader);
            return new Object(
                obj["Id"]?.Value<int>() ?? 0,
                obj["Address"]?.Value<string>(),
                obj["Floor"]?.Value<int>() ?? 0,
                obj["EntranceCode"]?.Value<string>(),
                obj["HasEntranceCode"]?.Value<bool>() ?? false,
                obj["HouseType"]?.Value<string>(),
                obj["TotalFloors"]?.Value<int>() ?? 0,
                obj["DoorType"]?.Value<string>(),
                obj["BalconyType"]?.Value<string>(),
                obj["ApartmentPlan"]?.Value<string>()
            );
        }

        public override void WriteJson(JsonWriter writer, IObject value, JsonSerializer serializer)
        {
            var obj = value as Object;
            if (obj != null)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("Id");
                writer.WriteValue(obj.Id);
                writer.WritePropertyName("Address");
                writer.WriteValue(obj.Address);
                writer.WritePropertyName("Floor");
                writer.WriteValue(obj.Floor);
                writer.WritePropertyName("EntranceCode");
                writer.WriteValue(obj.EntranceCode);
                writer.WritePropertyName("HasEntranceCode");
                writer.WriteValue(obj.HasEntranceCode);
                writer.WritePropertyName("HouseType");
                writer.WriteValue(obj.HouseType);
                writer.WritePropertyName("TotalFloors");
                writer.WriteValue(obj.TotalFloors);
                writer.WritePropertyName("DoorType");
                writer.WriteValue(obj.DoorType);
                writer.WritePropertyName("BalconyType");
                writer.WriteValue(obj.BalconyType);
                writer.WritePropertyName("ApartmentPlan");
                writer.WriteValue(obj.ApartmentPlan);
                writer.WriteEndObject();
            }
        }
    }

    public class ContractConverter : JsonConverter<IContract>
    {
        public override IContract ReadJson(JsonReader reader, Type objectType, IContract existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            JObject obj = JObject.Load(reader);

            // Десериализация вложенного объекта
            IObject objectItem = null;
            if (obj["Object"] != null)
            {
                objectItem = obj["Object"].ToObject<Object>(serializer);
            }

            return new Contract(
                obj["Id"]?.Value<int>() ?? 0,
                obj["ClientId"]?.Value<int>() ?? 0,
                objectItem,
                obj["StartDate"]?.Value<DateTime>() ?? DateTime.Now,
                obj["EndDate"]?.Value<DateTime>() ?? DateTime.Now,
                obj["Penalty"]?.Value<int>() ?? 0,
                obj["InterestRate"]?.Value<float>() ?? 0f,
                obj["AdditionalConditions"]?.Value<string>(),
                obj["PaymentAmount"]?.Value<float>() ?? 0f
            );
        }

        public override void WriteJson(JsonWriter writer, IContract value, JsonSerializer serializer)
        {
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
                writer.WriteValue(contract.AdditionalConditions);
                writer.WritePropertyName("PaymentAmount");
                writer.WriteValue(contract.PaymentAmount);
                writer.WriteEndObject();
            }
        }
    }

    public class StolenItemConverter : JsonConverter<IStolenItem>
    {
        public override IStolenItem ReadJson(JsonReader reader, Type objectType, IStolenItem existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            JObject obj = JObject.Load(reader);
            return new StolenItem(
                obj["ItemName"]?.Value<string>(),
                obj["EstimatedValue"]?.Value<decimal>() ?? 0
            );
        }

        public override void WriteJson(JsonWriter writer, IStolenItem value, JsonSerializer serializer)
        {
            var item = value as StolenItem;
            if (item != null)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("ItemName");
                writer.WriteValue(item.ItemName);
                writer.WritePropertyName("EstimatedValue");
                writer.WriteValue(item.EstimatedValue);
                writer.WriteEndObject();
            }
        }
    }

    public class ArrestDetailsConverter : JsonConverter<IArrestDetails>
    {
        public override IArrestDetails ReadJson(JsonReader reader, Type objectType, IArrestDetails existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            JObject obj = JObject.Load(reader);
            return new ArrestDetails(
                obj["DocumentNumber"]?.Value<string>(),
                obj["IssuingAuthority"]?.Value<string>(),
                obj["DateOfIssue"]?.Value<DateTime>() ?? DateTime.Now
            );
        }

        public override void WriteJson(JsonWriter writer, IArrestDetails value, JsonSerializer serializer)
        {
            var details = value as ArrestDetails;
            if (details != null)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("DocumentNumber");
                writer.WriteValue(details.DocumentNumber);
                writer.WritePropertyName("IssuingAuthority");
                writer.WriteValue(details.IssuingAuthority);
                writer.WritePropertyName("DateOfIssue");
                writer.WriteValue(details.DateOfIssue);
                writer.WriteEndObject();
            }
        }
    }
}