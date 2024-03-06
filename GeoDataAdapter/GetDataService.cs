using GeoDataAdapter.Model;

namespace GeoDataAdapter;

public class GetDataService : IGetDataService
{
    public City GetCityData(int cityId)
    {
        var city = MockData.Cities.FirstOrDefault(q => q.Id == cityId);
        if (city == null)
        {
            throw new Exception($"Not found City by id: {cityId}");
        }
        return city;
    }
}