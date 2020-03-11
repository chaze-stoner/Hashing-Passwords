using System;
using System.Threading;

namespace EX_9B_Password_Hashing_and_Authentication
{
    class Program
    {
        static void Main(string[] args)
        {
            SplashScreen();

            MainMenu();

           
        }

        /************************************
         * Splash screen to display a company
         * name when the program is launched.
         ************************************/
        public static void SplashScreen()
        {
            Console.Title = "Lumber Liquidaters";

            Console.WriteLine("");
            Console.WriteLine("=============================================================================");
            Console.WriteLine("=                ,--.                     ,--.                              =");
            Console.WriteLine("=                |  |   ,--.,--.,--,--,--.|  |-.  ,---. ,--.--.             =");
            Console.WriteLine("=                |  |   |  ||  ||        || .-. '| .-. :|  .--'             =");
            Console.WriteLine("=                |  '--.'  ''  '|  |  |  || `-' |'   --.|  |                =");
            Console.WriteLine("=                `-----' `----' `--`--`--' `---'  `----'`--'                =");
            Console.WriteLine("=,--.   ,--.               ,--.   ,--.          ,--.                        =");
            Console.WriteLine("=|  |   `--' ,---. ,--.,--.`--' ,-|  | ,--,--.,-'  '-. ,---. ,--.--. ,---.  =");
            Console.WriteLine("=|  |   ,--.| .-. ||  ||  |,--.' .-. |' ,-.  |'-.  .-'| .-. ||  .--'(  .-'  =");
            Console.WriteLine("=|  '--.|  |' '-' |'  ''  '|  |' `-' |' '-'  |  |  |  ' '-' '|  |   .-'  `) =");
            Console.WriteLine("=`-----'`--' `-|__| `----' `--' `---'  `--`--'  `--'   `---' `--'   `----'  =");
            Console.WriteLine("=                                                                           =");
            Console.WriteLine("=                                                                           =");
            Console.WriteLine("=                        Press ENTER to continue                            =");
            Console.WriteLine("=============================================================================");
            Console.ReadLine();
        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine($"=============================================================================");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                      Press 1: to loggin                                   =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                      Press 2: to Create an account                        =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                      Press 3: to reset password                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                      Press 4: Exit                                        =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=           FUN FACT~Lumber Liquidators (NYSE: LL) began in 1993            =");
            Console.WriteLine($"=============================================================================");

            ConsoleKeyInfo input = Console.ReadKey();
            if (input.Key == ConsoleKey.D1)
            {
                if (UserInputs.CheckHash() == true) { LumberLiquidators(); }
                else
                {
                    Console.WriteLine("Wrong username or password.");
                    Thread.Sleep(2000);
                    MainMenu();
                }
            }
            if (input.Key == ConsoleKey.D2)
            { 
                UserInputs.AddToList(); 
                LumberLiquidators(); 
            }
            if (input.Key == ConsoleKey.D3)
            {
                UserInputs.ResetPassword();
                MainMenu();
            }
            if (input.Key == ConsoleKey.D4)
            {
                Console.Clear();
                foreach (var item in UserInputs.Users)
                {
                    Console.WriteLine($"Username: {item.Name}");
                    Console.WriteLine($"Password: {item.Password}");
                    Console.WriteLine();
                }
                Environment.Exit(1);
            }
            else MainMenu(); 
        }  

        public static void LumberLiquidators()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine($"=============================================================================");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=          Welcome to Lumber Liquidators how may we help you today?         =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=          Press 1 to go buy wood with the help of the greeter              =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=          Press 2 to leave the store if only for just a moment             =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=           FUN FACT~Lumber Liquidators (NYSE: LL) began in 1993            =");
            Console.WriteLine($"=============================================================================");

            ConsoleKeyInfo input = Console.ReadKey();
            if (input.Key == ConsoleKey.D1)
            {
                BuyingWood(); 
                MainMenu();
            }
            if (input.Key == ConsoleKey.D2)
            {
                MainMenu();
            }
            else LumberLiquidators();     
        }

        public static void BuyingWood()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine($"=============================================================================");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=      You browse through the store with the help of the nice greeter.      =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=         You find some nice wood for your next flooring adventure          =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=              You happily leave the store with your new wood.              =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=                                                                           =");
            Console.WriteLine($"=           FUN FACT~Lumber Liquidators (NYSE: LL) began in 1993            =");
            Console.WriteLine($"=============================================================================");
            Thread.Sleep(6000);
        }

       
    }
}
