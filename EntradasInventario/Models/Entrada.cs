using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EntradasInventario.Models;

public class Entrada
{
    [Key]
    public int EntradaId { get; set; }

    [Required(ErrorMessage = "El campo Fecha es obligatorio.")]
    public DateTime Fecha { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "El campo Concepto es obligatorio.")]
    public string Concepto { get; set; } = string.Empty;

    [Required(ErrorMessage = "El campo Total es obligatorio.")]
    [Range(1, double.MaxValue, ErrorMessage = "El total debe ser igual o mayor que 1.")]
    public decimal Total { get; set; }

    public ICollection<EntradaDetalle> EntradaDetalles { get; set; } = [];
}
