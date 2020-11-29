using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessTrip.Models
{
    public class ApplicationStatmentTypeOfBusiness
    {
        //public ApplicationStatmentTypeOfBusiness()
        //{
        //    TypesOfBusiness = new HashSet<ApplicationStatement>();
        //}


        [Key]
        [Required]
        public int TypeOfBusinessId { get; set; }
        [Required]
        [MaxLength(50)]
        public string TypeOfBusinessName { get; set; }

        //public virtual ICollection<ApplicationStatement> TypesOfBusiness { get; set; }
    }
}
