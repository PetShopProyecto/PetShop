using PetShop.Models;
namespace PetShop.Data.Productos
{
    public interface ICProductos
    {
        Task<IEnumerable<Producto>> GetAllProducto();
        Task<Producto> GetProductoDetails(int id);
        Task<bool> UpdateProducto(Producto producto);
        Task<bool> InsertProducto(Producto producto);
        Task<bool> DeleteProducto(int id);
        Task<bool> SaveProducto(Producto producto);
    }
}
