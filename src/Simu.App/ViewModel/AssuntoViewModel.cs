﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simu.App.ViewModel
{
    public class AssuntoViewModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public TipoAssuntoViewModel TipoAssunto { get; set; }
    }
}
