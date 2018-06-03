using System.Diagnostics;
using AlbumsProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AlbumsProject.Web.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}