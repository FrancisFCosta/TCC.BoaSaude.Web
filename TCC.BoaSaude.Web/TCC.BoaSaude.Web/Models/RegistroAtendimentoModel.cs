using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using TCC.BoaSaude.Web.Entidades.DTO;

namespace TCC.BoaSaude.Web.Models
{
    public class RegistroAtendimentoModel
    {
        public PrestadorDTO Prestador { get; set; }
        public string DocumentoAssociado { get; set; }
        public string NomeAssociado { get; set; }
        public DateTime DataAtendimento { get; set; }
        public decimal ValorConsulta { get; set; }
        public decimal ValorCoparticipacao { get; set; }

        public RegistroAtendimentoModel() 
        {
        }

        public RegistroAtendimentoModel(PrestadorDTO prestador)
        {
            Prestador = prestador;
            DataAtendimento = DateTime.Today;
        }
    }
}
