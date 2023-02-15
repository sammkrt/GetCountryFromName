using GetCountryFromName.Models;
using Microsoft.AspNetCore.Mvc;

namespace GetCountryFromName.Controllers;


public class CountryController : Controller
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
        return View(result);
    }


}