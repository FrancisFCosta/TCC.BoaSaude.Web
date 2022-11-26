using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using TCC.BoaSaude.Web.Entidades.DTO;

namespace TCC.BoaSaude.Web.Models
{
    public class RegistroAtendimentoModel
    {
        public int DocumentoPrestador { get; set; }
        public List<SelectListItem> ListaPrestadores { get; set; }
        public int DocumentoAssociado { get; set; }
        public List<SelectListItem> ListaAssociados { get; set; }
        public DateTime DataAtendimento { get; set; }
        public decimal ValorConsulta { get; set; }
        public decimal ValorCoparticipacao { get; set; }

        public RegistroAtendimentoModel(List<PrestadorDTO> listaPrestadores, List<AssociadoDTO> listaAssociados)
        {
            ListaPrestadores = new List<SelectListItem>();

            if (listaPrestadores != null)
            {
                foreach (var prestador in listaPrestadores)
                    ListaPrestadores.Add(new SelectListItem() { Text = prestador.Nome, Value = prestador.Documento });
            }

            ListaAssociados = new List<SelectListItem>();

            if (listaAssociados != null)
            {
                foreach (var associado in listaAssociados)
                    ListaAssociados.Add(new SelectListItem() { Text = associado.Nome, Value = associado.Documento });
            }
        }
    }
}
