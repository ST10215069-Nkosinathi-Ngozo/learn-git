using System.Xml.Linq;

namespace PROG6221_POE_PART1_ST10215069_NKOSINATHI_NGOZO
{
    internal class Program
    {
        static string[] ingridientName;
        static double[] ingridientQuantity;
        static string[] ingridientUnitOfMeasurement;
        static string[] ingridientSteps;
        static string name, unitOfMeasurement, steps,quantity;
        
        static void Main(string[] args)
        {
            getIngridients();
            getSteps();

        }
        public static void getIngridients()
        {
            
            Console.Write("Enter number of ingridients:");

            string numOfIngr = Console.ReadLine();
            

            int numberOfIngridients = int.Parse(numOfIngr);



            ingridientName = new string[numberOfIngridients];
            ingridientQuantity = new double[numberOfIngridients];
            ingridientUnitOfMeasurement = new string[numberOfIngridients];

            for (int i = 0; i < numberOfIngridients; i++)
            {
                int step = i + 1;


                Console.Write($"Enter ingridients {step}'s Name:\n");

                Console.Write(">>>>>>  ");

                name = Console.ReadLine();

                ingridientName[i] = name;


                Console.WriteLine($"Enter ingridients {step}'s quantity:\n");


                
                Console.Write(">>>>>>  ");


                quantity = Console.ReadLine();
                Console.WriteLine(quantity);
                ingridientQuantity[i] = Convert.ToDouble(quantity);



                
                Console.Write($"Enter ingriedient {step}'s unit   ");
                
                Console.Write("\n>>>>>>  ");

                unitOfMeasurement = Console.ReadLine();
                ingridientUnitOfMeasurement[i] = unitOfMeasurement;

                Console.WriteLine("\n");
            }
        }

        public static void getSteps()
        {
            
            Console.Write("Enter number of steps:");
            
            Console.Write(">>>>>>  ");
            //Console.WriteLine(border);

            string num = Console.ReadLine();
            

            int numberOfSteps = Convert.ToInt32(num);

            ingridientSteps = new string[numberOfSteps];



            for (int i = 0; i < numberOfSteps; i++)
            {
                int step = i + 1;
                Console.Write("Enter step {0}'s Description", step);
                
                Console.Write(">>>>>  ");

                steps = Console.ReadLine();
                ingridientSteps[i] = steps;
            }
        }

    }
}