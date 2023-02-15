using GetCountryFromName.Models;
using Microsoft.AspNetCore.Mvc;

namespace GetCountryFromName.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CountryController : ControllerBase
{
    private ICountryService _countryService;

    public CountryController(ICountryService countryService)
    {
        _countryService = countryService;
    }

    [HttpGet("{name}")]
    public async Task<ActionResult<CountryResponse>> GetCountry(string name)
    {
        var result = await _countryService.GetCountry(name);
        return result;

        // return new CountryResponse()
        // {
        //     CountryId = result.CountryId
        // };
    }

}