namespace M2RG.MyTimesheet.ContextValidation
{
    public class ContextValidator
    {
        public bool Validator(IContextWorker contextWorker)
        {
            if (contextWorker.ValidateAdmin())
            {
                return true;
            }

            if (!contextWorker.ValidateCompany())
            {
                return false;
            }

            return true;
        }
    }
}
