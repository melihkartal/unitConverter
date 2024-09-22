using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using unitConverter.Models;

namespace unitConverter.Controllers;

public class TemperatureController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public TemperatureController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("Views/Temperatures/Index.cshtml");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
