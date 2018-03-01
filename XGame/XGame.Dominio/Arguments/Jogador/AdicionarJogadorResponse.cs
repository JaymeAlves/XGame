using System;
using XGame.Dominio.Interfaces.Arguments;

namespace XGame.Dominio.Arguments.Jogador
{
    public class AdicionarJogadorResponse : IResponse
    {
        public Guid Id { get; set; }

        public string Message { get; set; }
    }
}
