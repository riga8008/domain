using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cain.Domain.Entities;
using Cain.Domain.Shared;


namespace Cain.Domain.Repositories
{
    public interface IEventRepository : IGenericRepository<Event>
    {
        IQueryable<Event> Exams { get; }
        IQueryable<Event> Practices { get; }
        int NumberOfEvents();
    }
}
