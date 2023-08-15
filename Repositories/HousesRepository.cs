
public class HousesRepository
{
    private readonly IDbConnection _db;

    public HousesRepository(IDbConnection db)
    {
        _db = db;
    }

    internal House GetHouseById(int houseId)
    {
        string sql = $"SELECT * FROM houses WHERE id = @houseId;";
        House house = _db.QueryFirstOrDefault<House>(sql, new {houseId} );
        return house;
    }

    internal int CreateHouse(House houseData)
    {
        string sql = @"
        INSERT INTO houses(bedrooms, bathrooms, price, isHaunted, description)
        VALUES (@Bedrooms, @Bathrooms, @Price, @IsHaunted, @Description);
        SELECT LAST_INSERT_ID()
        ;";
        int houseId = _db.ExecuteScalar<int>(sql, houseData);
        return houseId;
    }

    internal List<House> GetHouses()
    {
        string sql = "SELECT * FROM houses;";
        List<House> houses = _db.Query<House>(sql).ToList();
        return houses;
    }

    internal void RemoveHouse(int houseId)
    {
        string sql = "DELETE FROM houses WHERE id = @houseId LIMIT 1 ;";
        _db.Execute(sql, new {houseId} );
    }

    internal House UpdateHouse(House originalHouse)
    {
        string sql = @"
        UPDATE houses
        SET
        bathrooms = @Bathrooms,
        bedrooms = @Bedrooms,
        price = @Price,
        isHaunted = @IsHaunted,
        description = @Description
        WHERE id = @Id
        LIMIT 1;
        SELECT * FROM houses WHERE id = @Id
        ;";
        House updatedHouse = _db.QueryFirstOrDefault<House>(sql, originalHouse);
        return updatedHouse;
    }
}
