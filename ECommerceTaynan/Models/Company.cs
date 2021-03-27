using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerceTaynan.Models
{
    public class Company
    {
        [Key]
        [Display(Name = "Compania Id")]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatorio")]
        [MaxLength(50, ErrorMessage = "O campo Nome recebe no máximo 50 caracter")]
        [Display(Name = "Nome")]
        [Index("Departament_Name_Index", IsUnique = true)]
        public String Name { get; set; }

        [Required(ErrorMessage = "O campo Telefone é obrigatorio")]
        [MaxLength(50, ErrorMessage = "O campo Telefone recebe no máximo 50 caracter")]
        [Display(Name = "Telefone")]
        [Index("Departament_Phone_Index", IsUnique = true)]
        [DataType(DataType.PhoneNumber)]
        public String Phone { get; set; }

        [Required(ErrorMessage = "O campo Endereço é obrigatorio")]
        [MaxLength(100, ErrorMessage = "O campo Endereço recebe no máximo 100 caracter")]
        [Display(Name = "Endereço")]
        public String Address { get; set; }

        [Display(Name = "Imagem")]
        [DataType(DataType.ImageUrl)]
        public String Logo { get; set; }

        [Required(ErrorMessage = "O campo Departamento é obrigatorio")]
        [Display(Name = "Departamento")]
        public int DepartamentsId { get; set; }

        [Required(ErrorMessage = "O campo Cidade é obrigatorio")]
        [Display(Name = "Cidade")]
        public int CityId { get; set; }

        public virtual Departaments Departaments { get; set; }

        public virtual City Cities { get; set; }
    }
}