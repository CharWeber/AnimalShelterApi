using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;


namespace ShelterClient.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public static List<Animal> GetAnimals()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Animal> animalList = JsonConvert.DeserializeObject<List<Animal>>(jsonResponse.ToString());

      return animalList;
    }
    public static Animal GetAnimal(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Animal animalList = JsonConvert.DeserializeObject<Animal>(jsonResponse.ToString());

      return animalList;
    }
    public static void PostAnimal(Animal animal)
    {
      string jsonAnimal = JsonConvert.SerializeObject(animal);
      var apiCallTask = ApiHelper.Post(jsonAnimal);
    }
    public static void PutAnimal(Animal animal)
    {
      string jsonAnimal = JsonConvert.SerializeObject(animal);
      var apiCallTask = ApiHelper.Put(animal.AnimalId, jsonAnimal);
    }
    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }
  }
}