using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace School
{

    public class MainClass
    {

        public static void Main(string[] args)
        {
            // -------- Varibales--------
            string adminEmail = "admin@admin.com";
            string adminPassword = "admin";

            string studEmail = "stud@stud.com";
            string studPassword = "stud123";
            // -------- Varibales--------


            // --- Welcoming sentence ---
            Console.WriteLine("Welcome to School!\nIf you are an admin please choose 1\nIf you are a student please choose 2");
            int choice = Convert.ToInt32(Console.ReadLine());
            // --- Welcoming sentence ---       


            /* NOTE: 
                    Make the menu repetitive by using while loop.. 
            */
            //bool wishToContinue = true;


            if (choice == 1)
            {
                Console.WriteLine("Hello Mrs. Admin, Please enter you email:\n ");
                string userEmail = Console.ReadLine();
                Console.WriteLine("Please enter you password: ");
                string userPassword = Console.ReadLine();


                if (userEmail == adminEmail && userPassword == adminPassword)
                {

                    Console.WriteLine("Welcome Mrs. Admin. please choose from the menu below");
                    Console.WriteLine("1) Register a student");
                    Console.WriteLine("2) Student attendence");
                    Console.WriteLine("3) Add a new course");
                    Console.WriteLine("4) Add a new equipment");
                    Console.WriteLine("5) Search for an equipment");
                    Console.WriteLine("6) Hire a new teacher");
                    Console.WriteLine("7) Fire a teacher");
                    int menuChoice = Convert.ToInt32(Console.ReadLine());

                    switch (menuChoice)
                    {

                        case 1:
                            Console.WriteLine("Its 1 option");
                            break;
                        case 2:
                            Console.WriteLine("Its 2 option");
                            break;
                        case 3:
                            Console.WriteLine("Its 3 option");
                            break;
                        case 4:
                            Console.WriteLine("Its 4 option");
                            break;
                        case 5:
                            Console.WriteLine("Its 5 option");
                            break;
                        case 6:
                            Console.WriteLine("Its 6 option");
                            break;
                        case 7:
                            Console.WriteLine("Its 7 option");
                            break;
                        default:
                            Console.WriteLine("Sorry, there is no option for your choice");
                            break;

                    }
                }
                if (userEmail != adminEmail || userPassword != adminPassword)
                {
                    Console.WriteLine("Sorry, wrong credentials, see you later");

                }


            }
            // Students menu page .. 
            else if (choice == 2)
            {
                Console.WriteLine("Hello Student, Please enter you email:\n ");
                string user1Email = Console.ReadLine();
                Console.WriteLine("Please enter you email: ");
                string user1Password = Console.ReadLine();

                if (user1Email == studEmail && user1Password == studPassword)
                {

                    Console.WriteLine("Hello Student, please choose from the menu below: ");
                    Console.WriteLine("1) Add a course");
                    Console.WriteLine("2) Show schedule");
                    Console.WriteLine("3) Show attendence");
                    Console.WriteLine("4) Take exam");
                    Console.WriteLine("5) Show grades");
                    int secondMenuChoice = Convert.ToInt32(Console.ReadLine());

                    switch (secondMenuChoice)
                    {
                        case 1:
                            Console.WriteLine("Its 1 option");
                            break;
                        case 2:
                            Console.WriteLine("Its 2 option");
                            break;
                        case 3:
                            Console.WriteLine("Its 3 option");
                            break;
                        case 4:
                            Console.WriteLine("Its 4 option");
                            break;
                        case 5:
                            Console.WriteLine("Its 5 option");
                            break;
                        default:
                            Console.WriteLine("Sorry, there is no option for your choice");
                            break;
                    }

                    //wishToContinue = false;



                }
                if (user1Email != studEmail || user1Password != studPassword)
                {
                    Console.WriteLine("Sorry, wrong credentials, see you later");

                }

            }

            //No option is available 
            else
            {
                Console.WriteLine("Sorry we cannot recognize you, please try again!");

                if (choice == 1 || choice == 2)
                {
                    //wishToContinue = false;
                }

            }



        }



    }
}



