using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Bravo.anika
{
    class Program
    {
        static void Main(string[] args)

        {
            char ch;
            do
            {
                Console.Clear();
                Console.WriteLine(" ==================== Employee information ==============");

                Console.WriteLine(" Enter your choice");
                Console.WriteLine(" Press 1 to add information ");
                Console.WriteLine(" Press 2 to insert information ");
                Console.WriteLine(" Press 3 to upadate information ");
                Console.WriteLine(" Press 4 to delete information  ");
                Console.WriteLine(" Press 5 to search informataion  ");
                Console.WriteLine(" Press 6 to display information ");
                char choice;
                choice = Convert.ToChar(Console.ReadLine());
                switch (choice)
                {
                    case '1'://add 
                        do
                        {
                         Console.WriteLine("How many employees do you want to register:");
                         int num;
                         num = Convert.ToInt32(Console.ReadLine());
                         for (int i = 0; i < num; i++)
                         {
                          Console.WriteLine("Information of Employee Number:" +(i + 1));
                          AddInformation();
                         }

                        

                         DisplayInformation();
                         Console.WriteLine("Do you want to register more employees: Press 'y' for Yes or 'n' for No");
                         ch = Convert.ToChar(Console.ReadLine());
                        } while (ch == 'y');
                        break;

                    case '2'://insert 
                        do 
                        { 
                         DisplayInformation();
                         Insertinfo();
                         DisplayInformation();
                         Console.WriteLine("Do you want to Insert more elements: Press 'y' for Yes or 'n' for No");
                         ch = Convert.ToChar(Console.ReadLine());
                        } while (ch == 'y') ;
                        break;

                    case '3'://update 
                        do
                        {
                         UpdateInfo();
                         Console.WriteLine("Do you want to Insert more elements: Press 'y' for Yes or 'n' for No");
                         ch = Convert.ToChar(Console.ReadLine());
                        } while (ch == 'y');
                        break;

                    case '4'://delete
                        do 
                        { 
                         DeleteInfo();
                         Console.WriteLine("Do you want to delete more elements: Press 'y' for Yes or 'n' for No");
                         ch = Convert.ToChar(Console.ReadLine());
                        } while (ch == 'y');
                        break;

                    case '5'://search
                        do
                        { 
                         SearchInfo();
                         Console.WriteLine("Do you want to search for more elements: Press 'y' for Yes or 'n' for No");
                         ch = Convert.ToChar(Console.ReadLine());
                        } while (ch == 'y');
                        break;

                    default:
                        Console.WriteLine(" Please select from the the options 1, 2, 3, 4, 5. ");
                        break;

                    case '6'://display 
                        Console.WriteLine(" ==================== Employee information ================");
                        DisplayInformation();
                        break;
                        
                }

             Console.WriteLine("Do you want to return to main menu: Press 'y' for Yes or 'n' for No");
             ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'y');
            
            Console.ReadKey();


        }

        static List<string> EmployeeName = new List<string>();

        static void AddInformation()
        {

            string fullName;
           
            {
                
                Console.WriteLine("Enter the full name of employee:");
                fullName = Console.ReadLine(); 
                EmployeeName.Add(fullName);
            }
        }

        static void Insertinfo()
        {
            Console.Clear();
            DisplayInformation();
            Console.WriteLine("Enter the location number");
            int loc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the employees name");
            string fullname = Console.ReadLine();
            EmployeeName.Insert(loc, fullname);
        }

        static void DisplayInformation()
        {
            Console.Clear();
            Console.WriteLine("Information Stored are as:");
            for (int i = 0; i < EmployeeName.Count; i++)
            {
                Console.WriteLine(" Name stored at location number:" + (i));
                Console.WriteLine(" Fullname:" +EmployeeName[i]);
            }


        }
        static void DeleteInfo()
        {
            Console.Clear(); //clear the output screen
            Console.WriteLine("===========Delete Information===========");

            Console.WriteLine("List of Employees before Delete:");
            DisplayInformation();
            Console.WriteLine("Enter the location number to delete element:");
            int loc = Convert.ToInt32(Console.ReadLine());
            EmployeeName.RemoveAt(loc);
            Console.WriteLine("employees Name successfully deleted");
            Console.WriteLine("List of employees after Delete:");
            DisplayInformation();
        }
        static void SearchInfo()
        {
            Console.Clear();
            Console.WriteLine("Enter an Employees full name to search");
            string element = Console.ReadLine();
            if (EmployeeName.Contains(element))
            {
                Console.WriteLine("Employee name:" + EmployeeName.IndexOf(element));

            }
            else
            {
                Console.WriteLine(" Employees name does not exist! try another name");
            }
        }

        static void UpdateInfo()
        {
            Console.Clear();
            Console.WriteLine("list of names for refernce ");
            DisplayInformation();
            Console.WriteLine("enter location to update ");
            int loc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter new name to update ");
            string element = Console.ReadLine();
            EmployeeName[loc] = element;
            Console.WriteLine("information succesfully updated ");
            DisplayInformation();

        }
    }
}