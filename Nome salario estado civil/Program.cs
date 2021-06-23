using System;

namespace Nome_salario_estado_civil
{
    class Program
    {
        static void Main(string[] args)
        
        
        {
            int idade;
             Console.WriteLine("Digite seu nome: ");
             string nome =Console.ReadLine();

            
            

              Console.WriteLine("Coloque sua idade ");
              idade =int.Parse(Console.ReadLine());

            Console.WriteLine("Idade " +idade+ " verificada!!!");

             

             while (idade>150)
             {
                Console.WriteLine("!!!ERRO!!! IDADE INVALIDA   Coloque uma idade de 0-150: ");
                 idade=int.Parse(Console.ReadLine()); 

                 if (idade<=150)
                 {
                     Console.WriteLine("Idade " +idade+ " verificada!!!");
                 }

                 
             }

                  
                  

              while (idade<0)
             {
                Console.WriteLine("!!!ERRO!!! IDADE INVALIDA   Coloque uma idade de 0-150: ");
                 idade=int.Parse(Console.ReadLine()); 

                 if (idade<=150)
                 {
                     Console.WriteLine("idade " +idade+ " verificada!!!");
                 }

                 
             }

             Console.WriteLine("Informe seu salario: ");
              int salario =int.Parse(Console.ReadLine());

            Console.WriteLine("Idade " +idade+ " verificada!!!");

             

             while (salario<1)
             {
                Console.WriteLine("!!!ERRO!!! SALARIO INVALIDO   Coloque uma salario maior que 0: ");
                 salario=int.Parse(Console.ReadLine()); 

        }
        

        Console.WriteLine("Qual seu estado civil 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd' (divorciado(a)) : ");
        string estado=Console.ReadLine();

        
    }
    }
    }

