using System;
using XGame.Dominio.Arguments.Jogador;
using XGame.Dominio.Interfaces.Repositories;
using XGame.Dominio.Interfaces.Services;

namespace XGame.Dominio.Services
{
    public class ServiceJogador : IServiceJogador
    {

        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdcionarJogador(AdicionarJogadorRequest request)
        {
            Guid id = _repositoryJogador.AdcionarJogador(request);

            return new AdicionarJogadorResponse() { Id = id, Message = "Operação realizada com sucesso!" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            //Validação
            if(request == null)
            {
                throw new Exception("AutenticarJogadorRequest é obrigatório.");
            }

            if (string.IsNullOrEmpty(request.Email))
            {
                throw new Exception("Informe um e-mail.");
            }

            if (IsEmail(request.Email))
            {
                throw new Exception("Informe um e-mail.");
            }

            if (string.IsNullOrEmpty(request.senha))
            {
                throw new Exception("Informe uma senha.");
            }

            if (request.senha.Length < 6)
            {
                throw new Exception("Digite uma senha de no mínimo 6 caracteres.");
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
