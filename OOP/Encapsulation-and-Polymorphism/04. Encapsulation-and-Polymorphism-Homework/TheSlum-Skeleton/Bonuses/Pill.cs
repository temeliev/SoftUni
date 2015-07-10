using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Bonuses
{
    public class Pill : Bonus
    {
        public Pill(string id)
            : base(id, 0, 0, 100)
        {
            this.Countdown = 1;
            this.Timeout = 1;
            this.HasTimedOut = false;
        }
    }
}
