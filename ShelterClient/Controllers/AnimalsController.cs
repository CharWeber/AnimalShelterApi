using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ShelterClient.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Diagnostics;

namespace ShelterClient.Controllers
{
  public class AnimalsController : Controller
  {
    public IActionResult Index()
    {
      var allAnimals = Animal.GetAnimals();
      return View(allAnimals);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(Animal animal)
    {
      Animal.PostAnimal(animal);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var animal = Animal.GetAnimal(id);
      return View(animal);
    }

    public IActionResult Edit(int id)
    {
      var animal = Animal.GetAnimal(id);
      return View(animal);
    }

    [HttpPost]
    public IActionResult Edit(Animal animal)
    {
      Animal.PutAnimal(animal);
      return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
      Animal.Delete(id);
      return RedirectToAction("Index");
    }
  }
}