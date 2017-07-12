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
            //List<int> favNumbers = new List<int>();
            //favNumbers.Add(7);
            //favNumbers.Add(25);
            //favNumbers.Add(30);

            //foreach(int number in favNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine(favNumbers.Count);

            //List<string> books = new List<string> { "Cat in the hat", "Todad and frog", "Green eggs and ham" };
            //Console.WriteLine(books[0]);
            //books.Insert(0, "Horton hears a who");
            //Console.WriteLine(books[0]);

            ////Create a list and add 5 animals using the .Add()
            ////Print each animal in the list

            //List<string> animals = new List<string>();
            //animals.Add("Lion");
            //animals.Add("Dolphin");
            //animals.Add("Hippo");
            //animals.Add("Platypus");
            //animals.Add("Hare");

            //foreach(string animal in animals)
            //{
            //    Console.WriteLine(animal);
            //}



            ////Create the following list:
            ////A bool list {true, false, false, true, false}
            ////Loop through each value
            ////If the value is true, print "Better bring an umbrella"
            ////If the value is false print "No rain today enjoy the sun"

            //List<bool> trueFalse = new List<bool> {true, false, false, true, false };
            //foreach (bool answer in trueFalse)
            //{
            //    if (answer == true)
            //    {
            //        Console.WriteLine("Better bring an umbrella");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No rain today, enjoy the sun");
            //    }
            //}



            //List<string> favFoods = new List<string>() { "Steak", "fish", "katsudon", "Ice cream", "nachos" };


            //if (favFoods.Contains("fish"))
            //        {
            //    Console.WriteLine("I like fish too!!!");
            //}






            ////Create a list with the following numbers: 1 23 9 77 922 6 32 63 14 5
            ////Use the contains mehtod with the following values: 23 77 15
            ////Remove these elements: 23 77 32 and 6
            ////Use .Contains() again on these values: 23 77 15

            //List<int> numbers = new List<int> { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };


            //if (numbers.Contains(23))
            //{
            //    Console.WriteLine("Busted!");
            //    numbers.Remove(23);
            //}

            //if (numbers.Contains(77))
            //{
            //    Console.WriteLine("Busted, again!");
            //    numbers.Remove(77);
            //}

            //if (numbers.Contains(15))
            //{
            //    Console.WriteLine("Busted, once more!");
            //}

            //if (numbers.Contains(32))
            //{
            //    numbers.Remove(32);
            //}

            //if (numbers.Contains(6))
            //{
            //    numbers.Remove(6);
            //}

            //if(numbers.Contains(23))
            //{
            //    Console.WriteLine("Busted!");
            //}

            //if (numbers.Contains(77))
            //{
            //    Console.WriteLine("Busted, again!");
            //}

            //if (numbers.Contains(15))
            //{
            //    Console.WriteLine("Busted, once more!");
            //}


            ////OR
            //List<int> numbersTwo = new List<int> { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            //Console.WriteLine(numbersTwo.Contains(23));
            //Console.WriteLine(numbersTwo.Contains(77));
            //Console.WriteLine(numbersTwo.Contains(15));

            //numbersTwo.Remove(23);
            //numbersTwo.Remove(77);
            //numbersTwo.Remove(32);
            //numbersTwo.Remove(6);

            //Console.WriteLine(numbersTwo.Contains(23));
            //Console.WriteLine(numbersTwo.Contains(77));
            //Console.WriteLine(numbersTwo.Contains(15));


            //Ask the user for a movie***
            //if the movie is not in the list, add it***
            //inform the user that the movie has been added***
            //if the movie IS in the list, inform the user that the movie is on the way
            //if the user enters quit, the program should exit
            //the user should be able to add as many movies as they want
            //When the user quits, show them all of the movies that are one the list

            Console.WriteLine("Welcome to the movie database!!! Please select a movie of your choice.");


            List<string> movieDatabase = new List<string>();
            movieDatabase.Add("Rocky");
            movieDatabase.Add("Nightmare on Elm Street");
            movieDatabase.Add("Hocus Pocus");
            movieDatabase.Add("3 Ninjas");
            movieDatabase.Add("Howard the Duck");
            movieDatabase.Add("The Last Dragon");

            string userAnswer = Console.ReadLine();



            //Do While

            if (userAnswer == "quit")
            {
                Console.WriteLine("Thank you for your time. Here is a list of our movies: " + movieDatabase);
            }
            else
            {

            }

            do
            {
                if (movieDatabase.Contains(userAnswer))
                {
                    Console.WriteLine("Your movie is on the way!!!");

                }

                else
                {
                    movieDatabase.Add(userAnswer);
                    Console.WriteLine("The movie title isn't available, but has been added. Please be patient");
                }

                Console.WriteLine("Would you like to select another movie?");
                if (movieDatabase.Contains(userAnswer))
                {
                    Console.WriteLine("Your movie is on the way!!!");

                }

                else
                {
                    movieDatabase.Add(userAnswer);
                    Console.WriteLine("The movie title isn't available, but has been added. Please be patient");
                }
            }
            while (userAnswer != "quit");







            string movieSearch;
            Console.WriteLine("Welcome to ...");
            List<string> movies = new List<string> { "" };


        }
    }
}
