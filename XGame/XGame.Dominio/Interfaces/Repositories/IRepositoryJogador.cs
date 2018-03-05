using System;
using XGame.Dominio.Arguments.Jogador;
using XGame.Dominio.Entities;

namespace XGame.Dominio.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);

        Guid AdcionarJogador(Jogador jogador);
    }
}
