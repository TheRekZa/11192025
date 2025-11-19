namespace _11192025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int height = 0;
            string gender = "";
            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            Console.Write("please, inpute you full name (ENG) :");
            name = Console.ReadLine();

            Console.WriteLine("Hello, Welcome " + name);
            Console.Write("Please input your gender (M/F): ");
            gender = Console.ReadLine().ToUpper();
            Console.Write("Please fill you height(cm) : ");
            height = Convert.ToInt16(Console.ReadLine());
            double weight = 0;
            if (gender == "M")
            {
                weight = height - 100;
            } else if(gender == "F")
                    { weight = height - 110;
            }else
            {
                Console.WriteLine("Invalid code");
            }

                Console.WriteLine("You ideal weight is " + weight.ToString());
            Console.WriteLine();
            Console.WriteLine("Please any key to end program");
            Console.ReadKey();
        }
    }
}
