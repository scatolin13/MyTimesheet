using System;

namespace M2RG.MyTimesheet.Flunt.Validations
{
    public partial class EntityBase
    {
        public EntityBase AreEquals(Guid val, Guid comparer, string key, string property, string message)
        {
            // TODO: StringComparison.OrdinalIgnoreCase not suported yet
            if (val.ToString() != comparer.ToString())
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(Guid val, Guid comparer, string key, string property, string message)
        {
            // TODO: StringComparison.OrdinalIgnoreCase not suported yet
            if (val.ToString() == comparer.ToString())
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsEmpty(Guid val, string key, string property, string message)
        {
            if (val != Guid.Empty)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsNotEmpty(Guid val, string key, string property, string message)
        {
            if (val == Guid.Empty)
            {
                AddNotification(key, property, message);
            }

            return this;
        }
    }
}
