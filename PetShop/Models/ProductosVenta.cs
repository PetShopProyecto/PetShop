using System;
using System.Collections.Generic;

namespace PetShop.Models;

public partial class ProductosVenta
{
    public int IdVproducto { get; set; }

    public int? IdVenta { get; set; }

    public int? IdProducto { get; set; }

    public int? Cantidadv { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }

    public virtual Venta? IdVentaNavigation { get; set; }
}
