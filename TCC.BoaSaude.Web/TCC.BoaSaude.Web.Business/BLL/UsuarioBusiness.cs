using System;
using System.Collections.Generic;
using System.Text;
using TCC.BoaSaude.Web.Entidades.DTO;
using TCC.BoaSaude.Web.Infrastructure.Repositories;

namespace TCC.BoaSaude.Web.Business.BLL
{
    public class UsuarioBusiness
    {
        private readonly UsuarioRepository _usuarioRepository;
        public UsuarioBusiness()
        {
            _usuarioRepository = new UsuarioRepository();
        }
        public UsuarioDTO RegistrarUsuario(UsuarioDTO usuario)
        {
            return _usuarioRepository.RegistrarUsuario(usuario);
        }
    }
}
