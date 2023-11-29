using System;
using System.Collections.Generic;

namespace PetShop.Models;

public partial class Venta
{
    public int IdVenta { get; set; }

    public decimal? Total { get; set; }

    public DateTime? FechaCompra { get; set; }

    public virtual ICollection<ProductosVenta> ProductosVenta { get; set; } = new List<ProductosVenta>();
}
