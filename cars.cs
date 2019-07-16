using System;
using System.Collections.Generic;

class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;

  public Car(string makeModel, int price, int miles)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
  }

  public bool WorthBuying(int maxPrice)
  {
   return (Price < maxPrice);
  }

  public bool WorthMiles (int maxMiles)
  {
  return (Miles < maxMiles);
  }
}
public class Program
{
  public static void Main()
  {
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
    Car yugo = new Car("1980 Yugo Koral", 700, 56000);
    Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
    Car amc = new Car("1976 AMC Pacer", 400, 198000);

    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximium miles: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice) && (automobile.WorthMiles(maxMiles)))
      {
        CarsMatchingSearch.Add(automobile);
      }
      else if (automobile.WorthMiles(maxMiles))
      {
        CarsMatchingSearch.Add(automobile);
      }
      else{
        
        Console.WriteLine("you dont have any cars within this criteria");

      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
    }
    
  }
}
