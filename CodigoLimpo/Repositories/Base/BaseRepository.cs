namespace CodigoLimpo.Repositories.Base
{
    public class BaseRepository<T> where T : class
    {
        public BaseRepository(string conexaoBanco)
        {
            //Realiza a conexão com o banco
        }

        public void Adicionar(T t, bool identity)
        {

        }
        public void Atualizar(T t)
        {

        }
        public void Excluir(int id)
        {

        }
        public void ObterPorId(int id)
        {

        }
        public void Obter()
        {

        }
    }
}
