using prmToolkit.NotificationPattern;
using System;
using XGame.Dominio.Enum;
using XGame.Dominio.ValueObjects;

namespace XGame.Dominio.Entities
{
    public class Jogador : Notifiable
    {
        public Guid Id { get; set; }

        public Nome Nome { get; set; }

        public Email Email { get; set; }

        public string senha { get; set; }

        public EnumSituacaoJogador Status { get; set; }

        public Jogador()
        {
                
        }
        
        public Jogador(Email email, string senha)
        {
            //Id = id;
            //Nome = nome;
            Email = email;
            this.senha = senha;
            //Status = status;

            //Validação
            new AddNotifications<Jogador>(this)
                .IfNotEmail(x => x.Email.Endereco, "Informe um e-mail valido")
                .IfNullOrInvalidLength(x => x.senha, 6, 23, "A senha deve ter entre 6 a 32 caracteres");

            //if (request == null)
            //{
            //    throw new Exception("AutenticarJogadorRequest é obrigatório.");
            //}

            //if (string.IsNullOrEmpty(request.Email))
            //{
            //    throw new Exception("Informe um e-mail.");
            //}

            //if (IsEmail(request.Email))
            //{
            //    throw new Exception("Informe um e-mail.");
            //}

            //if (string.IsNullOrEmpty(request.senha))
            //{
            //    throw new Exception("Informe uma senha.");
            //}

            //if (request.senha.Length < 6)
            //{
            //    throw new Exception("Digite uma senha de no mínimo 6 caracteres.");
            //}
        }
    }
}
