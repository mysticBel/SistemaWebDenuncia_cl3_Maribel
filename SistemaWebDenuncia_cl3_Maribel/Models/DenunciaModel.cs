using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SistemaWebDenuncia_cl3_Maribel.Models
{
    public class DenunciaModel
    {
        public int idDenuncia { get; set; }
        [Required]
        [Display(Name = "DNI")]
        [RegularExpression(@"[\d]{8}", ErrorMessage = "Ingrese ocho(8) números.")]
        public string? dni { get; set; }
        [Required]
        [Display(Name = "Nombres")]
        [RegularExpression(@"^[a-zA-Z0-9_\s\.]+$", ErrorMessage = "Solo utilice letras.")]
        public string? nombre { get; set; }
        [Required]
        [Display(Name = "Apellidos")]
        [RegularExpression(@"^[a-zA-Z0-9_\s\.]+$", ErrorMessage = "Solo utilice letras.")]
        public string? apellidos { get; set; }
        [Required]
        [Display(Name = "Empresa")]
        [RegularExpression(@"^[a-zA-Z0-9_\s\.]+$", ErrorMessage = "Solo utilice letras y puntos.")]
        public string? empresa { get; set; }
        [Required]
        [Display(Name = "Cuidad")]
        [RegularExpression(@"^[a-zA-Z0-9_\s\.]+$", ErrorMessage = "Solo utilice letras y puntos.")]
        public string? ciudad { get; set; }
        [Required]
        [Display(Name = "Celular")]
        [RegularExpression(@"[\d]{9}", ErrorMessage = "Ingrese ocho(9) números.")]
        public string? telefono { get; set; }
        [Required]
        [Display(Name = "Denuncia")]
        [RegularExpression(@"^[a-zA-Z0-9_\s\.]+$", ErrorMessage = "Solo utilice letras y puntos.")]
        public string? denuncia { get; set; }
    }
}
