namespace M2RG.MyTimesheet.Flunt.Validations
{
    public partial class EntityBase
    {
        public EntityBase IsNull(object obj, string key, string property, string message)
        {
            if (obj != null)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsNotNull(object obj, string key, string property, string message)
        {
            if (obj == null)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(object obj, object comparer, string key, string property, string message)
        {
            if (!obj.Equals(comparer))
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(object obj, object comparer, string key, string property, string message)
        {
            if (obj.Equals(comparer))
            {
                AddNotification(key, property, message);
            }

            return this;
        }
    }
}
