using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cain.Infrastructure.Fakes
{
    public interface IDataSource
    {
        IEnumerable Events { get; }
    }
}
