using System;
using System.Collections.Generic;

namespace petToAdoptAdoption
{
  class Program
  {
    static void Main(string[] args)
    {
      var shelter = new List<string>();

      var isRunning = true;
      while (isRunning)
      {

        Console.WriteLine("Current Pets");
        Console.WriteLine($"There are {shelter.Count} pets");
        for (var i = 0; i < shelter.Count; i++)
        {
          var currentPet = shelter[i];
          Console.WriteLine($"{i}:{currentPet}");
        }

        //small menu system for the user
        Console.WriteLine("what do you want to do?");
        Console.WriteLine("(ADD) a pet?");
        Console.WriteLine("(ADOPT) a pet? ");
        Console.WriteLine("(QUIT)");
        var input = Console.ReadLine();

        if (input.ToLower() == "add")
        {
          Console.WriteLine("What pet do you want to add?");
          var petToAdd = Console.ReadLine();
          shelter.Add(petToAdd);
        }
        else if (input.ToLower() == "adopt")
        {
          //Delete...Remove
          Console.WriteLine("Who is getting adopted");
          var petToAdopt = Console.ReadLine();
          shelter.Remove(petToAdopt);
        }
        else if (input.ToLower() == "quit")
        {
          isRunning = false;
        }
        Console.WriteLine("Goodbye");
      }
    }
  }
}
