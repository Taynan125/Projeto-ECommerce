using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [MaxLength(50, ErrorMessage ="O campo Nome recebe no máximo 50 caracter")]
        [Display(Name = "Departamento")]
        [Index("Departament_Name_Index", IsUnique = true)]
        public String Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }

        public virtual ICollection<Company> Companies { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}