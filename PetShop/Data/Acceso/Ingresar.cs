using PetShop.Models;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;

namespace PetShop.Data.Acceso
{

    public class Ingresar : IIngresar
    {
        private readonly TiendapetshopContext _context;
        public Ingresar(TiendapetshopContext context)
        {
            _context = context;
        }
        public Task<bool> Acceso(string correo, string clave)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Usuario>> GetAllUsuario()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public Task<Usuario> GetUsuarioDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
