using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceTaynan.Models
{
    public class Departaments
    {   
        [Key]
        [Display(Name = "Departamento Id")]
        public int DepartamentsId { get; set; }

        [Required(ErrorMessage ="O campo Nome é obrigatorio")]
        [Display(Name = "Departamento")]
        public String Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}