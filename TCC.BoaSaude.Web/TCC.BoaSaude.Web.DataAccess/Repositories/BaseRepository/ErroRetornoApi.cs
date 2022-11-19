using System;
using System.Collections.Generic;
using System.Text;

namespace TCC.BoaSaude.Web.Infrastructure.Repositories.BaseRepository
{
    public class ErroRetornoApi
    {
        public string Mensagem { get; set; }
        public string Parametro { get; set; }
        public string Valor { get; set; }
        public string CodigoErro { get; set; }
    }
}
