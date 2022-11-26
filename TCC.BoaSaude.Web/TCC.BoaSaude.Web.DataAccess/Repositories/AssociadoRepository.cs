using System;
using System.Collections.Generic;
using System.Text;
using TCC.BoaSaude.Web.Entidades.DTO;

namespace TCC.BoaSaude.Web.Infrastructure.Repositories
{
    public class AssociadoRepository : BaseRepository.BaseRepository
    {
        private readonly string _rotaAutenticacao;
        public AssociadoRepository() : base(Environment.GetEnvironmentVariable("URL_BASE_API_INTEGRATION"))
        {
            _rotaAutenticacao = "v1/associados";
        }

        public List<AssociadoDTO> ListarAssociados()
        {
            return new List<AssociadoDTO>()
            {
                new AssociadoDTO(){ Nome = "José da Silva", Documento = "9" },
                new AssociadoDTO(){ Nome = "Francis José da Silva", Documento = "10" },
                new AssociadoDTO(){ Nome = "Tulio José da Silva", Documento = "11" },
                new AssociadoDTO(){ Nome = "Ulisses José da Silva", Documento = "12" },
                new AssociadoDTO(){ Nome = "Luana José da Silva", Documento = "13" },
                new AssociadoDTO(){ Nome = "Daiana José da Silva", Documento = "14" },
                new AssociadoDTO(){ Nome = "Thiago José da Silva", Documento = "15" },
                new AssociadoDTO(){ Nome = "Pedro José da Silva", Documento = "16" },
            };
            //List<VeiculoDTO> retorno = Get<List<PrestadorDTO>>($"{_rotaAutenticacao}/disponiveis", null, null);
            //return retorno;
        }
    }
}
