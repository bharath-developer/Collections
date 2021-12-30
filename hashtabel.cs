using System;
using System.Collections.Generic;
using System.Collections;

class hashtables
{
  public void Display()
  {
    // Hashtables
    Hashtable values = new Hashtable();
    values.Add("0", ":");
    values.Add("1", 54);
    values.Add("2", DateTime.Now);
    values.Add("3", false);
    Console.WriteLine("Hash Tables");
    foreach (DictionaryEntry b in values)
    {
      Console.WriteLine($"{b.Key} and value is {b.Value}");
    }
  }
}