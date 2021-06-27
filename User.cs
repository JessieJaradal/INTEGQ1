using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLogic
{
    [Serializable]
    public class User
    {

        public void log()
        {

            string AdminID, AdminPassword;
            String userId = "Admin";
            string password = "Password";

            Console.WriteLine("Welcome Adminstrator to Employee Training System!");
            Console.WriteLine("Please Enter your username: ");
            AdminID = Console.ReadLine();
            Console.WriteLine("Please Enter your password: ");
            AdminPassword = Console.ReadLine();

            if (userId == AdminID && password == AdminPassword)
            {
                Menu();
     
            }
            else
            {

                Console.WriteLine("Invalid Username or Password! <Press any key to exit the system>" );
                Console.ReadKey();
               
            }        
          
        }

        public void Menu() 
        {

            ViewEmployee employeeInfo = new ViewEmployee();
            ViewSchedule Schedule = new ViewSchedule();
            Certificates certificate = new Certificates();

            Console.WriteLine("=== Welcome to the Menu ====");
            Console.WriteLine("======================================");
            Console.WriteLine("Press 1 to view the Employee;s Info");
            Console.WriteLine("Press 2 to view the Schedule");
            Console.WriteLine("Press 3 to view the Employee's Certificate");
            Console.WriteLine("Press 4 to Exit the System");
            Console.WriteLine("Press any key to exit the system");
            int UserOption = Convert.ToInt32(Console.ReadLine());


            if (UserOption.Equals(1))
            {
                employeeInfo.ViewEmploye();
                Console.WriteLine("Press any key to Access Menu Again:");
                Console.ReadKey();
                Console.Clear();
              Menu();
            }
            else if (UserOption.Equals(2))
            {
                Schedule.Schedule();
                Console.WriteLine("Press any key to Access Menu Again:");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }

            else if (UserOption.Equals(3))
            {
                certificate.Certifactes();
                Console.WriteLine("Press any key to Access Menu Again:");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }

            else if (UserOption.Equals(4))
            {
                Console.WriteLine("Alert! System shutdown!");
                Console.ReadKey();
            }

          
        }

    }
}
