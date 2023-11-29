using Microsoft.EntityFrameworkCore;
using PetShop.Data.Productos;
using PetShop.Models;

namespace PetShop.Data.Usuarios
{
    public class CUsuarios : ICUsuarios
    {
        private readonly TiendapetshopContext _context;
        public CUsuarios(TiendapetshopContext context)
        {
            _context = context;
        }
        public async Task<bool> DeleteUsuario(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(usuario);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Usuario>> GetAllUsuario()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task<Usuario> GetUsuarioDetails(int id)
        {
            return await _context.Usuarios.FindAsync(id);
        }

        public async Task<bool> InsertUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> SaveUsuario(Usuario usuario)
        {
            if (usuario.IdUsuario > 0)
                return await UpdateUsuario(usuario);
            else
                return await InsertUsuario(usuario);
        }

        public async Task<bool> UpdateUsuario(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
