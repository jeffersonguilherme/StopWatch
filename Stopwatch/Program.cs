﻿

using System.Net;

namespace Stropwatch{
    class Program {
        static void Main(String[] args){
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length -1));
            int multiplier = 1;

            if(type == 'm'){
                multiplier = 60;
            }if(time == 0){
                Environment.Exit(0);
            }

            PreStart(time, multiplier);

        }

        static void PreStart(int time, int multiplier){
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("GO!");
            Thread.Sleep(2500);
            Start(time, multiplier);

        }

        static void Start(int time, int multiplier){

            int currentTime = time * multiplier;//Contagem regressiva subistitui por 0

            while(currentTime != 0){//subistitui zero por time que começa a contagem 
                Console.Clear();
                currentTime--;//Muda para encremento
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}