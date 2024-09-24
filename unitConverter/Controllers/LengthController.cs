using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using unitConverter.Models;

namespace unitConverter.Controllers;

public class LengthController : Controller
{
    private readonly ILogger<LengthController> _logger;

    public LengthController(ILogger<LengthController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("Views/Lengths/Index.cshtml");
    }

    [HttpPost]
    public IActionResult ReceiveData(string length, string convertFrom, string convertTo)
    {   
        var model = new LengthModel(length, convertFrom, convertTo);
        
        // Perform conversion logic here if needed
        // model.ConvertedLength = PerformConversion(model);
        
        return View("Views/Lengths/New.cshtml",model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
