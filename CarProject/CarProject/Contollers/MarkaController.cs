using CarProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarProject.Contollers
{
    public class MarkaController : Controller
    {
        public IActionResult Index()
        {
            List<Marka> markas= new List<Marka>();

            Marka marka1= new Marka()
            {
                ID= 1,
                Name="Mercedes"
            };

            Marka marka2 = new Marka()
            {
                ID = 2,
                Name = "BMW"
            };

            markas.Add(marka1);
            markas.Add(marka2);







            return View(markas);
        }
    }
}
