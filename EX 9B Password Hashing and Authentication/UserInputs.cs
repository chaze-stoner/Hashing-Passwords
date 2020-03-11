using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;

namespace EX_9B_Password_Hashing_and_Authentication
{
    class UserInputs
    {
        public string Name { get; private set; }
        public string Password { get; private set; }


        /*****************************
         * Constructor used to store
         * a name and password. 
         *****************************/
        private UserInputs()
        {
            Name = "Dirty Dan";
            Password = "1234567890";
        }

        /**************************************
         * List used to store all the username
         * and password combinations. 
         **************************************/

        public static List<UserInputs> Users = new List<UserInputs>();

        /**************************************
         * Used to Get the Users Input through 
         * ConsoleKeyInfo, detecting what keys 
         * get pressed and outputing a string.
        ***************************************/
        public static string Input()
        {
            string input = null;
            do
            {
                ConsoleKeyInfo cki = Console.ReadKey(true);

                if (cki.Key != ConsoleKey.Backspace && cki.Key != ConsoleKey.Enter)
                {
                    input += cki.KeyChar;
                    Console.Write($"{cki.KeyChar}");
                }
                else
                {
                    if (cki.Key == ConsoleKey.Backspace && input.Length > 0)
                    {
                        input = input.Substring(0, (input.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (cki.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }

            } while (true);

            if (input == null || input == "") 
            {
                Console.WriteLine("This is not a valid entry");
                
                input = Input();
            }

            return input;
        }

        /*******************************
         * Usesd to Assign the Username
         * property to the UserInputs
         * object. 
         *******************************/
        static string UserName()
        {
            return Input();
        }

        /*******************************
         * Usesd to Assign the Password
         * property to the UserInputs
         * object. 
         *******************************/
        static string Pass()
        {
            return Hashing.PasswordHash(Input());
        }


        /*******************************
         * Creates the UserInputs object
         * with the specified properties
         * and returns a UserInputs object
         *******************************/
        static UserInputs CreateUser()
        {
            UserInputs userobject = new UserInputs();

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine($"=============================================================================");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                              Input                                        =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                A                                          =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                             Username                                      =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=           FUN FACT~Lumber Liquidators (NYSE: LL) began in 1993            =");
            Console.WriteLine($"=============================================================================");
            
            userobject.Name = UserName();

            if (Users.Count > 0)
            {
                for (int i = 0; i < Users.Count; i++)
                {
                    if (Users[i].Name == userobject.Name)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sorry this name is already taken");
                        Thread.Sleep(2000);
                        Program.MainMenu();
                    }
                }
            }

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine($"=============================================================================");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                              Input                                        =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                A                                          =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                             Password                                      =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=           FUN FACT~Lumber Liquidators (NYSE: LL) began in 1993            =");
            Console.WriteLine($"=============================================================================");

            userobject.Password = Pass();

            return userobject;
        }


        /*******************************
         * Adds the returned UserInputs 
         * object into the list to be stored
         * for use later in the program.
         *******************************/
        public static void AddToList()
        {
            Users.Add(CreateUser());
        }


        /*********************************
         * Used to check the username and
         * password for a Userinput object
         * saved in the UserInput List.
         *********************************/
        public static bool CheckHash()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine($"=============================================================================");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                              Input                                        =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                A                                          =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                             Username                                      =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=           FUN FACT~Lumber Liquidators (NYSE: LL) began in 1993            =");
            Console.WriteLine($"=============================================================================");
            string username = Input();

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine($"=============================================================================");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                              Input                                        =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                A                                          =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                             Password                                      =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=           FUN FACT~Lumber Liquidators (NYSE: LL) began in 1993            =");
            Console.WriteLine($"=============================================================================");
            string password = Input();

            for (int i = 0; i < Users.Count; i++)
            {
                if (UserInputs.Users[i].Name == username && Users[i].Password == Hashing.PasswordHash(password))
                {
                    return true;
                }  
            }
            return false; 

        }

        /********************************
         * Private method used to change
         * the users password. 
         ********************************/
        public static void ResetPassword()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine($"=============================================================================");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                              Input                                        =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                A                                          =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                             Username                                      =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=           FUN FACT~Lumber Liquidators (NYSE: LL) began in 1993            =");
            Console.WriteLine($"=============================================================================");
            string username = Input();

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine($"=============================================================================");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                              Input                                        =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                A                                          =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                             Password                                      =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=           FUN FACT~Lumber Liquidators (NYSE: LL) began in 1993            =");
            Console.WriteLine($"=============================================================================");
            string password = Input();

            for (int i = 0; i < Users.Count; i++)
            {
                if (UserInputs.Users[i].Name == username && Users[i].Password == Hashing.PasswordHash(password))
                {
                    Console.WriteLine();
                    Console.WriteLine($"{Users[i].Name} please change your password");
                    Console.WriteLine();
                    Users[i].Password = Pass(); 
                }
            }
        }
    }
}
