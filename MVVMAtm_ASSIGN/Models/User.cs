using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace MVVMAtm_ASSIGN.Models
{
    [Table("User")]
    public class User
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public long? CardNo { get; set; }

        public int ? Pin { get; set; }

        public string FName { get; set; }

        public string Lname { get; set; }

        public int? Balance { get; set; }

    }
}
