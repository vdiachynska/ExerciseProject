using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class TicketDesk : ITicketDesk
    {
        private readonly List<ITicket> _ticketList;
        public List<ITicket> Tickets => _ticketList; //for the testing   

        public TicketDesk()
        {
            _ticketList = new List<ITicket>();
        }

        public void AddTicket(ITicket ticket)
        {
            _ticketList.Add(ticket);
        }

        public ITicket GetTicket(int id)
        {
            return _ticketList[id];
        }
    }
}
