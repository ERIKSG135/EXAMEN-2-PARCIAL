using System.ComponentModel.DataAnnotations;

namespace ProductosEx.Data
    {
    public class Producto
    {
        [Required(ErrorMessage = "El número de inventario no debe estar vació")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe ser entero posivo mayor que 0")]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre no debe estar vació")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Debe seleccionar departamento")]
        public string? Departamento { get; set; }
    }
}