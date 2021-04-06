using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceTaynan.Models
{
    public class Category
    {
        [Key]
        [Display(Name = "Categoria Id")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "O campo Categoria é obrigatorio")]
        [MaxLength(100, ErrorMessage = "O campo Categoria recebe no máximo 100 caracter")]
        [Display(Name = "Categoria")]
        [Index("Category_Description_CompanyId_Index", 2, IsUnique = true)]
        public String Description { get; set; }

        [Required(ErrorMessage = "O campo Distribuidora é obrigatorio")]
        [Display(Name = "Distribuidora")]
        [Range(1, double.MaxValue, ErrorMessage = "Selecione um Departamento")]
        [Index("Category_Description_CompanyId_Index", 1, IsUnique = true)]
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }
    }
}