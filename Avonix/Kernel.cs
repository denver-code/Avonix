using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sys = Cosmos.System;

namespace Avonix
{

    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("AvoOS booted successfully!");
            E:
            string root_password = "toor";
            string root_username = "root";
            Console.Write("Username:");
            string input_username = Console.ReadLine();
            if (input_username == root_username)
            {
                Console.WriteLine("Password:");
                string input_password = null;
                while (true)
                {
                    var key = System.Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                        break;
                    input_password += key.KeyChar;
                }

                if (input_password == root_password)
                {
                    Console.WriteLine("Logged successfully!");
                    Run();
                }
                else
                {
                    Console.WriteLine("WRONG PASSWORD. TRY AGAIN!");
                    goto E;
                }
            }
            else
            {
                Console.WriteLine("WRONG USERNAME. TRY AGAIN!");
                goto E;

            }
        

    }

        protected override void Run()
        {

                Console.Write("root@avoos:=> ");
                var input = Console.ReadLine();
                if (input == "help")
                {
                    Console.WriteLine("Coming soon......");
                }
                else if (input.StartsWith("run -a "))
                {

                    string app = input.Remove(0, 7);
                    if (app == "HelloWorldApp")
                    {
                        helloworld.Launch();
                    }

                }
                else if (input.StartsWith("echo "))
            {
                Console.WriteLine(input.Remove(0, 5));
            }
                else if (input == "ping")
            {
                Console.WriteLine("Pong!");
            }
            else
                {
                    Console.WriteLine("avoh: Command not found!");
                }
        }
        public static string SystemError
        {
            get
            {
                return "Error! SystemException: Command not found. Error Code: 100";
            }
        }
        public static string IOException
        {
            get
            {
                return "Error! IOException: Directory not found";
            }
        }
        public static string IOFilestreamException
        {
            get
            {
                return "Error! IOException: File not found";
            }
        }
    }
}
