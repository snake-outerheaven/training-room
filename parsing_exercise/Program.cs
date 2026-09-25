internal class ParsingExercise
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Hello! Please write a number: ");
            string? str = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("Input cannot be empty. Please enter a valid number.");
                str = Console.ReadLine();
            }
            try
            {
                var fa = int.Parse(str ?? "0");

                if (fa > 0)
                {
                    Console.WriteLine("Positive number: " + fa);
                }
                else if (fa < 0)
                {
                    Console.WriteLine("Negative number: " + fa);
                }
                else
                {
                    Console.WriteLine("Zero: " + fa);
                }
            }



            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }
        }
    }
}
