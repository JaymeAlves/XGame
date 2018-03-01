using System;
using XGame.Dominio.Enum;
using XGame.Dominio.ValueObjects;

namespace XGame.Dominio.Entities
{
    public class Jogador
    {
        public Guid Id { get;  set; }

        public Nome Nome { get; set; }

        public Email Email { get;  set; }

        public string senha { get;  set; }

        public EnumSituacaoJogador Status { get; set; }

    }
}
