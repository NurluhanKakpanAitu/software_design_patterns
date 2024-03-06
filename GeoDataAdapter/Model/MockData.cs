namespace GeoDataAdapter.Model;

public class MockData
{
    public static List<City> Cities { get; } =
    [
        new City()
        {
            Id = 1,
            Name = "Astana",
            Country = "Kazakhstan"
        },
        new City()
        {
            Id = 2,
            Name = "Almaty",
            Country = "Kazakhstan"
        },
        new City()
        {
            Id = 3,
            Name = "Moscow",
            Country = "Russia"
        },
        new City()
        {
            Id = 4,
            Name = "Saint Petersburg",
            Country = "Russia"
        },
        new City()
        {
            Id = 5,
            Name = "New York",
            Country = "USA"
        },
        new City()
        {
            Id = 6,
            Name = "Los Angeles",
            Country = "USA"
        },
        new City()
        {
            Id = 7,
            Name = "London",
            Country = "UK"
        },
        new City()
        {
            Id = 8,
            Name = "Manchester",
            Country = "UK"
        },
        new City()
        {
            Id = 9,
            Name = "Paris",
            Country = "France"
        },
        new City()
        {
            Id = 10,
            Name = "Lyon",
            Country = "France"
        }
    ];
}