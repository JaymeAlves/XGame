using System;

namespace XGame.Dominio.Entities
{
    public class JogoPlataforma
    {
        public Guid Id { get; private set; }

        public Jogo Jogo { get; private set; }

        public Plataforma Plataforma { get; private set; }

        public DateTime DataLancamento { get; private set; }
    }
}
