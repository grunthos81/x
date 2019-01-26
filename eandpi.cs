using System;
namespace projecteuler{
    class eandpi{
        static void blah(){
            double pi = 3.141592653589793;
            double e = 2.718281828459045;
            Console.WriteLine("Welcome to the rounding tool.");
            Console.WriteLine("All I do is round pi or e to a precision of your choice");
            Console.WriteLine("First, make a choice: 1 for pi, 2 for e:");
            int choice = 0;
            while ((choice != 1) & (choice != 2)){
                try{
                    choice = Int32.Parse(Console.ReadLine());
                    if ((choice != 1) & (choice != 2))
                    {
                        Console.WriteLine("Needs to be 1 or 2");
                    }}
                catch (System.FormatException ex)
                {Console.WriteLine("Digits only please");}}
            Console.WriteLine("Please input a number between 1 and 15:");
            int numDigits = 0;
            while ((numDigits < 1) | (numDigits > 15))
            {
                try{
                    numDigits = Int32.Parse(Console.ReadLine());
                    if ((numDigits < 1) | (numDigits > 15))
                    {
                        Console.WriteLine("Needs to be between 1 and 15");
                    }}
                catch (System.FormatException ex)
                {Console.WriteLine("Digits only please");}
            }
            if (choice == 1) { Console.WriteLine(Math.Round(pi, numDigits)); }
            if (choice == 2) { Console.WriteLine(Math.Round(e, numDigits)); }}}}
        
