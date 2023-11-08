using System;


namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ASSIGNMENT 3 PS 1

            //Using TryParse for converting a string to an integer

           string numberString = "123";
            int number;

            if (int.TryParse(numberString, out number))
            {
                Console.WriteLine("Conversion successful. Integer value: " + number);

            }
            else
            {
                Console.WriteLine("Conversion failed. Invalid input for Integer.");
            }

            //// Using Convert to convert a string to a double
            ///
            //string doubleString = "3.14";
            //try
            //{
            //    double convertedDouble = Convert.ToDouble(doubleString);
            //    Console.WriteLine("Conversion successful. Double value: " + convertedDouble);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Conversion failed. Invalid input for Double.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Conversion failed. Input is too large for Double.");
            //}

            // Using Parse to convert a string to a decimal
            //string decimalString;
            //Console.WriteLine("Enter a  value");
            //decimalString=Console.ReadLine();
            //try
            //{
            //    decimal convertedDecimal = decimal.Parse(decimalString);
            //    Console.WriteLine("Conversion successful. Decimal value: " + convertedDecimal);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Conversion failed. Invalid input for Decimal.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Conversion failed. Input is too large for Decimal.");



            //}

            Console.ReadKey();
        }
    }
}
