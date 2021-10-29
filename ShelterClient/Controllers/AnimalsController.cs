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
    public IactionResult Index()
    {
      var allAnimals = Animal.GetAll();
      return View(allAnimals);
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

    public IActionResult Delete(int id)
    {
      Aniaml.Delete(id);
      return RedirectToAction("Index");
    }
  }
}