using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> favNumbers = new List<int>();
            favNumbers.Add(7);
            favNumbers.Add(25);
            favNumbers.Add(30);
            
            foreach(int number in favNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(favNumbers.Count);

            List<string> books = new List<string> { "Cat in the hat", "Todad and frog", "Green eggs and ham" };
            Console.WriteLine(books[0]);
            books.Insert(0, "Horton hears a who");
            Console.WriteLine(books[0]);

            //Create a list and add 5 animals using the .Add()
            //Print each animal in the list

            List<string> animals = new List<string>();
            animals.Add("Lion");
            animals.Add("Dolphin");
            animals.Add("Hippo");
            animals.Add("Platypus");
            animals.Add("Hare");

            foreach(string animal in animals)
            {
                Console.WriteLine(animal);
            }



            //Create the following list:
            //A bool list {true, false, false, true, false}
            //Loop through each value
            //If the value is true, print "Better bring an umbrella"
            //If the value is false print "No rain today enjoy the sun"

            List<bool> trueFalse = new List<bool> {true, false, false, true, false };
            foreach (bool answer in trueFalse)
            {
                if (answer == true)
                {
                    Console.WriteLine("Better bring an umbrella");
                }
                else
                {
                    Console.WriteLine("No rain today, enjoy the sun");
                }
            }



            List<string> favFoods = new List<string>() { "Steak", "fish", "katsudon", "Ice cream", "nachos" };


            if (favFoods.Contains("fish"))
                    {
                Console.WriteLine("I like fish too!!!");
            }


        }
    }
}
