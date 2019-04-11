using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.Repositories
{
    public interface ISimpleAppRepository
    {
        DateTime GetCurrentDateTime();
    }
}
