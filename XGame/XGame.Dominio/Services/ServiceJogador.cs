using prmToolkit.NotificationPattern;
using System;
using XGame.Dominio.Arguments.Jogador;
using XGame.Dominio.Entities;
using XGame.Dominio.Interfaces.Repositories;
using XGame.Dominio.Interfaces.Services;
using XGame.Dominio.Resources;
using XGame.Dominio.ValueObjects;

namespace XGame.Dominio.Services
{
    public class ServiceJogador : Notifiable, IServiceJogador
    {

        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador()
        {

        }


        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdcionarJogador(AdicionarJogadorRequest request)
        {
            Jogador jogador = new Jogador();
            jogador.Email = request.Email;
            jogador.Nome = request.Nome;
            jogador.Status = Enum.EnumSituacaoJogador.EmAndamento;
            
            Guid id = _repositoryJogador.AdcionarJogador(jogador);

            jogador.Status = Enum.EnumSituacaoJogador.Ativo;

            return new AdicionarJogadorResponse() { Id = id, Message = "Operação realizada com sucesso!" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if(request == null)
            {
                AddNotification("AutenticarJogadorRequest", Message.X0_E_OBIGATORIO);
            }

            var email = new Email("jayme");
            var jogador = new Jogador(email, "123");

            AddNotifications(jogador, email);

            if(jogador.IsInvalid())
            {
                return null;
            }

            var response = _repositoryJogador.AutenticarJogador(request);

            return response;
        }

        private bool IsEmail(string email)
        {
            return false;
        }
    }
}
