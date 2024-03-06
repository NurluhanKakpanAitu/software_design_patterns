using GeoDataAdapter;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var getDataService = new GetDataService();
            var fullCity = getDataService.GetCityData(10);
            Console.WriteLine($"City: {fullCity.Name}, Country: {fullCity.Country}");
            var adapter = new AdapterClass(getDataService);
            var cityCountryName = adapter.GetSpecificItem(10, "Name");
            Console.WriteLine($"Result: {cityCountryName}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}