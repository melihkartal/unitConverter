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
    public IActionResult InitializeData(string length, string convertFrom, string convertTo)
    {   
        //create a model object w/data 
        var model = new LengthModel(length, convertFrom, convertTo);
     
        
        //the view gets the copy of the model we created
        return View("Views/Lengths/New.cshtml",model);
    }

    public string welcomeMessage(){
        return "this is a welcome message";
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
