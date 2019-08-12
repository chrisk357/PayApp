using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayApp.Models
{
    public interface ITimeCardRepository
    {
        IEnumerable<TimeCard> GetAllTimeCards();
        TimeCard GetTimeCardById(int TimeCardId);
    }
}
