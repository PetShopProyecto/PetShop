using PetShop.Models;
using Microsoft.EntityFrameworkCore;

namespace PetShop.Data.Productos
{
    public class CProductos : ICProductos
    {
        private readonly TiendapetshopContext _context;
        public CProductos(TiendapetshopContext context)
        {
            _context = context;
        }
        public async Task<bool> DeleteProducto(int id)
        {
            var producto= await _context.Productos.FindAsync(id);
            _context.Productos.Remove(producto);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Producto>> GetAllProducto()
        {
            return await _context.Productos.ToListAsync();
        }

        public async Task<Producto> GetProductoDetails(int id)
        {
            return await _context.Productos.FindAsync(id);
        }

        public async Task<bool> InsertProducto(Producto producto)
        {
            _context.Productos.Add(producto);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> SaveProducto(Producto producto)
        {
            if (producto.IdProducto > 0)
                return await UpdateProducto(producto);
            else
                return await InsertProducto(producto);
        }

        public async Task<bool> UpdateProducto(Producto producto)
        {
            _context.Entry(producto).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
