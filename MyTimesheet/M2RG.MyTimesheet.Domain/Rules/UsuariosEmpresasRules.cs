using M2RG.MyTimesheet.Flunt.Validations;

namespace M2RG.MyTimesheet.Domain.Models
{
    public partial class UsuariosEmpresas : EntityBase
    {
        public UsuariosEmpresas Adicionar(int usuarioId, int empresaId)
        {
            IsGreaterThan(usuarioId, 0, EntityName, "Usuário ID", "deve ser maior que zero");
            IsGreaterThan(empresaId, 0, EntityName, "Empresa ID", "deve ser maior que zero");

            if (IsValid)
            {
                UsuarioId = usuarioId;
                EmpresaId = empresaId;
            }

            return this;
        }
    }
}
