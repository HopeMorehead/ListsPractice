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
















        }
    }
}
