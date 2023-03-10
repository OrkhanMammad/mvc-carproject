using Microsoft.AspNetCore.Mvc;
using CarProject.Models;

namespace CarProject.Contollers
{
    public class CarListController : Controller
    {
       private readonly List<Cars> carsList=new List<Cars>();
        public CarListController()
        {
            Cars car1= new Cars()
            {
                ID= 1,
                ModelID=1,
                BanType="sedan",
                FuelType="oil",
                year=1999
            };
            Cars car2 = new Cars()
            {
                ID = 2,
                ModelID = 2,
                BanType = "hatchback",
                FuelType = "oil",
                year = 1990
            };
            Cars car3 = new Cars()
            {
                ID = 2,
                ModelID = 2,
                BanType = "minivan",
                FuelType = "gas",
                year = 2020
            };
            Cars car4 = new Cars()
            {
                ID = 4,
                ModelID = 3,
                BanType = "sedan",
                FuelType = "gas",
                year = 2021
            };


            carsList.Add(car1);
            carsList.Add(car2);
            carsList.Add(car3);
            carsList.Add(car4);






        }




        public IActionResult Index(int? id) 
        {
            if (id == null)
            {
                return View(carsList);
            }
            if(carsList.Exists(x => x.ModelID == id))
            {
                return View(carsList.FindAll(x => x.ModelID == id));
               
            }
            else
            {

                return Content("bu modelde masin yoxdur");

            }



            
        }
    }

   
}
