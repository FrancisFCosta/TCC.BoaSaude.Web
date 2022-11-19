using System;
using TCC.BoaSaude.Web.Entidades.DTO;

namespace TCC.BoaSaude.Web.Models
{
    public class AutenticacaoModel
    {
        public UsuarioModel Usuario { get; set; }
        public String Token { get; set; }

        public AutenticacaoModel() { }
        public AutenticacaoModel(AutenticacaoDTO autenticacaoDTO)
        {
            Usuario = new UsuarioModel(autenticacaoDTO?.Usuario);
            Token = autenticacaoDTO?.Token;
        }
    }
}
