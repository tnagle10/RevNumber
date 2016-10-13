using System;


namespace RevNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string Line = "";
            var Space = "\n";

            //Repeat this code until the user enters "y"
            while (Line != "q")
            {
                // Get number from user
                Console.WriteLine("This program will reverse a whole number you enter (No decimal points).  Please enter a number to begin. (Type y to exit)");
                Line = Console.ReadLine(); 

                // If user enters "y", execute exit procedure
                if (Line == "y") 
                {
                    Console.WriteLine(Space);
                    Console.WriteLine("You entered y");
                    Console.WriteLine(Space);
                    Console.WriteLine("Are you sure you want to exit? (Type y to confirm)"); //Make sure they want to quit
                    Line = Console.ReadLine(); // Get string from user        
                    if (Line == "y")
                    { return; }

                }

                // Try to reverse number
                Decimal Divider = 10; 
                Decimal Remainder = 0;
                String Output = "";
                try
                {
                    // Verify user input is in correct format 
                    Decimal InputNumber = Convert.ToDecimal(Line);
                    Decimal Quotient = InputNumber;  // Set initial quotient to entire number entered

                    // While we are not at the end of the number (i.e. dividing by 10 doesn't give us a zero quotient).
                    // Create a string of remainders in reverse order
                    while (Quotient != 0)
                    {
                        // Calculate the quotient and remainder 
                        Remainder = Quotient % Divider;
                        Quotient = Math.Round(Quotient / Divider);
                        Convert.ToString(Remainder);
                        Output = Output + Remainder;
                    }

                    Console.WriteLine(Space);
                    Console.WriteLine("Here is the number reversed:");
                    Console.WriteLine(Output);
                    Console.WriteLine(Space);
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine(Space);
                    System.Console.WriteLine(
                        "The conversion from string to number overflowed.");
                        Console.WriteLine(Space);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine(Space);
                    System.Console.WriteLine(
                        "The string is not formatted as a number.");
                        Console.WriteLine(Space);
                }
                catch (System.ArgumentNullException)
                {
                    Console.WriteLine(Space);
                    System.Console.WriteLine(
                        "The string is null.");
                        Console.WriteLine(Space);
                }

            }
         }
    }
}
