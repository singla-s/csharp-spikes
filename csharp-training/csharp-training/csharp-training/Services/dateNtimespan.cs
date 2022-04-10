using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_training.Services
{
    public class DateNtimespan
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public DateNtimespan(DateTime startDate, DateTime endDate)
        {
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public double passedDuration()
        {
            return (endDate - startDate).TotalMinutes;
        }
    }
}
