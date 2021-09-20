using System;

    class MinhaClasse {

        static void Main(string[] args) {
            
            var timeInSeconds = int.Parse(Console.ReadLine());

       //continue a solucao
            var hours = (timeInSeconds/3600);
            timeInSeconds = (timeInSeconds - hours*3600);
            var minutes =  (timeInSeconds/60);
            var seconds =  (timeInSeconds - minutes*60);

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
