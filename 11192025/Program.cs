namespace _11192025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
            string name = "";
            int height = 0;
            string gender = "";

             
                while (true)
            {
                Console.Write("please, inpute you full name (ENG) :");
                name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                {
                    break;
                }
                Console.WriteLine("Name cannot be empty please try again.");
            }
            Console.WriteLine("Hello, Welcome " + name);
            while (true)
            {
                Console.Write("Please input your gender (m/f): ");
                gender = Console.ReadLine();

                if (gender == "m" || gender == "f")
                    break;
                Console.WriteLine("Invalid gender code please enter 'm' or 'f'");
            }
            while (true)
            {
                Console.Write("Please fill you height(cm) : ");
                string inputHeight = Console.ReadLine();

                if (int.TryParse(inputHeight, out height) && height > 0)
                    break;
                Console.WriteLine("Invalid height! Must be a positive number.");
            }

            double weight = 0;
            if (gender == "m")
            {
                weight = height - 100;
            } else if (gender == "f")
            { weight = height - 110;
            } else
            {
                Console.WriteLine("Invalid code");
            }

        Console.WriteLine("You ideal weight is " + weight.ToString());
        Console.WriteLine();

        Console.Write("Press Q to quit or Enter to continue: ");
        string exitCheck = Console.ReadLine();
           if (exitCheck.ToLower() == "q")
              {
               Console.WriteLine("Program ended. Goodbye");
                    break;
               }
            }
      }
    }
}
