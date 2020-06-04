using System;

namespace M2RG.MyTimesheet.Flunt.Validations
{
    public partial class EntityBase
    {
        public EntityBase IsGreaterThan(DateTime val, string key, DateTime comparer, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(DateTime val, string key, DateTime comparer, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(DateTime val, string key, DateTime comparer, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(DateTime val, string key, DateTime comparer, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsBetween(DateTime val, string key, DateTime from, DateTime to, string property, string message)
        {
            if (!(val >= from && val <= to))
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsNullOrNullable(DateTime? val, string key, string property, string message)
        {
            if (val == null || !val.HasValue)
            {
                AddNotification(key, property, message);
            }

            return this;
        }
    }
}
