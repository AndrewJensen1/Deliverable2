using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool useracceptedinput = false;
            string mood = null;
            string transportation = null;
            string activity = null;
            while (useracceptedinput == false)
            {
                Console.WriteLine("Hello User, what are you in the mood for?");

                Console.WriteLine("Here are your options for today.");

                Console.WriteLine("1. Action");
                Console.WriteLine("2. Chilling");
                Console.WriteLine("3. Danger");
                Console.WriteLine("4. Good Food");


                string userinput = Console.ReadLine();

                if (userinput == "1")
                {
                    mood = "Action";
                    activity = "Stock Car Racing";
                    useracceptedinput = true;
                }
                else if (userinput == "2")
                {
                    mood = "Chilling";
                    activity = "Hiking";
                    useracceptedinput = true;
                }
                else if (userinput == "3")
                {
                    mood = "Danger";
                    activity = "Skydiving";
                    useracceptedinput = true;
                }
                else if (userinput == "4")
                {
                    mood = "Good Food";
                    activity = "to Taco Bell";
                    useracceptedinput = true;
                }
                else
                {
                    Console.WriteLine("I'm sorry, I don't understand your input. Please try again.");
                }
            }
            bool useracceptedinput2 = false;
            while (useracceptedinput2 == false)
            {
                Console.WriteLine("How many People are you bringing with you?");

                string userinput2 = Console.ReadLine();
                int userinputnumber = Convert.ToInt32(userinput2);

                if (userinputnumber == 0)
                {
                    transportation = "in Sneakers";
                    useracceptedinput2 = true;
                }
                else if (userinputnumber > 0 && userinputnumber <= 4)
                {
                    transportation = "in a Sedan";
                    useracceptedinput2 = true;
                }
                else if (userinputnumber >= 5 && userinputnumber <= 10)
                {
                    transportation = "by Volkswagen Bus";
                    useracceptedinput2 = true;
                }
                else if (userinputnumber >= 11)
                {
                    transportation = "by Airplane";
                    useracceptedinput2 = true;
                }
                else{
                    Console.WriteLine("I'm sorry, I don't understand your input. Please try again.");
                }
            }
            Console.WriteLine($"Okay if you’re in the mood for {mood}, then you should go {activity} and travel {transportation}!");

            Console.WriteLine("Good bye");
        }
    }
}
