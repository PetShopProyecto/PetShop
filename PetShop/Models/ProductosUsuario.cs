using System;
using System.Collections.Generic;

namespace PetShop.Models;

public partial class ProductosUsuario
{
    public int IdUproducto { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdProducto { get; set; }

    public int? Cantidadi { get; set; }

    public DateTime? Fechai { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
