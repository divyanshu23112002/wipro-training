using Microsoft.AspNetCore.Mvc;

public class HomeController:Controller
{
    private readonly ILogger<HomeController> _logger;
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public string Index()
    {
        return "This is the Index Action";
    }
}