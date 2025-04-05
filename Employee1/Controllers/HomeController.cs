using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Employee1.Models;

namespace Employee1.Controllers;

public class HomeController : Controller
{
    private readonly EmployeeDbContext employeeDbContext;

    //private readonly ILogger<HomeController> _logger;

    //public HomeController(ILogger<HomeController> logger)
    //{
    //    _logger = logger;
    //}

    public HomeController(EmployeeDbContext employeeDbContext)
    {
        this.employeeDbContext = employeeDbContext;
    }

    public IActionResult Index()
    {
        var data = employeeDbContext.Employees.ToList();
        return View(data);
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Employee emp)
    {
        if (ModelState.IsValid)
        {
            employeeDbContext.Employees.Add(emp);
            employeeDbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        return View();
    }

    public IActionResult Edit(int? id)
    {
        var empdata = employeeDbContext.Employees.Find(id);
        return View(empdata);
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

