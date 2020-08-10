using System;
namespace Lab11
{
    public static class Continue
    {
        private static string UserInput { get; set; }

        public static bool DetermineStatus()
        {
            Console.Write("\nContinue? (y/n): ");
            UserInput = Console.ReadLine();

            while (true)
            {
                if (UserInput == "y")
                {
                    Console.WriteLine();
                    return true;
                }
                else if (UserInput == "n")
                {
                    Console.WriteLine("Program ending. Goodbye.");
                    return false;
                }
                else
                {
                    Console.Write("\nInvalid entry. Please enter (y) to continue the program or (n) to cancel: ");
                    UserInput = Console.ReadLine();
                }
            }
        }
    }
}
