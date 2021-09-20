using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
               
            int X = int.Parse(vet[0]);
            int Y = int.Parse(vet[1]);
            int contador = 0;
            //complete o código com sua solução


            while (contador != Y) 
            {
            
            
                for (int i = 0; i < X; i++)
                {
                
                        contador++;
                        Console.Write(contador + " ");
                 
                 if (contador == Y)
                          {
                            break;
                          }  
                }
              Console.WriteLine("");
                      
            }
              
                 
                 
           
            
       }
           
           
      
    }