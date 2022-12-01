using System;
using System.Collections.Generic;
using System.Text;
using TCC.BoaSaude.Web.Entidades.DTO;

namespace TCC.BoaSaude.Web.Infrastructure.Repositories
{
    public class PrestadorRepository : BaseRepository.BaseRepository
    {
        private readonly string _rotaAutenticacao;
        public PrestadorRepository() : base(Environment.GetEnvironmentVariable("URL_BASE_API_INTEGRATION"))
        {
            _rotaAutenticacao = "/prestador";
        }

        public List<PrestadorDTO> ListarPrestadores(string termo)
        {
            List<PrestadorDTO> retorno = Get<List<PrestadorDTO>>($"{_rotaAutenticacao}/{termo}", null, null);
            return retorno;
        }
    }
}
