using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cain.Domain.Shared;

namespace Cain.Infrastructure.Fakes
{
    public class FakeUnitOfWork :  IUnitOfWork
    {
        public void Commit()
        {
            System.Diagnostics.Debug.Write("Fake unit of work is working!");
        }
    }
}
