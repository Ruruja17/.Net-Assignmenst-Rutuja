using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MVVMAtm_ASSIGN.Models
{
    [Table("Card")]
    public class Card
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]

        public int? Transaction_Id  { get; set; }

        public long?  CardNo { get; set; }

        public DateTime? Transaction_Date { get; set; }

        public string Transaction_Type { get; set; }

        public Decimal? Amount { get; set; }
    }
}
