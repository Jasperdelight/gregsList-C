
public class HousesService
{
    private readonly HousesRepository _housesRepository;

    public HousesService(HousesRepository housesRepository)
    {
        _housesRepository = housesRepository;
    }

    internal House GetHouseById(int houseId)
    {
        House house = _housesRepository.GetHouseById(houseId);
            if (house == null)
    {
      throw new Exception($"{houseId} is not a valid ID");
    }
        return house;
    }

    internal House CreateHouse(House houseData)
    {
        int houseId = _housesRepository.CreateHouse(houseData);
        House newHouse = GetHouseById(houseId);
        return newHouse;
    }

    internal List<House> GetHouses()
    {
        List<House> house = _housesRepository.GetHouses();
        return house;
    }

    internal House RemoveHouse(int houseId)
    {
        House house = GetHouseById(houseId);
        _housesRepository.RemoveHouse(houseId);
        return house;
    }

    internal House UpdateHouse(int houseId, House houseData)
    {
        House originalHouse = GetHouseById(houseId);
        originalHouse.Bedrooms = houseData.Bedrooms ?? originalHouse.Bedrooms;
        originalHouse.Bathrooms = houseData.Bathrooms ?? originalHouse.Bathrooms;
        originalHouse.Price = houseData.Price ?? originalHouse.Price;
        originalHouse.IsHaunted = houseData.IsHaunted;
        originalHouse.Description = houseData.Description;
        House house = _housesRepository.UpdateHouse(originalHouse);
        return house;

    }
}
