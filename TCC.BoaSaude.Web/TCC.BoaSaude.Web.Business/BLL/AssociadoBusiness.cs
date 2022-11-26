using System;
using System.Collections.Generic;
using System.Text;
using TCC.BoaSaude.Web.Entidades.DTO;
using TCC.BoaSaude.Web.Infrastructure.Repositories;

namespace TCC.BoaSaude.Web.Business.BLL
{
    public class AssociadoBusiness
    {
        private readonly AssociadoRepository _associadoRepository;
        public AssociadoBusiness()
        {
            _associadoRepository = new AssociadoRepository();
        }
        public List<AssociadoDTO> ListarAssociados()
        {
            return _associadoRepository.ListarAssociados();
        }
    }
}
