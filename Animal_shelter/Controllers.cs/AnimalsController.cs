using Microsoft.AspNetCore.Mvc;
using Animal_shelter.Models;
using System.Collections.Generic;
using System.Linq;

namespace Animal_shelter.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly Animal_shelterContext _db;

        public AnimalsController(Animal_shelterContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Animal> model = _db.Animals.ToList();
            return View(model);
        }
    }
}
