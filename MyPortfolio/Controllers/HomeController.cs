using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers;

public class HomeController : Controller
{
    private List<Portfolio> _portfolios = new List<Portfolio>()
    {
        new Portfolio
        {
            Id = 1,Name = "project 1",Image = "01.jpg" ,Description = "this a first project"
        },
        new Portfolio
        {
            Id = 2,Name = "project 2",Image = "02.jpg" ,Description = "this a second project"
        },
        new Portfolio
        {
            Id = 3,Name = "project 3",Image = "03.jpg" ,Description = "this a third project"
        },
        new Portfolio
        {
            Id = 4,Name = "project 4",Image = "04.jpg" ,Description = "this a fourth project"
        },
    };
    
    public IActionResult Index()
    {
        ViewData["headingTitle"] = "Welcom To My WebSite";
        ViewData["headingText"] = "This Place is For Display Description ";
        return View(_portfolios);
    }

    public IActionResult Contact()
    {
        var contact = new Contact()
        {
            Email = "test",
            Mobile = "0912",
            Github = "test"
        };
        return View(contact);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}