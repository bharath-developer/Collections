using System;
using System.Collections.Generic;
using System.Collections;

class Stacks
{
  public void Display()
  {
    //    stack
    Stack<string> values = new Stack<string>();
    values.Push("Bharath");
    values.Push("siddhu");
    values.Push("Maghesh");
    values.Push("Uma");
    values.Push("Chippi");
    Console.WriteLine("Stack");
    foreach (object item in values)
    {
      Console.WriteLine($"{item}");
    }
  }
}