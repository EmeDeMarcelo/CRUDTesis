using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class ContactoModel
    {
        public int IdProducto { get; set; }
        [Required(ErrorMessage ="El campo Nombre es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El campo Cantidad es obligatorio")]
        public string? Cantidad { get; set; }
        [Required(ErrorMessage = "El campo Precio es obligatorio")]
        public string? Precio { get; set; }
    }
}
