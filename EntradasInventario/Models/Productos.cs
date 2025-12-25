using System.ComponentModel.DataAnnotations;

namespace EntradasInventario.Models;

public class Productos
{
    [Key]
    public int ProductoId { get; set; }

    [Required(ErrorMessage = "El campo Descripción es obligatorio.")]
    public string Descripcion { get; set; } = string.Empty;

    [Required(ErrorMessage = "El campo Costo es obligatorio.")]
    [Range(1, double.MaxValue, ErrorMessage = "El costo debe ser igual o mayor que 1.")]
    public decimal Costo { get; set; }

    [Required(ErrorMessage = "El campo Precio es obligatorio.")]
    [Range(1, double.MaxValue, ErrorMessage = "El precio debe ser igual o mayor que 1.")]
    public decimal Precio { get; set; }
    
    public int Existencia { get; set; }
    
    public ICollection<EntradaDetalle> EntradaDetalles { get; set; } = [];
}
 