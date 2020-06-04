namespace M2RG.MyTimesheet.Flunt.Validations
{
    public partial class EntityBase
    {
        #region IsGreaterThan

        public EntityBase IsGreaterThan(decimal val, string key, decimal comparer, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(double val, string key, decimal comparer, string property, string message)
        {
            if (val <= (double)comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(float val, string key, decimal comparer, string property, string message)
        {
            if (val <= (float)comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(long val, string key, decimal comparer, string property, string message)
        {
            if (val <= (float)comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(int val, string key, decimal comparer, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion IsGreaterThan

        #region IsGreaterOrEqualsThan

        public EntityBase IsGreaterOrEqualsThan(decimal val, string key, decimal comparer, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(double val, string key, decimal comparer, string property, string message)
        {
            if (val < (double)comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(float val, string key, decimal comparer, string property, string message)
        {
            if (val < (float)comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(long val, string key, decimal comparer, string property, string message)
        {
            if (val < (float)comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(int val, string key, decimal comparer, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion IsGreaterOrEqualsThan

        #region IsLowerThan

        public EntityBase IsLowerThan(decimal val, string key, decimal comparer, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(double val, string key, decimal comparer, string property, string message)
        {
            if (val >= (double)comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(float val, string key, decimal comparer, string property, string message)
        {
            if (val >= (float)comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(long val, string key, decimal comparer, string property, string message)
        {
            if (val >= (float)comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(int val, string key, decimal comparer, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion IsLowerThan

        #region IsLowerOrEqualsThan

        public EntityBase IsLowerOrEqualsThan(decimal val, string key, decimal comparer, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(double val, string key, decimal comparer, string property, string message)
        {
            if (val > (double)comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(float val, string key, decimal comparer, string property, string message)
        {
            if (val > (float)comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(long val, string key, decimal comparer, string property, string message)
        {
            if (val > (float)comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(int val, string key, decimal comparer, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion IsLowerOrEqualsThan

        #region AreEquals

        public EntityBase AreEquals(decimal val, string key, decimal comparer, string property, string message)
        {
            if (val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(double val, string key, decimal comparer, string property, string message)
        {
            if (val != (double)comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(float val, string key, decimal comparer, string property, string message)
        {
            if (val != (float)comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(long val, string key, decimal comparer, string property, string message)
        {
            if (val != (float)comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(int val, string key, decimal comparer, string property, string message)
        {
            if (val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion AreEquals

        #region AreNotEquals

        public EntityBase AreNotEquals(decimal val, string key, decimal comparer, string property, string message)
        {
            if (val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(double val, string key, decimal comparer, string property, string message)
        {
            if (val == (double)comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(float val, string key, decimal comparer, string property, string message)
        {
            if (val == (float)comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(long val, string key, decimal comparer, string property, string message)
        {
            if (val == (float)comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(int val, string key, decimal comparer, string property, string message)
        {
            if (val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion AreNotEquals

        #region Between

        public EntityBase IsBetween(decimal val, string key, decimal from, decimal to, string property, string message)
        {
            if (!(val >= from && val <= to))
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion Between

        public EntityBase IsNullOrNullable(decimal? val, string key, string property, string message)
        {
            if (val == null || !val.HasValue)
            {
                AddNotification(key, property, message);
            }

            return this;
        }
    }
}
