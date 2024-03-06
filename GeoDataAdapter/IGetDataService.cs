using GeoDataAdapter.Model;

namespace GeoDataAdapter;

public interface IGetDataService
{
    City GetCityData(int cityId);
}