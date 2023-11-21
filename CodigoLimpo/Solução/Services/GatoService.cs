using CodigoLimpo.Solução.Models;
using CodigoLimpo.Solução.Repositories;
using Microsoft.Extensions.Configuration;

namespace CodigoLimpo.Solução.Services
{
    public class GatoService
    {
        private readonly GatoRepository _GatoRepository;

        public GatoService(IConfiguration configuration)
        {
            _GatoRepository = new GatoRepository(configuration.GetSection("StringConexao").Value);
        }

        public void AdicionarGato(Gato gato)
        {
            //
        }

    }
}
