using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.BoaSaude.Web.Entidades.DTO;

namespace TCC.BoaSaude.Web.Infrastructure.Repositories
{
    public class AtendimentoRepository : BaseRepository.BaseRepository
    {
        private readonly string _rotaAutenticacao;
        public AtendimentoRepository() : base(Environment.GetEnvironmentVariable("URL_BASE_API_INTEGRATION"))
        {
            _rotaAutenticacao = "/atendimento";
        }

        public double CalcularCoparticipacao(string doctoPrestador, string doctoAssociado, double valorConsulta) 
        {
            return Get<double>($"{_rotaAutenticacao}/valorCorpaticipacao/{doctoPrestador}/{doctoAssociado}/{valorConsulta}", null, null);
        }

        public List<AssociadoDTO> ListarAssociados()
        {
            return new List<AssociadoDTO>()
            {
                new AssociadoDTO(){ Nome = "José da Silva", Documento = "10987654321" },
                new AssociadoDTO(){ Nome = "Francis José da Silva", Documento = "10987654321" },
                new AssociadoDTO(){ Nome = "Tulio José da Silva", Documento = "10987654321" },
                new AssociadoDTO(){ Nome = "Ulisses José da Silva", Documento = "10987654321" },
                new AssociadoDTO(){ Nome = "Luana José da Silva", Documento = "10987654321" },
                new AssociadoDTO(){ Nome = "Daiana José da Silva", Documento = "10987654321" },
                new AssociadoDTO(){ Nome = "Thiago José da Silva", Documento = "10987654321" },
                new AssociadoDTO(){ Nome = "Pedro José da Silva", Documento = "10987654321" },
            };
            //List<VeiculoDTO> retorno = Get<List<PrestadorDTO>>($"{_rotaAutenticacao}/disponiveis", null, null);
            //return retorno;
        }
    }
}
