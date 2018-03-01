using XGame.Dominio.Interfaces.Arguments;
using XGame.Dominio.ValueObjects;

namespace XGame.Dominio.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {
        public Nome Nome { get; private set; }

        public Email Email { get; private set; }

        public string Senha { get; private set; }
    }
} 
