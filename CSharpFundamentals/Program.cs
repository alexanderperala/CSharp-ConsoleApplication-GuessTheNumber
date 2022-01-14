using System;




namespace CSharpFundamentals
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rand = new Random();
            int guess = 0;
            int randomNumber = rand.Next(1, 100);
            int counter = 0;


            string welcome = "Gissa på ett nummer mellan 1 - 100!";
            Console.WriteLine(welcome);



            while (guess != randomNumber)
            {
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > randomNumber)
                    {
                        Console.WriteLine("För högt");
          
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("För lågt");
                    }
                }

                catch
                {
                    Console.WriteLine("Din gissning måste vara en siffra!");
                    counter--;
                }


                counter++;
            }

            Console.WriteLine("Grattis! Det tog dig {0} försök att gissa rätt", counter);
       

        }
    }
}