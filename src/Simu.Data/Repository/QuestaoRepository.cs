using Simu.App.Models;
using Simu.Business.Interfaces;
using Simu.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simu.Data.Repository
{
    public class QuestaoRepository : Repository<Questao>, IQuestaoRepository
    {
        public QuestaoRepository(MeuDbContext context) : base(context) { }

    }
}
