using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;

namespace M2RG.MyTimesheet.RedisCache
{
    public class CacheConnection : ICacheConnection
    {
        private readonly IDatabase _cache;
        private readonly int expireTime;
        private readonly Dictionary<string, string> exceptions;

        public CacheConnection(CacheParameters dbParms)
        {
            try
            {
                exceptions = new Dictionary<string, string>();

                var conn = ConnectionMultiplexer.Connect(dbParms.ConnectionString);

                expireTime = dbParms.CacheExpireTime;
                _cache = conn.GetDatabase(dbParms.DbCache != DBCacheIndex.BlackList ? (int)dbParms.DbCache + dbParms.CacheDBEnvironment : (int)dbParms.DbCache);
            }
            catch (RedisServerException ex)
            {
                exceptions.Add("Server", ex.Message);
                exceptions.Add("Server", ex.StackTrace);
            }
            catch (RedisConnectionException ex)
            {
                exceptions.Add("Connection", ex.Message);
                exceptions.Add("Connection", ex.StackTrace);
            }
            catch (TimeoutException ex)
            {
                exceptions.Add("Timeout", ex.Message);
                exceptions.Add("Timeout", ex.StackTrace);
            }
            catch (Exception ex)
            {
                exceptions.Add("Exception", ex.Message);
                exceptions.Add("Exception", ex.StackTrace);
            }
        }

        public bool ExistsCache(string key)
        {
            bool exist = false;
            try
            {
                exist = _cache.KeyExists(key);
            }
            catch (Exception ex)
            {
                exceptions.Add("Exception", ex.Message);
                exceptions.Add("Exception", ex.StackTrace);
            }

            return exist;
        }

        public T AddCache<T>(string key, T entity) where T : class
        {
            try
            {
                string value = SerializeObject(entity);
                _cache.StringSet(key, value, TimeSpan.FromMinutes(expireTime));
            }
            catch (Exception ex)
            {
                exceptions.Add("Exception", ex.Message);
                exceptions.Add("Exception", ex.StackTrace);
            }

            return entity;
        }

        public T AddListLast<T>(string key, T entity) where T : class
        {
            try
            {
                string value = SerializeObject(entity);
                _cache.ListRightPush(key, value);
            }
            catch (Exception ex)
            {
                exceptions.Add("Exception", ex.Message);
                exceptions.Add("Exception", ex.StackTrace);
            }
            return entity;
        }

        public T AddListFirst<T>(string key, T entity) where T : class
        {
            try
            {
                string value = SerializeObject(entity);
                _cache.ListLeftPush(key, value);
            }
            catch (Exception ex)
            {
                exceptions.Add("Exception", ex.Message);
                exceptions.Add("Exception", ex.StackTrace);
            }
            return entity;
        }

        public List<T> GetRange<T>(string key) where T : class
        {
            var list = new List<T>();

            try
            {
                var value = _cache.ListRange(key);

                foreach (var item in value)
                {
                    list.Add(DeserializeObject<T>(item));
                }
            }
            catch (Exception ex)
            {
                exceptions.Add("Exception", ex.Message);
                exceptions.Add("Exception", ex.StackTrace);
            }

            return list;
        }

        public T Get<T>(string key) where T : class
        {
            T ret = null;

            try
            {
                string value = _cache.StringGet(key);
                if (!string.IsNullOrEmpty(value))
                    return DeserializeObject<T>(value);
            }
            catch (Exception ex)
            {
                exceptions.Add("Exception", ex.Message);
                exceptions.Add("Exception", ex.StackTrace);
            }

            return ret;
        }

        public bool Remove(string key)
        {
            bool removed = false;
            try
            {
                removed = _cache.KeyDelete(key);
            }
            catch (Exception ex)
            {
                exceptions.Add("Exception", ex.Message);
                exceptions.Add("Exception", ex.StackTrace);
            }

            return removed;
        }

        public T UpdateSession<T>(string key, T entity) where T : class
        {
            T ret = null;

            try
            {
                ret = AddCache(key, entity);
            }
            catch (Exception ex)
            {
                exceptions.Add("Exception", ex.Message);
                exceptions.Add("Exception", ex.StackTrace);
            }

            return ret;
        }

        public void Refresh(string key)
        {
            try
            {
                _cache.KeyExpire(key, TimeSpan.FromMinutes(expireTime));
            }
            catch (Exception ex)
            {
                exceptions.Add("Exception", ex.Message);
                exceptions.Add("Exception", ex.StackTrace);
            }
        }

        public TimeSpan? TimeToLive(string key)
        {
            TimeSpan? timeSpan = null;

            try
            {
                timeSpan = _cache.KeyTimeToLive(key);
            }
            catch (Exception ex)
            {
                exceptions.Add("Exception", ex.Message);
                exceptions.Add("Exception", ex.StackTrace);
            }

            return timeSpan;
        }

        private string SerializeObject<T>(T entity)
        {
            string obj = "";

            try
            {
                obj = JsonConvert.SerializeObject(entity);
            }
            catch (Exception ex)
            {
                exceptions.Add("Exception", ex.Message);
                exceptions.Add("Exception", ex.StackTrace);
            }

            return obj;
        }

        private T DeserializeObject<T>(string value) where T : class
        {
            T ret = null;

            try
            {
                ret = JsonConvert.DeserializeObject<T>(value);
            }
            catch (Exception ex)
            {
                exceptions.Add("Exception", ex.Message);
                exceptions.Add("Exception", ex.StackTrace);
            }

            return ret;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
        }
    }
}
