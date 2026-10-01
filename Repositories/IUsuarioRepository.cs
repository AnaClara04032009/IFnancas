using IFnancas.Models;

namespace IFnancas.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario? ObterPorEmail(string email);
        void Adicionar(Usuario usuario);
        void SalvarAlteracoes();
    }
}