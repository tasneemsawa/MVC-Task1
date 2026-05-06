using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public ViewResult Index()
        {
            var user= context.Users2.ToList();
            return View("Index", user);

        }

        public ViewResult Create()
        {
            return View("Create");
        }

        public ViewResult Store(User2 Request)
        {
            context.Users2.Add(Request);
            context.SaveChanges();
            return View("Create");
        }
    }
}
