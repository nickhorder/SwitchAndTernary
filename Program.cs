using System;

namespace SwitchAndTernary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*SWITCH STATEMENTS
             * 
             * If it’s necessary to evaluate several conditions with their own unique output, 
             * a switch statement is the way to go. Switch statements allow for compact control 
             * flow structures by evaluating a single expression and executing code blocks 
             * based on a matched case.
             */
            Console.WriteLine("Choose a movie genre: ");
            string genre = Console.ReadLine();
            genre = genre.ToLower();
            switch (genre)
            {
                case "drama":
                    Console.WriteLine($"Citizen Kane \n");
                    break;
                case "comedy":
                    Console.WriteLine($"Duck Soup \n");
                    break;
                case "romance":
                    Console.WriteLine($"When Harry Met Sally \n");
                    break;
                case "adventure":
                    Console.WriteLine($"King Kong \n");
                    break;
                case "horror":
                    Console.WriteLine($"Psycho \n");
                    break;
                case "science fiction":
                    Console.WriteLine($"2001: A Space Odyssey \n");
                    break;
                default:
                    Console.WriteLine($"That genre is unavailable right now \n");
                    break;
            }
            //TERNERY OPERATORS
            /*
             * The ternary operator allows for a compact syntax in the case of binary decisions. 
             * Like an if...else statement, it evaluates a single condition and executes one expression 
             * if the condition is true and the second expression otherwise.
             */
            // Ask the user to confirm how long the French Beans are 
            Console.WriteLine($"It's time to decide whether to pick your French Beans. \n" +
                              "In centimetres, how long are they at the moment?");
            string beans = Console.ReadLine();
            // Attempt conversion from string input to integer
            if (Int32.TryParse(beans, out int BeanLength))
            {
                string shouldipick = (BeanLength >= 6) ? $"Ooh, " + BeanLength + "cm is a good size! Pick the beans!"
                                                       : $"They're not long enough. Wait a little longer";
                Console.WriteLine(shouldipick);
            }
            else
            {
                Console.WriteLine($"'{beans}' is not a number?! Try again.");
            }
        }
    }
}
