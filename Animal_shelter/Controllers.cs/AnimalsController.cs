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
            List<Animal> model = _db.Animals.OrderBy(a => a.Breed).ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Animal animal)
        {
            _db.Animals.Add(animal);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
