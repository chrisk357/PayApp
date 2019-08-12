using PayApp.Data;
using PayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayApp.Migrations
{
    public class TimeCardRepository : ITimeCardRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public TimeCardRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IEnumerable<TimeCard> GetAllTimeCards()
        {
            return _applicationDbContext.TimeCards;
        }

        public TimeCard GetTimeCardById(int TimeCardId)
        {
            return _applicationDbContext.TimeCards.FirstOrDefault(t => t.TimeCardID == TimeCardId);
        }
    }
}
