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
            _rotaAutenticacao = "/prestadores";
        }

        public List<PrestadorDTO> ListarPrestadores()
        {
            return new List<PrestadorDTO>() 
            { 
                new PrestadorDTO(){ Nome = "Dr. Wagner", Documento = "12345678910", Formacao = new FormacaoDTO() { Curso = "Técnico Enfermagem"}, Endereco = "Rua Tapaiaras 240 - Milionários, BH/MG"  },
                new PrestadorDTO(){ Nome = "Dr. Francis", Documento = "12345678910", Formacao = new FormacaoDTO() { Curso = "Medicina"} , Endereco = "Rua Genoveva 210 - Alagoas, BH/MG"},
                new PrestadorDTO(){ Nome = "Dr. Tulio", Documento = "12345678910", Formacao = new FormacaoDTO() { Curso = "Técnico Enfermagem"} , Endereco = "Rua Sergipe 100 - Centro, BH/MG"},
                new PrestadorDTO(){ Nome = "Dr. Ulisses", Documento = "12345678910" , Formacao = new FormacaoDTO() { Curso = "Medicina"}, Endereco = "Rua Saruira 11540 - Jardim da Babilônia, BH/MG"},
                new PrestadorDTO(){ Nome = "Dra. Luana", Documento = "12345678910" , Formacao = new FormacaoDTO() { Curso = "Técnico Enfermagem"}, Endereco = "Rua Candido de Souza  3000 - Nova Cintra, BH/MG"},
                new PrestadorDTO(){ Nome = "Dr. Daiana", Documento = "12345678910" , Formacao = new FormacaoDTO() { Curso = "Medicina"}, Endereco = "Rua Estrela da Alvorada 240 - Céu Azul, Contagem/MG"},
                new PrestadorDTO(){ Nome = "Dr. Thiago", Documento = "12345678910", Formacao = new FormacaoDTO() { Curso = "Técnico Enfermagem"}, Endereco = "Rua Azaléia Branca 120 - Havaí, BH/MG" },
                new PrestadorDTO(){ Nome = "Dr. Pedro", Documento = "12345678910", Formacao = new FormacaoDTO() { Curso = "Medicina"} , Endereco = "Avenida Amazonas  2250 - Santo Agostinho, Contagem/MG"},
            };
            List<PrestadorDTO> retorno = Get<List<PrestadorDTO>>($"{_rotaAutenticacao}/", null, null);
            return retorno;
        }
    }
}
