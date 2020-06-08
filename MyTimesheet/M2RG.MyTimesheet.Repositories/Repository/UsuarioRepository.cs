using M2RG.MyTimesheet.Domain.Models;
using M2RG.MyTimesheet.DTO.Usuarios;
using M2RG.MyTimesheet.Repositories.Interface;
using System;

namespace M2RG.MyTimesheet.Repositories.Repository
{
    public class UsuarioRepository : RepositoryBase<Usuarios>, IUsuarioRepository
    {
        internal UsuarioRepository()
        {
        }

        public UsuarioInfoDto ValidarLogin(UsuarioLoginDto usuarioLogin)
        {
            throw new NotImplementedException();
        }
    }
}
