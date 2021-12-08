using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharpFinalChallengeAssignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            DataContext dataContext = new DataContext(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CSharpFinalChallengeAssignment;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            Student student = new Student()
            {
                firstName = "John",
                lastName = "Doe",
                address = "123 Main Street, Beaverton, OR 97078",
                phoneNumber = "649-555-2958",
                emailAddress = "jDoe@gmail.com"
            };

            dataContext.Students.Add(student);
            dataContext.SaveChanges();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}