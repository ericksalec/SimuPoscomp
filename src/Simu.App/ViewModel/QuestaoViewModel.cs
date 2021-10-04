using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Simu.App.ViewModel
{
    public class QuestaoViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Key]
        public Guid ProvaId { get; set; }
        [Key]
        public Guid AssuntoId { get; set; }
        public string Tema { get; set; }
        public string Conteudo { get; set; }
        public TipoAssuntoViewModel TipoAssunto { get; set; }

        // EF Relation
        public AssuntoViewModel Assunto { get; set; }
        public ProvaViewModel Prova { get; set; }
    }
}
