using System;
using System.Collections.Generic;
using System.Text;

namespace TCC.BoaSaude.Web.Entidades.DTO
{
    public class AutenticacaoDTO
    {
        public UsuarioDTO Usuario { get; set; }
        public String Token { get; set; }
    }
}
