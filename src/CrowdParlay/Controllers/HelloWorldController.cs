using CrowdParlay.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrowdParlay.Controllers;

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
