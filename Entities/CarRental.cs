using System;
using System.Collections.Generic;
using System.Text;

namespace Pereirão.Entities
{
    class CarRental
    {
        
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
       
        public Invoice Invoice { get; set; }
        public CarRental()
        {
        }

        public CarRental( DateTime start, DateTime finish)
        {
            
            Start = start;
            Finish = finish;
        }
    }
}
