using System.Collections;
using System;
using System.Collections.Generic;
class dictionary
{
  public void display()

  {
    Dictionary<int, bool> values = new Dictionary<int, bool>();
    values.Add(1, true);
    values.Add(2, false);
    values.Add(30, false);
    Console.WriteLine("Dictionary :");
    foreach (var item in values)
    {
      Console.WriteLine($"{item.Key} and values is {item.Value}");
    }
  }
}