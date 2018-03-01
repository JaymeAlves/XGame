using XGame.Dominio.Arguments.Plataforma;

namespace XGame.Dominio.Interfaces.Services
{
    public interface IServicePlataforma
    {
        AdicionarPlataformaResponse adicionarPlataforma(AdicionarPlataformaRequest request);
    }
}
