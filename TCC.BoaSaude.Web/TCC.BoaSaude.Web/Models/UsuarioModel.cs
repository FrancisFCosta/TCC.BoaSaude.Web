using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.BoaSaude.Web.Entidades.DTO;
using TCC.BoaSaude.Web.Entidades.Enum;

namespace TCC.BoaSaude.Web.Models
{
    public class UsuarioModel
    {
        public int IdUsuario { get; set; }
        public PerfilUsuario Perfil { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string ConfirmacaoSenha { get; set; }
        public string NomeUsuario { get; set; }
        public bool PreReserva { get; set; }

        public UsuarioModel() { }
        public UsuarioModel(UsuarioDTO usuarioDTO) 
        {
            IdUsuario = usuarioDTO.IdUsuario;
            Perfil = usuarioDTO.Perfil;
            Login = usuarioDTO.Login;
            Senha = usuarioDTO.Senha;
        }
    }
}
