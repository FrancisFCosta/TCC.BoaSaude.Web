using System;
using System.Collections.Generic;
using System.Text;
using TCC.BoaSaude.Web.Entidades.Enum;

namespace TCC.BoaSaude.Web.Entidades.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        public PerfilUsuario Perfil { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
