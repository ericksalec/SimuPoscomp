﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simu.App.Models
{
    public class Prova : Entity
    {
        public Questao Questoes { get; set; }
        public DateTime Data { get; set; }

    }
}
