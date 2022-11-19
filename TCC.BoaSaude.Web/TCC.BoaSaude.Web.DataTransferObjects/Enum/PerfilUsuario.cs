using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TCC.BoaSaude.Web.Entidades.Enum
{
    public enum PerfilUsuario
    {
        [Description("Cliente")]
        Cliente = 1,
        [Description("Operador")]
        Operador = 2
    }
}
