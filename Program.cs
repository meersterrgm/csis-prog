/* 
RATHEBE MOFOKENG
2017015898
PRACTICAL 8
02 MAY 2024
*/

using System;

namespace BMWBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            int iOption = 0;
            do
            {
                Console.Clear();

                string sQuery = "";
                DisplayTypes();

                Console.Write("Select a starting type: ");

                if (CheckValidInput(out iOption) && iOption != -1)
                {
                    switch (iOption)
                    {
                        case 1:
                            BuildCustomOrder("Sedan", ref sQuery);
                            DisplayBuild(ref sQuery);
                            break;
                        case 2:
                            BuildCustomOrder("SUV", ref sQuery);
                            DisplayBuild(ref sQuery);
                            break;
                        case 3:
                            BuildCustomOrder("Truck", ref sQuery);
                            DisplayBuild(ref sQuery);
                            break;
                        default:
                            Console.WriteLine("\nThat is not a valid option,press any key to try again...");
                            Console.ReadKey();
                            break;
                    }

                }

            } while (iOption != -1);
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }//Main End

        //1. CheckValidInput method

        public static bool CheckValidInput(out int _option)
        {
            //if the iput is an integer bool is true
            return int.TryParse(Console.ReadLine(), out _option);
        }


        //2. GetColour method
        public static string GetColour()
        {
            Console.Write("What colour should your BMW be? ");
            string _colour = Console.ReadLine();

            return _colour;
        }


        //3. AddLeatherSeats method
        public static void AddLeatherSeats(ref string _sQuery)
        {
            Console.Write("Would you like to add leather seats to your BMW? (Y/N): ");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                _sQuery = " with added leather seats.";
            }
            else
            {
                _sQuery = " without added leather seats.";
            }
        }//AddLeatherSeats end


        //4. BuildCustomOrder
        public static void BuildCustomOrder(string type,ref string _sQuery)
        {
            //
            string sColour = GetColour();

            //declearing a string Leather variable 
            string sLeather = ""; 
            //calling the AddLeatherSeats method to the variable
            AddLeatherSeats(ref sLeather);

            //built string with colour, customer option & leather seat choice
            _sQuery = "You have selected a " + sColour + " BMW " + type + " " + sLeather;

        }


        //5. DisplayBuild
        public static void DisplayBuild(ref string _sQuery)
        {
            //calling the built string
            Console.WriteLine(_sQuery);

;           Console.WriteLine("\n---------------------------THANK YOU-----------------------------");
            Console.WriteLine("We will contact you soon to discuss the price and payment options.\nPress any key to continue....");
            Console.ReadKey();
        }//DisplayBuild end

        //DisplayTypes
        public static void DisplayTypes()
        {
            Console.WriteLine("----------------------Welcome to the BMW Dealership!----------------------");
            Console.WriteLine("Please provide us with some details regarding the BMW you're interested in.\n");
            Console.WriteLine("----------------------------------TYPES-----------------------------------");
            Console.WriteLine("1) Sedan");
            Console.WriteLine("2) SUV");
            Console.WriteLine("3) Truck");
            Console.WriteLine("-1) Cancel build and close system\n");
        }//DisplayTypes end

    }//Class end

}//Namespace end