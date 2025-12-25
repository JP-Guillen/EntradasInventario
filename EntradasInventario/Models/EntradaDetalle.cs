using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntradasInventario.Models;

public class EntradaDetalle
{
    [Key]
    public int Id { get; set; }
    public int EntradaId { get; set; }
    public int ProductoId { get; set; }
    public int Cantidad { get; set; }
    public decimal Costo { get; set; }

    [ForeignKey(nameof(EntradaId))]
    public Entrada Entrada { get; set; } = null!;

    [ForeignKey(nameof(ProductoId))]
    public Productos Producto { get; set; } = null!;
}
