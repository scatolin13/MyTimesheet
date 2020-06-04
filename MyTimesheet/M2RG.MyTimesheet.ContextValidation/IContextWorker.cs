namespace M2RG.MyTimesheet.ContextValidation
{
    public interface IContextWorker
    {
        bool ValidateCompany();
        bool ValidateAdmin();
    }
}
