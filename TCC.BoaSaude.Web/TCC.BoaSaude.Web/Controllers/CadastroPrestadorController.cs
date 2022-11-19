using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TCC.BoaSaude.Web.Business.BLL;
using TCC.BoaSaude.Web.Entidades.DTO;
using TCC.BoaSaude.Web.Models;

namespace TCC.BoaSaude.Web.Controllers
{
    public class CadastroPrestadorController : BaseController
    {
        private readonly PrestadorBusiness _prestadorBusiness;

        public CadastroPrestadorController()
        {
            _prestadorBusiness = new PrestadorBusiness();
        }

        public IActionResult Index()
        {
            List<PrestadorDTO> listaPrestadores = new List<PrestadorDTO>();

            var prestadoresResult = _prestadorBusiness.ListarPrestadores();

            if (prestadoresResult != null)
                listaPrestadores = prestadoresResult;

            base.PreencherViewBagUsuarioLogado();
            return View(new ListagemPrestadoresModel(listaPrestadores));
        }

        public IActionResult CadastrarPrestador(string documento)
        {
            if (!string.IsNullOrWhiteSpace(documento))
            {
                //Todo editar
            }

            return View(new PrestadorModel());
        }
    }
}