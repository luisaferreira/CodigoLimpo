using CodigoLimpo.Models;
using CodigoLimpo.Repositories.Base;

namespace CodigoLimpo.Repositories
{
    public class PessoaRepository : BaseRepository<Pessoa>
    {
        public PessoaRepository(string conexaoBanco)
            : base (conexaoBanco) { }

        public void AdicionarPessoa(Pessoa pessoa)
        {
            var identity = false;

            Adicionar(pessoa, identity);
        }
        public void AdicionarPessoa(Pessoa pessoa, bool identity)
        {
            //Adicionar Pessoa
        }
        public void AtualizarPessoa(Pessoa pessoa)
        {

        }
        //ALERTA: Ao se excluir a pessoa todos os animais dependentes dela também serão excluídos
        public void ExcluirPessoa(int idPessoa)
        {

        }
        public void ObterPessoaPorId(int idPessoa)
        {

        }
        public void ObterPessoas()
        {

        }
    }
}
