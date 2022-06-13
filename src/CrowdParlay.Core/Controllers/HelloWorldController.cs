using CrowdParlay.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrowdParlay.Core.Controllers;

public class HelloWorldController : Controller
{
    public IActionResult Index()
    {
        var model = new HelloWorldViewModel
        {
            Text = "Hello World!"
        };
        
        return View(model);
    }
}
