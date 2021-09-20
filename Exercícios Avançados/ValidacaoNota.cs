using System; 

class minhaClasse {

    static void Main(string[] args) { 

            //implente sua solução aqui
              double SomaNota = 0;
              int contador = 0;
              
              do  
              {
                double nota = double.Parse(Console.ReadLine());
                
                if(nota < 0 || nota > 10) {
                  Console.WriteLine("nota invalida");
                } else {
              contador++;
              SomaNota += nota;
                }
              } while (contador < 2);
              
              double media = SomaNota/2;
              
              Console.WriteLine($"media = {media.ToString("F")} ");
                
            
           
            
              
     }

 }
