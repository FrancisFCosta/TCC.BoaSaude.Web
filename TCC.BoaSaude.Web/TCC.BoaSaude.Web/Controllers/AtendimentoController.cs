using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TCC.BoaSaude.Web.Business.BLL;
using TCC.BoaSaude.Web.Entidades.DTO;
using TCC.BoaSaude.Web.Models;

namespace TCC.BoaSaude.Web.Controllers
{
    public class AtendimentoController : BaseController
    {
        private readonly PrestadorBusiness _prestadorBusiness;
        private readonly AssociadoBusiness _associadoBusiness;

        public AtendimentoController()
        {
            _prestadorBusiness = new PrestadorBusiness();
            _associadoBusiness = new AssociadoBusiness();
        }
        public IActionResult Index()
        {
            List<PrestadorDTO> listaPrestadores = new List<PrestadorDTO>();
            List<AssociadoDTO> listaAssociados = new List<AssociadoDTO>();

            var prestadoresResult = _prestadorBusiness.ListarPrestadores();
            var associadosResult = _associadoBusiness.ListarAssociados();

            if (prestadoresResult != null)
                listaPrestadores = prestadoresResult;

            if (associadosResult != null)
                listaAssociados = associadosResult;

            base.PreencherViewBagUsuarioLogado();
            return View(new RegistroAtendimentoModel(listaPrestadores, listaAssociados));
        }
    }
}
