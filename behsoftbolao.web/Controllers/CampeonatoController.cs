using Microsoft.AspNetCore.Mvc;

namespace behsoftbolao.web.Controllers;

public class CampeonatoController : Controller
{

    public CampeonatoController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }


}
