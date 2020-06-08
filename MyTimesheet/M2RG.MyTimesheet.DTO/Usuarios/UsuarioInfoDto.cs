using M2RG.MyTimesheet.Flunt.Validations;
using System;

namespace M2RG.MyTimesheet.DTO.Usuarios
{
    public class UsuarioInfoDto : EntityBase
    {
        public bool EstaValido { get; set; }
        public string Nome { get; set; }
        public DateTime UltimoAcesso { get; set; }

    }
}
