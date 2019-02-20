using System.Collections.Generic;
using System;

namespace PlacesToGo.Models
{
  public class Place
  {
    private string CityName;
    private int Id;
    private static int IdCounter = 0;
    private static List<Place> Instances = new List<Place>(){};

    public Place(string cityName)
    {
      IdCounter++;
      Id = IdCounter;
      CityName = cityName;
      Instances.Add(this);
    }

    public string GetCityName()
    {
      return CityName;
    }

    public void SetCityName(string cityName)
    {
      CityName = cityName;
    }

    public int GetId()
    {
      return Id;
    }

    public static List<Place> GetAll()
    {
      return Instances;
    }

    public static Place Find(int id)
    {
      foreach (Place place in Instances)
      {
        if(place.Id == id)
        {
          return place;
        }
      }
      return null;
    }

    public static void Delete(int id)
    {
      Instances.Remove(Place.Find(id));
    }



  }
}
