using PetShop.Models;
namespace PetShop.Data.Ventas
{
    public interface ICVentas
    {
        Task<IEnumerable<Venta>> GetAllVenta();
        Task<Venta> GetVentaDetails(int id);
        Task<bool> UpdateVenta(Venta venta);
        Task<bool> InsertVenta(Venta venta);
        Task<bool> DeleteVenta(int id);
        Task<bool> SaveVenta(Venta venta);
    }
}
