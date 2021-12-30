using System;
using System.Collections.Generic;
using System.Collections;
class queue
{
  public void display()
  {
    Queue values = new Queue();
    values.Enqueue(":");
    values.Enqueue(1);
    values.Enqueue(true);
    values.Enqueue(DateTime.UtcNow);
    Console.WriteLine("Queue");
    foreach (var item in values)
    {
      Console.WriteLine($"{item}");
    }
  }
}