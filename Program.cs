namespace InformationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("  This is a Personal Information System");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("");

            // Name input
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            // Age input validation
            int age;
            while (true)
            {
                Console.WriteLine("Enter your age: ");
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    if (age < 0)
                    {
                        Console.WriteLine("Age cannot be less than 0. Please enter a valid number.");
                        continue;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            // Height input validation
            int height;
            while(true)
            {
                Console.WriteLine("Enter your Height(m): ");
                if (int.TryParse(Console.ReadLine(), out height))
                {
                    if (height < 0)
                    {
                        Console.WriteLine("Height cannot be less than 0. Please enter a valid number.");
                        continue;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            

            // Displaying and processing the Information conditionals
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine("  Your Information");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Name:    " + name);
            Console.WriteLine(" Age:     " + age);
            Console.WriteLine(" Height:  " + height);
            Console.WriteLine("\n");

            // Age conditionals
            Console.Write("Age Check:  ");
            double doubleAge = Convert.ToDouble(age); // Convert age to double for drinking age validation
            double LEGAL_DRINKING_AGE = 21;

            // Age validation
            if (doubleAge < 18)
            {
                Console.Write("[ You are still a minor.  ]\n\n");
            }
            else if (doubleAge >= 18 && doubleAge <= 60)
            {
                Console.Write("[ Welcome to the adult section " + name + "! ]\n\n");

                // Drinking age validation
                Console.Write("Drinking Age Validation:  ");
                if (doubleAge >= LEGAL_DRINKING_AGE)
                {
                    Console.Write("[ You are legally allowed to drink. ]\n\n");
                }
                else
                {
                    Console.Write("[ Sorry, you are still underaged for alcoholic drinks. ]\n\n");
                }
            }
            else
            {
                Console.Write("[ You are a senior citizen. ]\n");
            }

            
            Console.WriteLine("\n");
            string personalInfo = $"Personal Details Presentation: {name}, {age} years old, {height} meters tall.\n";
            Console.WriteLine(personalInfo);

        }
    }
}
