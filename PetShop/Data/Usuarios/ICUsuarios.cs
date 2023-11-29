using PetShop.Models;
namespace PetShop.Data.Usuarios
{
    public interface ICUsuarios
    {
        Task<IEnumerable<Usuario>> GetAllUsuario();
        Task<Usuario> GetUsuarioDetails(int id);
        Task<bool> UpdateUsuario(Usuario usuario);
        Task<bool> InsertUsuario(Usuario usuario);
        Task<bool> DeleteUsuario(int id);
        Task<bool> SaveUsuario(Usuario usuario);
    }
}
