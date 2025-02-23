using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the TextScript compiler");
        Console.WriteLine("Type 'Tutorial' to find commands");

        bool tBegin = true;
        string tVar = "";

            while (tBegin == true)
        {
            string tInput = Console.ReadLine();

            if (tInput == "Tutorial")
            {
                Console.WriteLine("Type 'print' to be prompted to print something");
                Console.WriteLine("Type 'var' to make a variable (you can change variables but only get 1 variable per script)");
            }
            else if (tInput == "var")
            {
                tVar = Console.ReadLine();
            }

            else if (tInput == "print")
            {
                string tPrint = Console.ReadLine();

                if (tPrint == "var")
                {
                    Console.WriteLine(tVar);
                }
                else
                {
                    Console.WriteLine(tPrint);
                }
            }
            
        }
    }
}
