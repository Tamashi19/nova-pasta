using System;

namespace nome_d_senha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome de usuario: ");
            string login =Console.ReadLine();
            Console.WriteLine("Coloque sua senha: ");
            string senha =Console.ReadLine();

             

             while (login==senha)
             {

                 Console.WriteLine("ERRO seu nome de usuario não pode ser igual a sehnha, tente novamente ");
                 Console.WriteLine("Digite seu nome de usuario: ");
                  login =Console.ReadLine();
                 Console.WriteLine("Coloque sua senha: ");
                  senha =Console.ReadLine();
             }

             
                 Console.WriteLine("Login feito com sucesso!!! ");
             
        }
    }
}
