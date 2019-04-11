using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.Models
{
    public class DateRecord
    {
        DateTime _currentTime;

        public DateTime CurrentTime
        {
            get
            {
                return _currentTime;
            }

            set
            {
                _currentTime = value;
            }

        }

    }
}
