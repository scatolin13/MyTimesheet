namespace M2RG.MyTimesheet.Flunt.Validations
{
    public partial class EntityBase
    {
        #region IsGreaterThan

        public EntityBase IsGreaterThan(decimal val, double comparer, string key, string property, string message)
        {
            if ((double)val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(double val, double comparer, string key, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(float val, double comparer, string key, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(long val, double comparer, string key, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(int val, double comparer, string key, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion IsGreaterThan

        #region IsGreaterOrEqualsThan

        public EntityBase IsGreaterOrEqualsThan(decimal val, double comparer, string key, string property, string message)
        {
            if ((double)val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(double val, double comparer, string key, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(float val, double comparer, string key, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(long val, double comparer, string key, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(int val, double comparer, string key, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion IsGreaterOrEqualsThan

        #region IsLowerThan

        public EntityBase IsLowerThan(decimal val, double comparer, string key, string property, string message)
        {
            if ((double)val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(double val, double comparer, string key, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(float val, double comparer, string key, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(long val, double comparer, string key, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(int val, double comparer, string key, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion IsLowerThan

        #region IsLowerOrEqualsThan

        public EntityBase IsLowerOrEqualsThan(decimal val, double comparer, string key, string property, string message)
        {
            if ((double)val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(double val, double comparer, string key, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(float val, double comparer, string key, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(long val, double comparer, string key, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(int val, double comparer, string key, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion IsLowerOrEqualsThan

        #region AreEquals

        public EntityBase AreEquals(decimal val, double comparer, string key, string property, string message)
        {
            if ((double)val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(double val, double comparer, string key, string property, string message)
        {
            if (val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(float val, double comparer, string key, string property, string message)
        {
            if (val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(long val, double comparer, string key, string property, string message)
        {
            if (val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(int val, double comparer, string key, string property, string message)
        {
            if (val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion AreEquals

        #region AreNotEquals

        public EntityBase AreNotEquals(decimal val, double comparer, string key, string property, string message)
        {
            if ((double)val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(double val, double comparer, string key, string property, string message)
        {
            if (val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(float val, double comparer, string key, string property, string message)
        {
            if (val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(long val, double comparer, string key, string property, string message)
        {
            if (val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(int val, double comparer, string key, string property, string message)
        {
            if (val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion AreNotEquals

        #region Between

        public EntityBase IsBetween(double val, double from, double to, string key, string property, string message)
        {
            if (!(val >= from && val <= to))
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion Between

        public EntityBase IsNullOrNullable(double? val, string key, string property, string message)
        {
            if (val == null || !val.HasValue)
            {
                AddNotification(key, property, message);
            }

            return this;
        }
    }
}
