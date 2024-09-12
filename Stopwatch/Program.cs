﻿

namespace Stropwatch{
    class Program {
        static void Main(String[] args){
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("S = Segundo");
            Console.WriteLine("M = Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");
        }

        static void Start(int time){

            int currentTime = 0;

            while(currentTime != time){
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
        }
    }
}