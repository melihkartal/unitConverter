using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using unitConverter.Models;

namespace unitConverter.Controllers;

public class LengthController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public LengthController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("Views/Lengths/Index.cshtml");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
