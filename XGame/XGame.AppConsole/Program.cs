using System;
using XGame.Dominio.Arguments.Jogador;
using XGame.Dominio.Services;

namespace XGame.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando....");

            var service = new ServiceJogador();
            Console.WriteLine("Criei instancia do servidor");

            AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            Console.WriteLine("Criei minha instancia do meu objeto request");
            request.Email = "jayme";    

            var response = service.AutenticarJogador(request);

            //if(service.IsValid())
            //{
            //    return response;
            //}
            
            Console.ReadKey();
        }
    }
}
