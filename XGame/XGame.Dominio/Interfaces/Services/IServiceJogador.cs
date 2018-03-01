using XGame.Dominio.Arguments.Jogador;

namespace XGame.Dominio.Interfaces.Services
{
    public interface IServiceJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);

        AdicionarJogadorResponse AdcionarJogador(AdicionarJogadorRequest request);
    }
}
