using System;
using System.Collections.Generic;

namespace Dealership {

public class Program
{
  public static void Main()
  {
    Car porshe = new Car("2014 Porshe 911", 114991, 7893);
    Car ford = new Car("2011 Ford F450", 56000, 23888);
    Car lexus = new Car("2013 Lexus RX 350", 44700, 20000);
    Car mercedes = new Car ("Mercedes Benz CLS550", 39900, 37979);

    List<Car> Cars = new List<Car>() { porshe, ford, lexus, mercedes };

    lexus.SetPrice(2000);

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice))
      {
        CarsMatchingSearch.Add(automobile);
       }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.GetMakeModel());
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine("------------------------");
      Console.WriteLine(automobile.GetMakeModel());
      Console.WriteLine(automobile.GetMiles() + "miles");
      Console.WriteLine("$" + automobile.GetPrice());
    }
  }
}
}
