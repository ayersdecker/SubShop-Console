using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SubShop
{
    class Display
    {
        public static void Login()
        {
            
            while (true) 
            {
                var rule = new Rule("[red]SubShop Console - Login[/]");
                rule.Style = new Style(Color.Red);
                AnsiConsole.Write(rule);
                var name = AnsiConsole.Ask<string>("What's your [green3]name[/]?");
                var password = AnsiConsole.Ask<string>("What's your [green3]password[/]?");
                if(name == "Decker" &&  password == "1234") { break; }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                AnsiConsole.WriteLine("The Information Entered is Incorrect!");
                Console.ResetColor();
                AnsiConsole.WriteLine();
                Thread.Sleep(2000);
                Console.Clear();
            }
            Console.Clear();
        } 
        public static void Loading()
        {
            var rule = new Rule("[red]SubShop Console - Setup[/]");
            rule.Style = new Style(Color.Red);
            AnsiConsole.Write(rule);
            AnsiConsole.Progress()
            .Columns(new ProgressColumn[]
            {
                    new TaskDescriptionColumn(),    // Task description
                    new ProgressBarColumn(),        // Progress bar
                    new PercentageColumn(),         // Percentage
                    new RemainingTimeColumn(),      // Remaining time 
            })
            .Start(ctx =>
            {
                // Define tasks
                var task1 = ctx.AddTask("[yellow3]Setting Up Tables[/]");
                var task2 = ctx.AddTask("[green3]Slicing Veggies[/]");
                var task3 = ctx.AddTask("[lightpink4]Heating Ovens[/]");
                var task4 = ctx.AddTask("[slateblue1]Flipping Open Sign[/]");

                while (!ctx.IsFinished)
                {
                    Thread.Sleep(20);
                    task1.Increment(0.6);
                    task2.Increment(0.5);
                    task3.Increment(0.4);
                    task4.Increment(0.35);
                }
            });
            Console.Clear();
        }
        public static void Home()
        {

        }
    }
}
