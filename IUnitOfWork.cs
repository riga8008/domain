using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cain.Domain.Shared
{
    public  interface IUnitOfWork
    {
        // TODO: Add more Unit of work operations like transactions.
        void Commit();
    }
}
