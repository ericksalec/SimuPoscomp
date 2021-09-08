using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simu.App.Models
{
    public class Questao : Entity
    {
        public Guid ProvaId { get; set; }
        public Guid AssuntoId { get; set; }
        public string Tema { get; set; }
        public string Conteudo { get; set; }
        public TipoAssunto TipoAssunto { get; set; }

        // EF Relation
        public Assunto Assunto { get; set; }
        public Prova Prova { get; set; }

    }
}
