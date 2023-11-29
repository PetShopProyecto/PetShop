using System;
using System.Collections.Generic;

namespace PetShop.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? Cantidadt { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public string? Imagen { get; set; }

    public virtual ICollection<ProductosUsuario> ProductosUsuarios { get; set; } = new List<ProductosUsuario>();

    public virtual ICollection<ProductosVenta> ProductosVenta { get; set; } = new List<ProductosVenta>();
}
