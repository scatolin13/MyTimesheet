using System;
using System.Collections.Generic;
using System.Text;

namespace M2RG.MyTimesheet.Flunt.Validations
{
    public partial class EntityBase
    {
        #region IsGreaterThan
        public EntityBase IsGreaterThan(decimal val, int comparer, string key, string property, string message)
        {
            if ((double)val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(double val, int comparer, string key, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(float val, int comparer, string key, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(long val, int comparer, string key, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterThan(int val, int comparer, string key, string property, string message)
        {
            if (val <= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }
        #endregion

        #region IsGreaterOrEqualsThan
        public EntityBase IsGreaterOrEqualsThan(decimal val, int comparer, string key, string property, string message)
        {
            if ((double)val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(double val, int comparer, string key, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(float val, int comparer, string key, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(long val, int comparer, string key, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsGreaterOrEqualsThan(int val, int comparer, string key, string property, string message)
        {
            if (val < comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }
        #endregion

        #region IsLowerThan
        public EntityBase IsLowerThan(decimal val, int comparer, string key, string property, string message)
        {
            if ((double)val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(double val, int comparer, string key, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(float val, int comparer, string key, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(long val, int comparer, string key, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerThan(int val, int comparer, string key, string property, string message)
        {
            if (val >= comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }
        #endregion

        #region IsLowerOrEqualsThan
        public EntityBase IsLowerOrEqualsThan(decimal val, int comparer, string key, string property, string message)
        {
            if ((double)val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(double val, int comparer, string key, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(float val, int comparer, string key, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(long val, int comparer, string key, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase IsLowerOrEqualsThan(int val, int comparer, string key, string property, string message)
        {
            if (val > comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }
        #endregion

        #region AreEquals
        public EntityBase AreEquals(decimal val, int comparer, string key, string property, string message)
        {
            if ((double)val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(double val, int comparer, string key, string property, string message)
        {
            if (val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(float val, int comparer, string key, string property, string message)
        {
            if (val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(long val, int comparer, string key, string property, string message)
        {
            if (val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreEquals(int val, int comparer, string key, string property, string message)
        {
            if (val != comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }
        #endregion

        #region AreNotEquals
        public EntityBase AreNotEquals(decimal val, int comparer, string key, string property, string message)
        {
            if ((double)val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(double val, int comparer, string key, string property, string message)
        {
            if (val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(float val, int comparer, string key, string property, string message)
        {
            if (val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(long val, int comparer, string key, string property, string message)
        {
            if (val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }

        public EntityBase AreNotEquals(int val, int comparer, string key, string property, string message)
        {
            if (val == comparer)
            {
                AddNotification(key, property, message);
            }

            return this;
        }
        #endregion

        #region Between      
        public EntityBase IsBetween(int val, int from, int to, string key, string property, string message)
        {
            if (!(val >= from && val <= to))
            {
                AddNotification(key, property, message);
            }

            return this;
        }
        #endregion

        public EntityBase IsNotNullOrNullable(int? val, string key, string property, string message)
        {
            if (val == null || !val.HasValue)
            {
                AddNotification(key, property, message);
            }

            return this;
        }
    }
}
