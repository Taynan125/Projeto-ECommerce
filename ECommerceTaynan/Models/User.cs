using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace ECommerceTaynan.Models
{
    public class User
    {
        [Key]
        [Display(Name = "Usuario Id")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatorio")]
        [MaxLength(250, ErrorMessage = "O campo Email recebe no máximo 250 caracter")]
        [Display(Name = "Email")]
        [Index("User_Email_Index", IsUnique = true)]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatorio")]
        [MaxLength(50, ErrorMessage = "O campo Nome recebe no máximo 50 caracter")]
        [Display(Name = "Nome")]
        public String FirtName { get; set; }

        [Required(ErrorMessage = "O campo Sobrenome é obrigatorio")]
        [MaxLength(50, ErrorMessage = "O campo Sobrenome recebe no máximo 50 caracter")]
        [Display(Name = "Sobrenome")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "O campo Telefone é obrigatorio")]
        [MaxLength(50, ErrorMessage = "O campo Telefone recebe no máximo 50 caracter")]
        [Display(Name = "Telefone")]
        [Index("User_Phone_Index", IsUnique = true)]
        [DataType(DataType.PhoneNumber)]
        public String Phone { get; set; }

        [Required(ErrorMessage = "O campo Endereço é obrigatorio")]
        [MaxLength(100, ErrorMessage = "O campo Endereço recebe no máximo 100 caracter")]
        [Display(Name = "Endereço")]
        public String Address { get; set; }

        [Display(Name = "Imagem")]
        [DataType(DataType.ImageUrl)]
        public String Photo { get; set; }

        [NotMapped]
        [Display(Name = "Imagem")]
        public HttpPostedFileBase PhotoFile { get; set; }

        [Required(ErrorMessage = "O campo Departamento é obrigatorio")]
        [Display(Name = "Departamento")]
        public int DepartamentsId { get; set; }

        [Required(ErrorMessage = "O campo Cidade é obrigatorio")]
        [Display(Name = "Cidade")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "O campo Compania é obrigatorio")]
        [Display(Name = "Compania")]
        public int CompanyId { get; set; }

        [Display(Name = "Usuario")]
        public String FullName { get { return string.Format("{0} {1}", FirtName, LastName); } }

        public virtual Departaments Departaments { get; set; }

        public virtual City Cities { get; set; }

        public virtual Company Company { get; set; }
    }
}