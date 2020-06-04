namespace M2RG.MyTimesheet.Flunt.Validations
{
    public partial class EntityBase
    {
        public EntityBase IsFalse(bool val, string key, string property, string message)
        {
            if (val)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsTrue(bool val, string key, string property, string message) =>
            IsFalse(!val, key, property, message);
    }
}
