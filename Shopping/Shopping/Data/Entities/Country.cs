using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="País")]
        [MaxLength(50, ErrorMessage ="El campo {0} debe tener {1} carácteres como mínimo")]
        [Required (ErrorMessage ="El campo {0} es obligatorio")]
        public string? NameCountry { get; set; }

    }
}
