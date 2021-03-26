using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerceTaynan.Models
{
    public class City
    {
        [Key]
        [Display(Name =  "Cidade Id")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "O campo Cidade é obrigatorio")]
        [Display(Name = "Cidade")]
        public String Name { get; set; }

        [Required(ErrorMessage = "O campo Departamento é obrigatorio")]
        [Display(Name = "Departamento")]
        [Range(1, double.MaxValue,ErrorMessage ="Selecione um Departamento")]
        public int DepartamentsId { get; set; }

        public virtual Departaments Departaments { get; set; }
    }
}