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
            _rotaAutenticacao = "v1/prestadores";
        }

        public List<PrestadorDTO> ListarPrestadores()
        {
            return new List<PrestadorDTO>();
            //List<VeiculoDTO> retorno = Get<List<PrestadorDTO>>($"{_rotaAutenticacao}/disponiveis", null, null);
            //return retorno;
        }
    }
}
