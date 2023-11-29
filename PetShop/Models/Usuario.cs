using System;
using System.Collections.Generic;

namespace PetShop.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Usuario1 { get; set; }

    public string? Correo { get; set; }

    public string? Clave { get; set; }

    public string? Trol { get; set; }

    public string? Nombre { get; set; }

    public string? ApellidoP { get; set; }

    public string? ApellidoM { get; set; }

    public virtual ICollection<ProductosUsuario> ProductosUsuarios { get; set; } = new List<ProductosUsuario>();
}
