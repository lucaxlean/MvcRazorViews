using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;

namespace MvcRazorViews.Controllers; 

public class EStudanteController : Controller
{ 
    private List<EstudanteViewModel> estudantes = new List<EstudanteViewModel>{
        new EstudanteViewModel(1, "Lucas", "R. Lu, n.1", true), 
        new EstudanteViewModel(1, "Jessica", "R. Je, n.2", true),
        new EstudanteViewModel(1, "Roberto", "R. Ro, n.3", false),
    };


    public IActionResult Index()
    { 
        //return View(new List<EstudanteViewModel>()); 

        return View(estudantes); 

    } 

    public IActionResult Show(int id) 
    {
        return View(estudantes[id-1]); 
    } 
    

}