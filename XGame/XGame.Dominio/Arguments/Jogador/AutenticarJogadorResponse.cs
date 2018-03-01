using XGame.Dominio.ValueObjects;

namespace XGame.Dominio.Arguments.Jogador
{
    public class AutenticarJogadorResponse
    {
        public string PrimeiroNome{ get; private set; }

        public string Email { get; private set; }
    }
}
