using CodigoLimpo.Repositories.Base;
using CodigoLimpo.Solução.Models;

namespace CodigoLimpo.Solução.Repositories
{
    public class GatoRepository : BaseRepository<Gato>
    {
        public GatoRepository(string conexaoBanco)
            : base(conexaoBanco) { }

        public void AdicionarGato(Gato Gato)
        {
            var identity = false;

            Adicionar(Gato, identity);
        }
        public void AdicionarGato(Gato Gato, bool identity)
        {
            //Adicionar Gato
        }
        public void AtualizarGato(Gato Gato)
        {

        }
        public void ExcluirGato(int idGato)
        {

        }
        public void ObterGatoPorId(int idGato)
        {

        }
        public void ObterGatos()
        {

        }
    }
}
