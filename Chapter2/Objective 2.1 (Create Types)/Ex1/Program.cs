using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
           "All possible combinations of values without FlagsAttribute:");
            for (int val = 0; val <= 16; val++)
                Console.WriteLine("{0,3} - {1:G}", val, (SingleHue)val);

            // Display all combinations of values, and invalid values.
            Console.WriteLine(
                 "\nAll possible combinations of values with FlagsAttribute:");
            for (int val = 0; val <= 16; val++)
                Console.WriteLine("{0,3} - {1:G}", val, (MultiHue)val);
        }
    }

    enum SingleHue : short
    {
        None = 0,
        Black = 1,
        Red = 2,
        Green = 4,
        Blue = 8
    };

    [FlagsAttribute]
    enum MultiHue : short
    {
        None = 0,
        Black = 1,
        Red = 2,
        Green = 4,
        Blue = 8
    };
}
