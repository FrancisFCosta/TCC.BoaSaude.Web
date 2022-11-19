using System;
using System.Collections.Generic;
using System.Text;
using TCC.BoaSaude.Web.Entidades.DTO;
using TCC.BoaSaude.Web.Infrastructure.Repositories;

namespace TCC.BoaSaude.Web.Business.BLL
{
    public class PrestadorBusiness
    {
        private readonly PrestadorRepository _prestadorRepository;
        public PrestadorBusiness()
        {
            _prestadorRepository = new PrestadorRepository();
        }
        public List<PrestadorDTO> ListarPrestadores()
        {
            return _prestadorRepository.ListarPrestadores();
        }
    }
}
