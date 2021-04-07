using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerceTaynan.Models
{
    public class Tax
    {
        [Key]
        [Display(Name = "Taxa Id")]
        public int TaxId { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatorio")]
        [MaxLength(100, ErrorMessage = "O campo Nome recebe no máximo 100 caracter")]
        [Display(Name = "Nome")]
        [Index("Tax_Description_CompanyId_Index", 2, IsUnique = true)]
        public String Description { get; set; }

        [Required(ErrorMessage = "O campo Imposto é obrigatorio")]
        [Display(Name = "Imposto")]
        //[Range(0, 1, ErrorMessage = "Apenas valores de 0 e 1")]
        [DisplayFormat(DataFormatString = "{0:P2}", ApplyFormatInEditMode = false)]
        public double Rate { get; set; }

        [Required(ErrorMessage = "O campo Distribuidora é obrigatorio")]
        [Display(Name = "Distribuidora")]
        [Range(1, double.MaxValue, ErrorMessage = "Selecione um Departamento")]
        [Index("Tax_Description_CompanyId_Index", 1, IsUnique = true)]
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }
    
    }
}