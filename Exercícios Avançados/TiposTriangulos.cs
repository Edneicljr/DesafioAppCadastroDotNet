using System; 

class Desafio {

        public static void Main()
        {
            string[] s = Console.ReadLine().Split(' ');
            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);
            double operador = 0;
            
            
            
            
            if (a <= b) 
            { 
              operador = a; a = b; b = operador; 
            }
            if (a <= c) 
            { 
              operador = a; a = c; c = operador; 
            }
            if (b <= c)
            { 
              operador = b; b = c; c = operador; 
            }
            
            double a2 = (a * a);
            double b2 = (b * b);
            double c2 = (c * c);
            
              //continue a solucao
            if ( a >= (b+c)            )
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if ( a2 == (b2 + c2)  )
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (     a2 > (b2 + c2)          )
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (    a2 < (b2 + c2)    )
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
           if (  a == b && a == c         )
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }    
           else if ( a==b || b == c           )
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
            Console.ReadLine();
        }
}