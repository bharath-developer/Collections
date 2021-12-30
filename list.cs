using System;
using System.Collections.Generic;
using System.Collections;
public class MyDefenititon
{
  public string name { get; set; }
  public int age { get; set; }
}
class list
{
  public void Diplay1()
  {
    List<string> values = new List<string>();
    values.Add("bharath");
    values.Add("siddhu");
    Console.WriteLine("List default");
    foreach (var item in values)
    {
      Console.WriteLine($"{item}");
    }
  }
  public void display2()
  {
    var values = new List<MyDefenititon>();
    values.Add(new MyDefenititon { name = "bharath", age = 45 });
    values.Add(new MyDefenititon { name = "siddhu", age = 35 });
    Console.WriteLine("List with another implementation");
    foreach (MyDefenititon data in values)
    {
      Console.WriteLine($"My name is {data.name} and my age is {data.age}");
    }
  }
}