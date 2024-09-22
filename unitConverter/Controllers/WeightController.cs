using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using unitConverter.Models;

namespace unitConverter.Controllers;

public class WeightController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public WeightController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("Views/Weights/Index.cshtml");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
