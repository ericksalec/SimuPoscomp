using Simu.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Simu.App.ViewModel
{
    public class ProvaViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public Questao Questao { get; set; }
        public DateTime Data { get; set; }
    }
}
