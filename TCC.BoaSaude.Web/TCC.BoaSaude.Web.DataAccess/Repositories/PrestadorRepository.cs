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
            return new List<PrestadorDTO>() 
            { 
                new PrestadorDTO(){ Nome = "Dr. Wagner", Documento = "1", Formacao = new FormacaoDTO() { Curso = "Técnico Enfermagem"} },
                new PrestadorDTO(){ Nome = "Dr. Francis", Documento = "2", Formacao = new FormacaoDTO() { Curso = "Medicina"} },
                new PrestadorDTO(){ Nome = "Dr. Tulio", Documento = "3", Formacao = new FormacaoDTO() { Curso = "Técnico Enfermagem"} },
                new PrestadorDTO(){ Nome = "Dr. Ulisses", Documento = "4" , Formacao = new FormacaoDTO() { Curso = "Medicina"}},
                new PrestadorDTO(){ Nome = "Dra. Luana", Documento = "5" , Formacao = new FormacaoDTO() { Curso = "Técnico Enfermagem"}},
                new PrestadorDTO(){ Nome = "Dr. Daiana", Documento = "6" , Formacao = new FormacaoDTO() { Curso = "Medicina"}},
                new PrestadorDTO(){ Nome = "Dr. Thiago", Documento = "7", Formacao = new FormacaoDTO() { Curso = "Técnico Enfermagem"} },
                new PrestadorDTO(){ Nome = "Dr. Pedro", Documento = "8", Formacao = new FormacaoDTO() { Curso = "Medicina"} },
            };
            //List<VeiculoDTO> retorno = Get<List<PrestadorDTO>>($"{_rotaAutenticacao}/disponiveis", null, null);
            //return retorno;
        }
    }
}
