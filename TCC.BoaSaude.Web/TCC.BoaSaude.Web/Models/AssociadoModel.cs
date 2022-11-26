using System;
using TCC.BoaSaude.Web.Entidades.DTO;

namespace TCC.BoaSaude.Web.Models
{
    public class AssociadoModel
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Endereco { get; set; }
        public FormacaoDTO Formacao { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataAlteracao { get; set; }

        public AssociadoModel(AssociadoDTO associado)
        {
            IdPessoa = associado.IdPessoa;
            Nome = associado.Nome;
            Documento = associado.Documento;
            Endereco = associado.Endereco;
            Formacao = associado.Formacao;
            DataInclusao = associado.DataInclusao;
            DataAlteracao = associado.DataAlteracao;
        }
    }
}
