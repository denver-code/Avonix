using System;
using System.Collections.Generic;
using System.Text;

namespace Avonix
{
    public static class helloworld
    {
        public static string AppName = "HelloWorldApp";


        public static string AppDescription = "A Hello World test app.";
        public static bool IsStable = true; //Change this to false when in Alpha or Beta 

        public static void Launch()
        {

            MainLoop();

        }

        private static void MainLoop()
        {

            Console.WriteLine("Hello World!");
            Console.ReadKey();
            Console.Write("Press any key to continue");
            Console.ReadKey();
            Close();

        }

        private static void Close()
        {

            Console.Clear();

        }
    }
}
