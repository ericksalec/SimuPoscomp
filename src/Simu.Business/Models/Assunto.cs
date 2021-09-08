using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simu.App.Models
{
    public class Assunto : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public TipoAssunto TipoAssunto { get; set; }

    }
}
