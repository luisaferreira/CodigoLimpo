using CodigoLimpo.Models;
using CodigoLimpo.Repositories.Base;

namespace CodigoLimpo.Repositories
{
    public class AnimalRepository : BaseRepository<Animal>
    {
        private bool _identity;

        public AnimalRepository()
            : base("STRING DE CONEXAO") { }

        public void AddAnimal(Animal animal)
            {
            _identity=false;

            Adicionar(animal, _identity);
        }
        
            public void AtualizarAnimal(Animal animal)
        {

        }
        public void ExcluirAnimal(int idAnimal)
        {
            //if (idAnimal != 0)
                            //    ObterAnimalPorId(idAnimal);

              Excluir(idAnimal);
        }
        public void ObterAnimalById(int idAnimal)
        {

        }
        //Tem como objetivo obter animais
        public void GetAnimais()
        {

        }       
                public void AdicionarAnimal(int id, int idPessoa, string nome, string especie, bool identity)
        {
            var animal = new Animal
            {
                Id = id,
                IdPessoa = idPessoa,
                strNome = nome,
                strEspecie = especie
            };

            Adicionar(animal, identity);
        }
    }
}
