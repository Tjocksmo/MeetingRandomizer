using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting
{
    interface IMeeting
    {
        public string Secretary { get; set; }
        public string Adjuster { get; set; }
        public void RandomSecretaryAndAdjuster();
    }
}
