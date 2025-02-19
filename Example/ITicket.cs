using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public interface ITicket
    {
        void AddTicket(ITicket ticket);
        ITicket GetTicket(int id);
    }

    
}
