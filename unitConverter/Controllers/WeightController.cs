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


    public IActionResult InitializeData(string weightInput, string convertFrom, string convertTo){

        var model = new WeightModel(weightInput, convertFrom, convertTo);


        return View("Views/Weights/New.cshtml",model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
