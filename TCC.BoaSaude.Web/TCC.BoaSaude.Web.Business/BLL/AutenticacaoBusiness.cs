using System;
using System.Collections.Generic;
using System.Text;
using TCC.BoaSaude.Web.Entidades.DTO;
using TCC.BoaSaude.Web.Infrastructure.Repositories;

namespace TCC.BoaSaude.Web.Business.BLL
{
    public class AutenticacaoBusiness
    {
        private readonly AutenticacaoRepository _autenticacaoRepository;
        public AutenticacaoBusiness() 
        {
            _autenticacaoRepository = new AutenticacaoRepository();
        }

        public AutenticacaoDTO EfetuarLogin(UsuarioDTO usuario) 
        {
            return _autenticacaoRepository.EfeturaLogin(usuario);
        }
    }
}
