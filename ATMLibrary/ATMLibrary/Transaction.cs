using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLibrary
{
    public class Transaction
    {
       
        public long CardNo { get; set; }

        public DateTime? TranscDate { get; set; }

        public string TranscType { get; set; }

        public Decimal? Amount { get; set; }



        

       
       
    }

}
