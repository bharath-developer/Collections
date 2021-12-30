using System;
using System.Collections.Generic;
class Salmon
{
  public void printSalmon()
  {
    // var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };
    // salmons.Add("Red eye");
    // Console.WriteLine(salmons.Contains("coho"));
    // Console.WriteLine(salmons.Find(item => item.Contains("coho")));
    // Console.WriteLine(salmons.Remove("coho"));
    // salmons.ForEach(item => Console.WriteLine(item));
    // Iterate through the list.
    // foreach (var salmon in salmons)
    // {
    //   Console.WriteLine(salmon + " ");
    // }
    List<string> salmonFish = new List<string>();
    salmonFish.Add("Red Eye");
    salmonFish.Add("Coho");
    salmonFish.Add("shan");
    salmonFish.Add("yoshi");
    // string[] nameCopy = new string[10];
    // salmonFish.CopyTo(nameCopy);
    // foreach (var item in nameCopy)
    // {
    //   Console.WriteLine($"{item}");
    // }
    bool value;
    value = salmonFish.Exists(each => each == "Coho");
    Console.WriteLine(value);
  }

}

