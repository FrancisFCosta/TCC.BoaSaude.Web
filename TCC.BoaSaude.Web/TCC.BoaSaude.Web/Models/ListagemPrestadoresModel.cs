using System;
using System.Collections.Generic;
using TCC.BoaSaude.Web.Entidades.DTO;

namespace TCC.BoaSaude.Web.Models
{
    public class ListagemPrestadoresModel
    {
        public List<PrestadorModel> ListaPrestadores { get; set; }
        public string Especialidade{ get; set; }

        public ListagemPrestadoresModel(string especialidade, List<PrestadorDTO> listaPrestadorDTO)
        {
            ListaPrestadores = new List<PrestadorModel>();
            Especialidade = especialidade;
            if (listaPrestadorDTO != null)
            {
                foreach (var prestador  in listaPrestadorDTO)
                    ListaPrestadores.Add(new PrestadorModel(prestador)); 
            }
        }
    }
}
