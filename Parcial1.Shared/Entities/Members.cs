using System.ComponentModel.DataAnnotations;

namespace Parcial1.Shared.Entities
{
    public class Members
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Presidente")]
        [MaxLength(150, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Presidente { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Tesorero")]
        [MaxLength(150, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Tesorero { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Secretario")]
        [MaxLength(150, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Secretario { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Vocal1")]
        [MaxLength(150, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Vocal1 { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Vocal2")]
        [MaxLength(150, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public string Vocal2 { get; set; } = null!;
    }
}
