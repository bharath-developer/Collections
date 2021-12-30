using System;
using System.Collections.Generic;
using System.Collections;
namespace exampleCollections
{

  class Program
  {
    static void Main(string[] args)
    {
      // Salmon fish = new Salmon();
      // fish.printSalmon();
      Arraylist values = new Arraylist();
      values.Display();
      hashtables form = new hashtables();
      form.Display();

      queue data = new queue();
      data.display();
      Stacks query = new Stacks();
      query.Display();
      list var1 = new list();
      var1.Diplay1();
      var1.display2();
      dictionary g = new dictionary();
      g.display();
      //Non generic collections

      //   HAshtables
      //   Hashtable values = new Hashtable();
      //   values.Add("0", ":");
      //   values.Add("1", 54);
      //   values.Add("2", DateTime.Now);
      //   values.Add("3", false);

      //    stack
      // Stack values = new Stack();
      // values.Push("Bharath");
      // values.Push("siddhu");
      // values.Push("Maghesh");
      // values.Push("Uma");
      // values.Push("Chippi");
      //    Queue
      //   Queue values = new Queue();
      //   values.Enqueue(":");
      //   values.Enqueue(1);
      //   values.Enqueue(true);
      //   values.Enqueue(DateTime.UtcNow);
      //Generic collections types
      // List
      // List<string> values = new List<string>();
      // values.Add("bharath");
      // values.Add("siddhu");
      // var values = new List<MyDefenititon>();
      // values.Add(new MyDefenititon { name = "bharath", age = 45 });
      // values.Add(new MyDefenititon { name = "siddhu", age = 35 });
      //Queue
      //   Queue<int> values = new Queue<int>();
      //   values.Enqueue(4);
      //   values.Enqueue(5);
      //   values.Enqueue(6);
      //   values.Enqueue(9);
      //Dictonary
      //   Dictionary<int, bool> values = new Dictionary<int, bool>();
      //   values.Add(1, true);
      //   values.Add(2, false);
      //   values.Add(30, false);
      //sorted list
      // SortedList<int, string> values = new SortedList<int, string>();
      // values.Add(10, "BHarath");
      // values.Add(-2, "siddhu");
      // values.Add(30, "Uma");
      // values.Add(0, "Chippi");
      //   sorted list
      //   SortedList values = new SortedList();
      //   values.Add(1, "Bhararth");
      //   values.Add(2, 4854);
      //   values.Add(10, false);
      //   values.Add(4, 4501.06);
      //   values.Add(5, DateTime.Today);
      // Hashtable values = new Hashtable();
      // values.Add("Data", ":");
      // values.Add("Datas", ":");
      // values.Add("Datass", ":");
      // values.Add("Datasss", ":");
      // foreach (DictionaryEntry value in values)
      // {
      //   Console.WriteLine($"{value.Key}  {value.Value} ");
      // }
    }

  }
}
