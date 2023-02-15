using GetCountryFromName.Models;

namespace GetCountryFromName;

public interface ICountryService
{
    public Task<CountryResponse> GetCountry(string name);
}