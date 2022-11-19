using System;
using System.Collections.Generic;
using System.Text;
using TCC.BoaSaude.Web.Entidades.DTO;

namespace TCC.BoaSaude.Web.Infrastructure.Repositories
{
    public class UsuarioRepository : BaseRepository.BaseRepository
    {
        private readonly string _rotaUsuarios;
        public UsuarioRepository() : base(Environment.GetEnvironmentVariable("URL_BASE_API_INTEGRATION"))
        {
            _rotaUsuarios = "v1/usuarios";
        }
        public UsuarioDTO RegistrarUsuario(UsuarioDTO usuario)
        {
            UsuarioDTO retorno = Post<UsuarioDTO>(_rotaUsuarios+"/", null, usuario);
            return retorno;
        }
    }
}
