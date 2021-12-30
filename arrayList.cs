using System;
using System.Collections.Generic;
using System.Collections;

class Arraylist
{
  //   ArrayList
  public void Display()
  {
    ArrayList values = new ArrayList();
    values.Add(":");
    values.Add(1);
    values.Add(true);
    values.Add(DateTime.Now);
    Console.WriteLine("Arraylist");
    foreach (object value in values)
    {
      Console.WriteLine($"{value} ");
    }
  }
}