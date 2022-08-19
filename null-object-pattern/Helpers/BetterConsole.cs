using System.Text;

namespace Helpers
{
    public static class BetterConsole
    {
        public static void WriteLine(string line)
            => Console.WriteLine(line);

        public static string ReadLine() 
            => Console.ReadLine() ?? string.Empty;

        public static bool ReadBool(
            string question,
            string trueValue = "y",
            string falseValue = "n",
            string unrecognisedInputMessage = "user input not recognised")
        {
            WriteLine($"{question} [{trueValue}/{falseValue}]:");

            while (true)
            {
                string userInput = ReadLine().ToLower();

                if (userInput == trueValue)
                    return true;

                if (userInput == falseValue)
                    return false;

                WriteLine(unrecognisedInputMessage);
            }
        }
    }
}