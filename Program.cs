using System;

namespace BlackjackOOP
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Console.Write("Welcome to BlackJack The Game");
            Console.WriteLine("Creator: Ana");

            //ApplicationConfiguration.Initialize();
            Application.Run(new Form1());




        }
    }
}