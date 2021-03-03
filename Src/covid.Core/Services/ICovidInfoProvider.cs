using covid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace covid.Core.Services
{
    public interface ICovidInfoProvider
    {
        Task<Overview> GetOverview();
    }
}
