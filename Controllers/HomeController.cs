using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RickAndMorty_MVC.Models;

namespace RickAndMorty_MVC.Controllers;

public class HomeController : Controller
{
    public IWebApiService _webApiService { get; set; }
    public HomeController(IWebApiService webApiService)
    {
        _webApiService = webApiService;
    }

    public IActionResult Index()
    {
        RickAndMortyDMO result = _webApiService.GetAll();
        return View(result);
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
