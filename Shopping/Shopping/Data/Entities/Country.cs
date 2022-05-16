using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }
        //NOTACIONES - DATA NOTATION
        [Display(Name="País")]
        [MaxLength(50 , ErrorMessage = "El campo es {0} debe tener maximo {1} caracterés")]
        [Required(ErrorMessage = "El campo es {0} es obligatorio")]
        public string Name { get; set; }
    }
}
