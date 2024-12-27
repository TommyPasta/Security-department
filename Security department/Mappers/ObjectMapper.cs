using Security_department.DTOs;

namespace Security_department.Mappers
{
    public static class ObjectMapper
    {
        public static ObjectDTO ToDto(Object obj)
        {
            if (obj == null) return null;

            return new ObjectDTO
            {
                Id = obj.Id,
                Address = obj.Address,
                Floor = obj.Floor,
                EntranceCode = obj.EntranceCode,
                HasEntranceCode = obj.HasEntranceCode,
                HouseType = obj.HouseType,
                TotalFloors = obj.TotalFloors,
                DoorType = obj.DoorType,
                BalconyType = obj.BalconyType,
                ApartmentPlan = obj.ApartmentPlan
            };
        }

        public static Object ToEntity(ObjectDTO objectDto)
        {
            if (objectDto == null) return null;

            return new Object(
                objectDto.Id,
                objectDto.Address,
                objectDto.Floor,
                objectDto.EntranceCode,
                objectDto.HasEntranceCode,
                objectDto.HouseType,
                objectDto.TotalFloors,
                objectDto.DoorType,
                objectDto.BalconyType,
                objectDto.ApartmentPlan
            );
        }
    }
}