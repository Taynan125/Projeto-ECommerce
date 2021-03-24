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
        public int DepartamentsId { get; set; }

        [Required(ErrorMessage ="O campo Nome é obrigatorio")]
        public String Name { get; set; }
    }
}