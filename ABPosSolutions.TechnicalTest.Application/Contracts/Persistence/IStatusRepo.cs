using ABPosSolutions.TechnicalTest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPosSolutions.TechnicalTest.Application.Contracts.Persistence
{
    public interface IStatusRepo : IBaseRepo<string,Status>
    {
    }
}
