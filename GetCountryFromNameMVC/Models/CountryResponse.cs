using System.Text.Json.Serialization;

namespace GetCountryFromName.Models;

public class Country
{
    [JsonPropertyName("country_id")]
    public string? CountryId { get; set; }

    [JsonPropertyName("probability")]
    public double Probability { get; set; }
}

public class CountryResponse
{
    [JsonPropertyName("country")]
    public List<Country>? Country { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
