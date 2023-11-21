using CodigoLimpo.Repositories;

namespace CodigoLimpo.Services
{
    public class AnimalService
    {
        private readonly AnimalRepository animalrepository;

        public AnimalService()
        {
            animalrepository = new AnimalRepository();
        }

        public void AdicionarAnimal(int id, int idPessoa, string nome, string especie)
        {
            if (especie == "Gato")
            {
                //...
            }

            if (especie == "Cachorro")
            {
                //...
            }
            if (especie == "Papagaio")
            {
                //...
            }
        }
    }
}
