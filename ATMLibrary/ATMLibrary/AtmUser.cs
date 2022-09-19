using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLibrary
{
    public class AtmUser
    {
        public long CardNo { get; set; }

        public int Pin { get; set; }

        public string FName { get; set; }

        public string Lname { get; set; }

        public Decimal? Balance { get; set; }

    }
}
