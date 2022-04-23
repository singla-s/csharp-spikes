using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_training.Services
{
    public class DateNtimespan
    {
        private readonly Logger _logger;
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public DateNtimespan(DateTime startDate, DateTime endDate, Logger logger)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            _logger = logger;

         }

        public double passedDuration()
        {
            double passedDuration = (endDate - startDate).TotalMinutes;
            _logger.log($"{passedDuration.ToString()} minutes passed.");
            return passedDuration;
        }
    }
}
