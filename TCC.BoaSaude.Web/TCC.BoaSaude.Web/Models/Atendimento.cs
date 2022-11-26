using System;

namespace TCC.BoaSaude.Web.Models
{
    public class Atendimento
    {
        public PrestadorModel Prestador { get; set; }
        public AssociadoModel Associado { get; set; }
        public DateTime DataAtendimento{ get; set; }
        public decimal ValorConsulta { get; set; }
        public decimal ValorCoparticipacao { get; set; }
    }
}
