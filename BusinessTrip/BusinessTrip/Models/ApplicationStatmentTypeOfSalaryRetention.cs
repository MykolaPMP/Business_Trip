using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessTrip.Models
{
    public class ApplicationStatmentTypeOfSalaryRetention
    {
        //public ApplicationStatmentTypeOfSalaryRetention()
        //{
        //    TypesOfSalaryRetention = new HashSet<ApplicationStatement>();
        //}


        [Key]
        [Required]
        public int TypeOfSalaryRetentionId { get; set; }
        [Required]
        [MaxLength(50)]
        public string TypeOfSalaryRetentionName { get; set; }

        //public virtual ICollection<ApplicationStatement> TypesOfSalaryRetention { get; set; }
    }
}
