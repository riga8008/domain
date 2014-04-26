using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cain.Domain.Entities;
using Cain.Domain.Shared;

namespace Cain.Domain.Repositories
{
    public interface IGroupRepository : IGenericRepository<Group>
    {
        Student FindHightScored();
        Student FindLowScored();
        IEnumerable<Student> FindAscendantScored();
        IEnumerable<Student> FindDescendantScored();
    }
}
