using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSavePdf.Models
{
    internal class TicketCounterAndLog
    {
        public int TicketCounter { get; set; }
        public BindingList<string> Log { get; set; }
        public TicketCounterAndLog()
        {
            TicketCounter = 0;
            Log = new BindingList<string>();
            Log.Add("Ticket counter initialized to 0");
        }
        public void IncrementCounter()
        {
            TicketCounter++;
            Log.Add($"Ticket counter incremented to {TicketCounter}");
        }
        public void AddLogEntry(string entry)
        {
            Log.Add(entry);
        }
    }
}
