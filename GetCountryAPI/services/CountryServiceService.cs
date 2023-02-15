using System.Text;
using System.Text.Json;
using GetCountryFromName.Models;

namespace GetCountryFromName;

public class CountryServiceService : ICountryService
{
    public async Task<CountryResponse> GetCountry(string name)
    {
        var client = new HttpClient();
        var url = $"https://api.nationalize.io/?name={name}";
        var response = await client.GetStreamAsync(url);
        return await JsonSerializer.DeserializeAsync<CountryResponse>(response);
    }
}