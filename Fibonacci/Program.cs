using System;

namespace Fibonacci
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {     
             string nomeUsuario; 
             string senhaUsuario;                 
            do
            {
                
            
            Console.WriteLine("Informe seu nome de usuario: ");
            nomeUsuario = (Console.ReadLine());
            Console.WriteLine("Informe sua senha de usuario: ");
            senhaUsuario = (Console.ReadLine());

            if (nomeUsuario == senhaUsuario)
            {
                Console.WriteLine("ERRO SENHA NÃO POSDE SER IGUAL O NOME DE USUARIO!!!");

            }


            else
            {
                Console.WriteLine("Tudo certo!");
            }

            } while (nomeUsuario == senhaUsuario);










        }
    }
}

