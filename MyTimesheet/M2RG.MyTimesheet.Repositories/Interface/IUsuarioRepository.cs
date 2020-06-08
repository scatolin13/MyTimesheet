using M2RG.MyTimesheet.Domain.Models;
using M2RG.MyTimesheet.DTO.Usuarios;

namespace M2RG.MyTimesheet.Repositories.Interface
{
    public interface IUsuarioRepository
    {
        UsuarioInfoDto ValidarLogin(UsuarioLoginDto usuarioLogin);

    }
}
