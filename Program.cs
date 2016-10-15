using System;


namespace RevNumber
{
    class Program
    {



        private static decimal ConvToDecimalWithErrorCheck(string Input)
        {
            // This method converts a string to decimal using Convert.ToDecimal().
            // It uses System error checking to make sure the input valid.
            // If the input is valid, it returns the input converted to decimal.
            // If the input is invalid, it returns a 0  

            var Space = "\n";
            try
            {
                // Verify user input is in correct format 
                Decimal Output = Convert.ToDecimal(Input);
                return Output;
            }
            catch (System.OverflowException)
            {
                Console.WriteLine(Space);
                System.Console.WriteLine(
                    "The conversion from string to number overflowed.");
                Console.WriteLine(Space);
                return 0;
            }
            catch (System.FormatException)
            {
                Console.WriteLine(Space);
                System.Console.WriteLine(
                    "The string is not formatted as a number.");
                Console.WriteLine(Space);
                return 0;
            }
            catch (System.ArgumentNullException)
            {
                Console.WriteLine(Space);
                System.Console.WriteLine(
                    "The string is null.");
                Console.WriteLine(Space);
                return 0;
            }

        }

        private static decimal RevDec(decimal Input)
        {
            // This method takes a decimal as input, and if the input is a valid whole number.
            // Print Returns the reverse of the number as output.
            Decimal Divider = 10;
            Decimal Remainder = 0;
            String OutputString = "";
            Decimal OutputNumber = 0;
           

            Decimal Quotient = Input;  // Set initial quotient to entire number entered

            // While we are not at the end of the number (i.e. dividing by 10 doesn't give us a zero quotient).
            // Create a string of remainders in reverse order
            while (Quotient != 0)
            {
                // Calculate the quotient and remainder 
                Remainder = Quotient % Divider;
                Quotient = Math.Round(Quotient / Divider);
                Convert.ToString(Remainder);
                OutputString = OutputString + Remainder;
            }

            OutputNumber = ConvToDecimalWithErrorCheck(OutputString);
            if (OutputNumber != 0)
            {
                return OutputNumber;
            }
            else
            {
                return 0;
            }
        }


        static void Main(string[] args)
        {
            string InputLine = "";
            decimal OutputNumber = 0;
            
            var Space = "\n";

            //Repeat this code until the user enters "q"
            while (InputLine != "q")
            {
                // Get number from user
                Console.WriteLine("This program will reverse a whole number you enter (No decimal points).  Please enter a number to begin. (Type q to exit)");
                InputLine = Console.ReadLine();

                // If user enters "q", execute exit procedure
                if (InputLine == "q")
                {
                    Console.WriteLine(Space);
                    Console.WriteLine("You entered q");
                    Console.WriteLine(Space);
                    Console.WriteLine("Are you sure you want to exit? (Type y to confirm)"); 
                    InputLine = Console.ReadLine();        
                    if (InputLine == "y")
                    { return; }
                  
                }

                decimal InputNumber = ConvToDecimalWithErrorCheck(InputLine);
                if (InputNumber != 0)
                {
                    OutputNumber = RevDec(InputNumber);
                    Console.WriteLine(Space);
                    Console.WriteLine("Here is the number reversed:");
                    Console.WriteLine(OutputNumber);
                    Console.WriteLine(Space);
                }
               
            }
        }
    }
}