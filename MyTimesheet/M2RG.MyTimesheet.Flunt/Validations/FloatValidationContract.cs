namespace M2RG.MyTimesheet.Flunt.Validations
{
    public partial class EntityBase
    {
        #region IsGreaterThan

        public EntityBase IsGreaterThan(decimal val, float comparer, string key, string property, string message)
        {
            if ((double)val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(double val, float comparer, string key, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(float val, float comparer, string key, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(long val, float comparer, string key, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(int val, float comparer, string key, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion IsGreaterThan

        #region IsGreaterOrEqualsThan

        public EntityBase IsGreaterOrEqualsThan(decimal val, float comparer, string key, string property, string message)
        {
            if ((double)val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(double val, float comparer, string key, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(float val, float comparer, string key, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(long val, float comparer, string key, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(int val, float comparer, string key, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion IsGreaterOrEqualsThan

        #region IsLowerThan

        public EntityBase IsLowerThan(decimal val, float comparer, string key, string property, string message)
        {
            if ((double)val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(double val, float comparer, string key, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(float val, float comparer, string key, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(long val, float comparer, string key, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(int val, float comparer, string key, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion IsLowerThan

        #region IsLowerOrEqualsThan

        public EntityBase IsLowerOrEqualsThan(decimal val, float comparer, string key, string property, string message)
        {
            if ((double)val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(double val, float comparer, string key, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(float val, float comparer, string key, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(long val, float comparer, string key, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(int val, float comparer, string key, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion IsLowerOrEqualsThan

        #region AreEquals

        public EntityBase AreEquals(decimal val, float comparer, string key, string property, string message)
        {
            if ((double)val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(double val, float comparer, string key, string property, string message)
        {
            if (val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(float val, float comparer, string key, string property, string message)
        {
            if (val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(long val, float comparer, string key, string property, string message)
        {
            if (val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(int val, float comparer, string key, string property, string message)
        {
            if (val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion AreEquals

        #region AreNotEquals

        public EntityBase AreNotEquals(decimal val, float comparer, string key, string property, string message)
        {
            if ((double)val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(double val, float comparer, string key, string property, string message)
        {
            if (val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(float val, float comparer, string key, string property, string message)
        {
            if (val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(long val, float comparer, string key, string property, string message)
        {
            if (val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(int val, float comparer, string key, string property, string message)
        {
            if (val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion AreNotEquals

        #region Between

        public EntityBase IsBetween(float val, float from, float to, string key, string property, string message)
        {
            if (!(val >= from && val <= to))
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        #endregion Between

        public EntityBase IsNullOrNullable(float? val, string key, string property, string message)
        {
            if (val == null || !val.HasValue)
            {
                AddNotification(key, property, message);
            }

            return this;
        }
    }
}
