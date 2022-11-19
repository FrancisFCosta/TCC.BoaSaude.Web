using System;

namespace TCC.BoaSaude.Web.Entidades.DTO
{
    public class PessoaDTO
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Endereco { get; set; }
        public FormacaoDTO Formacao { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
