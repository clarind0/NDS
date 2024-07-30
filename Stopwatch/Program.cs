using System;
using System.Data;
using System.Runtime.Serialization;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = segundo => 10s = 10 segundos");
            Console.WriteLine("M = minuto => 1m = 1 minuto");
            Console.WriteLine("0 = sair");
            Console.WriteLine("quanto tempo deseja contar?");

           string data = Console.ReadLine().ToLower();
           char type = char.Parse(data.Substring(data.Length-1,1));
           int time = int.Parse(data.Substring(0, data.Length-1));
           int multiplier = 1;

           if(type == 'm')
           {
            multiplier = 60;
           }

           if(time == 0)
           {
            System.Environment.Exit(0);
           }

           PreStart(time * multiplier);


           Console.WriteLine(data);
           Console.WriteLine(type);
        
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2000);

            Start(time);
        }
        static void Start(int time)
        {
            // int currentTime = 0;

            // while(currentTime != time)
            // {
            //     Console.Clear();
            //     currentTime++;
            //     Console.WriteLine(currentTime);
            //     Thread.Sleep(1000);
            // }
            for(int i = 0;i < time; i++)
            {
                Console.Clear();
                Console.WriteLine(i+1);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("stopwatch finalizado");
            Thread.Sleep(3000);

            Menu();
        }
    }
}