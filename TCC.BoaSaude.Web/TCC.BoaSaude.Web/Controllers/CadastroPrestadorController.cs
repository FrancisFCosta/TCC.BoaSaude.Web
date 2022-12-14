using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
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

        public IActionResult Index(string termo)
        {
            List<PrestadorDTO> listaPrestadores = new List<PrestadorDTO>();

            if (!string.IsNullOrWhiteSpace(termo))
            {
                var prestadoresResult = _prestadorBusiness.ListarPrestadores(termo);

                if (prestadoresResult != null)
                    listaPrestadores = prestadoresResult;
            }

            base.PreencherViewBagUsuarioLogado();
            return View(new ListagemPrestadoresModel(termo, listaPrestadores));
        }

        public IActionResult CadastrarPrestador(string documento)
        {
            PrestadorModel prestador = null;

            if (!string.IsNullOrWhiteSpace(documento))
            {
                var prestadoresResult = _prestadorBusiness.ListarPrestadores(documento).FirstOrDefault(p => p.Documento == documento.Trim());
                prestador = new PrestadorModel(prestadoresResult);
            }
            else
            {
                prestador = new PrestadorModel();
            }

            return View(prestador);
        }
    }
}