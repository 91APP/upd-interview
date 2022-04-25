using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyCheckedList.Models;

namespace MyCheckedList.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IMessageSender _messageSender;
    private readonly IConfiguration _config;

    public HomeController(
        ILogger<HomeController> logger, 
        IMessageSender messageSender,
        IConfiguration config)
    {
        _logger = logger;
        _messageSender = messageSender;
        _config = config;
    }

    public IActionResult Index()
    {
        _messageSender.SendMessage();

        var appName = _config["AppName"];

        Console.WriteLine(appName);

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
