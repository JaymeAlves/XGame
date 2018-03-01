using System;
using XGame.Dominio.Arguments.Jogador;

namespace XGame.Dominio.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);

        Guid AdcionarJogador(AdicionarJogadorRequest request);
    }
}
