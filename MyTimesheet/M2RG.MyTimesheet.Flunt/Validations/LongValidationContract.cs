namespace M2RG.MyTimesheet.Flunt.Validations
{
    public partial class EntityBase
    {
        #region IsGreaterThan

        public EntityBase IsGreaterThan(decimal val, long comparer, string key, string property, string message)
        {
            if ((double)val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(double val, long comparer, string key, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(float val, long comparer, string key, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(int val, long comparer, string key, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(long val, long comparer, string key, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion IsGreaterThan

        #region IsGreaterOrEqualsThan

        public EntityBase IsGreaterOrEqualsThan(decimal val, long comparer, string key, string property, string message)
        {
            if ((double)val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(double val, long comparer, string key, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(float val, long comparer, string key, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(int val, long comparer, string key, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(long val, long comparer, string key, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion IsGreaterOrEqualsThan

        #region IsLowerThan

        public EntityBase IsLowerThan(decimal val, long comparer, string key, string property, string message)
        {
            if ((double)val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(double val, long comparer, string key, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(float val, long comparer, string key, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(int val, long comparer, string key, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(long val, long comparer, string key, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion IsLowerThan

        #region IsLowerOrEqualsThan

        public EntityBase IsLowerOrEqualsThan(decimal val, long comparer, string key, string property, string message)
        {
            if ((double)val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(double val, long comparer, string key, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(float val, long comparer, string key, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(int val, long comparer, string key, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(long val, long comparer, string key, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion IsLowerOrEqualsThan

        #region AreEquals

        public EntityBase AreEquals(decimal val, long comparer, string key, string property, string message)
        {
            if ((double)val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(double val, long comparer, string key, string property, string message)
        {
            if (val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(float val, long comparer, string key, string property, string message)
        {
            if (val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(int val, long comparer, string key, string property, string message)
        {
            if (val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(long val, long comparer, string key, string property, string message)
        {
            if (val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion AreEquals

        #region AreNotEquals

        public EntityBase AreNotEquals(decimal val, long comparer, string key, string property, string message)
        {
            if ((double)val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(double val, long comparer, string key, string property, string message)
        {
            if (val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(float val, long comparer, string key, string property, string message)
        {
            if (val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(int val, long comparer, string key, string property, string message)
        {
            if (val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(long val, long comparer, string key, string property, string message)
        {
            if (val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion AreNotEquals

        #region Between

        public EntityBase IsBetween(long val, long from, long to, string key, string property, string message)
        {
            if (!(val >= from && val <= to))
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion Between
    }
}
