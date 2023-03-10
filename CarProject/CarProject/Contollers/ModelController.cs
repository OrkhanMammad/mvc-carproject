using CarProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarProject.Contollers
{
    public class ModelController : Controller
    {
        public IActionResult Index(int? id)
        {
            List<CarModel> carModels = new List<CarModel>();
            CarModel model1 = new CarModel()
            {
                ID=1,
                MarkaID=1,
                ModelName="S500"
            };

            CarModel model2 = new CarModel()
            {
                ID = 2,
                MarkaID = 1,
                ModelName = "C300"
            };


            CarModel model3 = new CarModel()
            {
                ID = 3,
                MarkaID = 2,
                ModelName = "x5"
            };

            CarModel model4 = new CarModel()
            {
                ID = 4,
                MarkaID = 2,
                ModelName = "530i"
            };

            carModels.Add(model1);
            carModels.Add(model2);
            carModels.Add(model3);
            carModels.Add(model4);

            if (carModels.Exists(x => x.MarkaID == id))
            {
                return View(carModels.FindAll(x=>x.MarkaID==id));
            }

            else
            {
                return BadRequest();
            }




            
        }
    }
}
