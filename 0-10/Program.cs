using System;

namespace _0_10
{
    class Program
    {
        static void Main(string[] args)
        {
          
             Console.WriteLine("Coloque uma nota de 0-10: ");
             int resposta =int.Parse(Console.ReadLine());

            Console.WriteLine("Nota " +resposta+ " verificada!!!");

             

             while (resposta>10)
             {
                Console.WriteLine("!!!ERRO!!! NUMERO INVALIDO   Coloque uma nota de 0-10: ");
                 resposta=int.Parse(Console.ReadLine()); 

                 if (resposta<=10)
                 {
                     Console.WriteLine("Nota " +resposta+ " verificada!!!");
                 }

                 
                 

             }

                  
                  

              while (resposta<0)
             {
                Console.WriteLine("!!!ERRO!!! NUMERO INVALIDO   Coloque uma nota de 0-10: ");
                 resposta=int.Parse(Console.ReadLine()); 

                 if (resposta<=10)
                 {
                     Console.WriteLine("Nota " +resposta+ " verificada!!!");
                 }

                 
             }
             }
        }
    }

             





          
          
              
          
          
              
          
        
    

