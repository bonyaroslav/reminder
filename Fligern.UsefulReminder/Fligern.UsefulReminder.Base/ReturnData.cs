using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fligern.UsefulReminder.Base
{
    public class ReturnData
    {
        public string Data { get; set; }
        public int Number { get; set; }
        public ReturnData()
        {
            Number = -1;
        }
    }
}
