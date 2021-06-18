using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Avonix
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("AvoOS booted successfully!");
        }

        protected override void Run()
        {
            Console.Write("root@avoos:=> ");
            var input = Console.ReadLine();
            if (input == "help")
            {
                Console.WriteLine("Coming soon......");
            }
            else { 
            Console.WriteLine("avoh: Command not found!");
            }
            //Console.WriteLine(input);
        }
    }
}
