using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TCC.BoaSaude.Web.Entidades.Enum
{
    public enum CategoriaVeiculo
    {
        [Description("Básico")]
        Basico = 1,
        [Description("Completo")]
        Completo = 2,
        [Description("Luxo")]
        Luxo = 3
    }
}
