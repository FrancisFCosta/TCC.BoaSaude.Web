using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TCC.BoaSaude.Web.Business.BLL;
using TCC.BoaSaude.Web.Entidades.DTO;
using TCC.BoaSaude.Web.Models;

namespace TCC.BoaSaude.Web.Controllers
{
    public class AtendimentoController : BaseController
    {
        private readonly AtendimentoBusiness _atendimentoBusiness;
        public AtendimentoController()
        {
            _atendimentoBusiness = new AtendimentoBusiness();
        }

        public IActionResult Index(string doctoPrestador, string nomePrestador)
        {
            if (!string.IsNullOrWhiteSpace(doctoPrestador) || !string.IsNullOrWhiteSpace(nomePrestador))
            {
                var prestador = new PrestadorDTO() { Documento = doctoPrestador, Nome = nomePrestador };
                return View(new RegistroAtendimentoModel(prestador));
            }

            return View(new RegistroAtendimentoModel(null));
        }

        public double CalcularCoparticipacao(string doctoPrestador, string doctoAssociado, double valorConsulta) 
        {
            return _atendimentoBusiness.CalcularCoparticipacao(doctoPrestador, doctoAssociado, valorConsulta);
        }
        public IActionResult SalvarAtendimento(RegistroAtendimentoModel model)
        {
            return View("AtendimentoConcluido");
        }
        public IActionResult AtendimentoConcluido(RegistroAtendimentoModel model)
        {
            return View("AtendimentoConcluido");
        }
    }
}
