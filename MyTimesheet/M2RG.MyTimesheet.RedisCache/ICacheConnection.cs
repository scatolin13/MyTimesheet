using System;
using System.Collections.Generic;

namespace M2RG.MyTimesheet.RedisCache
{
    public interface ICacheConnection : IDisposable
    {
        bool ExistsCache(string key);
        T AddCache<T>(string key, T entity) where T : class;
        T AddListLast<T>(string key, T entity) where T : class;
        T AddListFirst<T>(string key, T entity) where T : class;
        List<T> GetRange<T>(string key) where T : class;
        T Get<T>(string key) where T : class;
        bool Remove(string key);
        T UpdateSession<T>(string key, T entity) where T : class;
        void Refresh(string key);
        TimeSpan? TimeToLive(string key);
    }
}
