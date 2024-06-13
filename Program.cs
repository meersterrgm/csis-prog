using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDoBMW
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Welcome to the BMW Car Customization App");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            string sDetails = " ";
            PersonalDetails(ref sDetails);
            string sDisplay = " ";
            DisplayScreen(ref sDisplay);


            int iType = 0;
            string sQuery = " ";

            
            
                TypeSelection(ref iType);

                switch (iType)
                {
                    case 1: //Truck
                        BuildString("Truck", ref sQuery);
                        DisplayBuild(ref sQuery,ref sDetails);
                        break;
                    case 2: //Sedan
                        BuildString("Sedan", ref sQuery);
                        DisplayBuild(ref sQuery,ref sDetails);

                        break;
                    case 3: //SUV
                        BuildString("SUV", ref sQuery);
                        DisplayBuild(ref sQuery,ref sDetails);
                        break;

                    default: //default
                        Console.WriteLine("Invalid model, please choose from the menu");
                        break;
                }

            //Console.WriteLine("App closed, thank you for using. Press any key to exit");
            //Console.ReadKey();
        }
        public static void BuildString(string iType, ref string sQuery)
        {
            string sColour = " ";
            Console.Write("What colour would you like: ");
            ColourSelection(ref sColour);
            string sLeather = " ";
            AddLeatherSeats(ref sLeather);
           sQuery = "You have selected a " + sColour + " BMW " + iType + sLeather;
        }

        public static string ColourSelection(ref string sColour)
        {

            return sColour = Console.ReadLine();
        }

        public static void DisplayScreen(ref string sDisplay)
        {
            Console.WriteLine("\nPlease choose the type of BWM you want to order \n1. Truck \n2. Sedan \n3. SUV \n-1. To cancel the program \n");
       
        }

        public static void DisplayBuild(ref string sQuery, ref string sDetails)
        {
            Console.Write(sDetails);
            Console.Write(". " + sQuery);

            Console.WriteLine("\n---------------------------THANK YOU-----------------------------");
            Console.WriteLine("We will contact you soon to discuss the price and payment options.\nPress any key to continue....");
            Console.ReadKey();
        }

        public static void AddLeatherSeats(ref string sQuery)
        {
            
            Console.Write("Would you like leather seats in your BMW? (Y/N) ");
            string sSelection  = Console.ReadLine();
            if (sSelection == "Y")
            {
                sQuery = " with leather seats";
            }
            else
                sQuery = " without leather seats";
        }

        public static bool TypeSelection(ref int _iType)
        {
            return int.TryParse(Console.ReadLine(), out _iType);
        }

        public static void PersonalDetails(ref string sDetails)
        {
            Console.WriteLine("Please provide us with your personal details.");
            Console.Write("Name: ");
            string sName = Console.ReadLine();
            Console.Write("Surname: ");
            string sSurname = Console.ReadLine();
            Console.Write("HomeTown: ");
            string sHomeTown = Console.ReadLine();

            sDetails = "\nThank you " + sName + " " + sSurname + " from "+ sHomeTown;
        }
    }

}
