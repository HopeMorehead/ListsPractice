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


            /*   List<int> favNumbers = new List<int>();

               //A list is index.
               favNumbers.Add(7);
               favNumbers.Add(25);
               favNumbers.Add(30);

               foreach (int number in favNumbers)
               {
                  // Console.WriteLine(number);

               }
               Console.WriteLine(favNumbers.Count);
               List<string> books = new List<string> {"Cat in the hat", "Toad nd frog", "Green eggs and ham"};
               books.Insert(0, "Hoton hears a Who");
               Console.WriteLine(books[0]);
               //Inserts at the current index moving the previous element down one
               books.Insert(0, "Horton hears a who");
               Console.WriteLine(books[0]);
               //Create a List and add 5 animals using the .Add()
               //Print each animal in the list

               //create the following list:
               //A bool list {true, false, false,true,false}
               //Loop through each value
               //if the valuse is true print "Better bring an umbrella"
               //if the value is false print "No rain today enjoy the sun"

               List<string> animals = new List<string>();
               animals.Add("pigs");
               animals.Add("pigglets");
               animals.Add("piggies");
               animals.Add("mama pig");
               animals.Add("daddy pig");

               foreach( string pig in animals)
               {

                   Console.WriteLine(pig);
               }



               List<bool> weather = new List<bool> { true,false,true,false};
               foreach (bool temp in weather)

               {
                   if (temp==true)
                   {


                       Console.WriteLine("better bring an umbrella");
                   }
                   else
                   {
                       Console.WriteLine("No rain today enjoy the sun");
                   }
               }

               List<string> faveFoods = new List<string>() { "steak", "fish", "katsudon", "Ice cream", "Nachos" };
               //contains returns a boolean then  it adds it if it doesn't
               if (faveFoods.Contains("fish"))
               {
                   Console.WriteLine("I like fish too");
               }
               //create a list with the following numbers: 1 23 9 77 922 6 32 63 14 5
               //use the contains method with the following values:23 77 15
               //Remove these elements: 23 77 32 and 6
               // use Contains() again on these values:23 77 15*/





            List<int> numbers = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            Console.WriteLine(numbers.Contains(23));
            Console.WriteLine(numbers.Contains(77));
            Console.WriteLine(numbers.Contains(32));
            Console.WriteLine(numbers.Contains(6));
            numbers.Remove(23);
            numbers.Remove(77);
            numbers.Remove(32);
            numbers.Remove(6);
            Console.WriteLine(numbers.Contains(23));
            Console.WriteLine(numbers.Contains(77));
            Console.WriteLine(numbers.Contains(32));
            Console.WriteLine(numbers.Contains(6));


            //movie ordering service. Ask the user for a movie check my list if it contains enter somethingelse. if it doesn't exist add quit
            //more then one datatype;

            bool Leave = false;
            List<string> movies = new List<string> { "Hope" };


            Console.WriteLine("Would you like to rent a movie");
            string userInput = Console.ReadLine();

            do
                foreach (string Cinima in movies)
                {
                    if (userInput == "quit")
                    {
                        Leave = true;
                    }

                    if (!(movies.Contains(userInput)))
                    {
                        movies.Add(userInput);
                        Console.WriteLine($"The movie has been added {Cinima},{userInput}");
                        


                    }
                    else
                    {
                        Console.WriteLine("The movie is on it's way");
                    }

                }
            while (Leave == false);
        }

    }   
}

