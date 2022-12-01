using System;
using System.Collections.Generic;
using System.Text;
using TCC.BoaSaude.Web.Entidades.DTO;
using TCC.BoaSaude.Web.Infrastructure.Repositories;

namespace TCC.BoaSaude.Web.Business.BLL
{
    public class AtendimentoBusiness
    {
        private readonly AtendimentoRepository _atendimentoRepository;
        public AtendimentoBusiness()
        {
            _atendimentoRepository = new AtendimentoRepository();
        }
        public double CalcularCoparticipacao(string doctoPrestador, string doctoAssociado, double valorConsulta)
        {
            return _atendimentoRepository.CalcularCoparticipacao(doctoPrestador, doctoAssociado, valorConsulta);
        }
        public List<AssociadoDTO> ListarAssociados()
        {
            return _atendimentoRepository.ListarAssociados();
        }
    }
}
