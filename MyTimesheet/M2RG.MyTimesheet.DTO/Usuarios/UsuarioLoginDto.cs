using M2RG.MyTimesheet.Flunt.Validations;

namespace M2RG.MyTimesheet.DTO.Usuarios
{
    public class UsuarioLoginDto : EntityBase
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
