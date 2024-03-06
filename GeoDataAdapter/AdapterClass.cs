namespace GeoDataAdapter;

public class AdapterClass(IGetDataService getDataService)
{
    private readonly IGetDataService _getDataService = getDataService;
    public string? GetSpecificItem(int cityId, string itemName)
    {
        var city = _getDataService.GetCityData(cityId);
        var property = city.GetType().GetProperty(itemName);
        if (property == null)
        {
            throw new Exception($"Not found property: {itemName}");
        }
        return property.GetValue(city)?.ToString();
    }
}