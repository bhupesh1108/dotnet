using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using newMVCPROJ.Models;
using Model;
using BLL;
using Google.Protobuf.WellKnownTypes;
namespace newMVCPROJ.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Login(){
        return View();

    }
    public IActionResult List(){
          List<Student> st=Catalog.getAll();
        ViewData["student"]=st;
        return View();
    }

    public IActionResult Index()
    {
     
        return  RedirectToAction("List");
    }
    public IActionResult Edit(int id){
        List<Student> st=new List<Student>();
        st=Catalog.getAll();
        Student stu=new Student();
        Student s=st.Find((stud)=>stud.Id==id);
        ViewData["stu"]=s;
        return View();
    }
 
    [HttpPost]
    public IActionResult Edit(int id ,String firstname,String lastname,String email){
        bool flag=Catalog.Update(id,firstname,lastname,email);
        if(flag){
            return RedirectToAction("List");
        }
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
