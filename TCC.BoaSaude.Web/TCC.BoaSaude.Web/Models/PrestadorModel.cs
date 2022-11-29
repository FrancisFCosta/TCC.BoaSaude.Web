using System;
using TCC.BoaSaude.Web.Entidades.DTO;

namespace TCC.BoaSaude.Web.Models
{
    public class PrestadorModel
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Endereco { get; set; }
        public FormacaoDTO Formacao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string Especialidade { get;  set; }

        public PrestadorModel() { }

        public PrestadorModel(PrestadorDTO prestador)
        {
            IdPessoa = prestador.IdPessoa;
            Nome = prestador.Nome;
            Documento = prestador.Documento;
            Endereco = prestador.Endereco;
            Formacao = prestador.Formacao;
            DataInclusao = prestador.DataInclusao;
            DataAlteracao = prestador.DataAlteracao;
            Especialidade = prestador.Especialidade;
        }
    }
}
