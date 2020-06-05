namespace M2RG.MyTimesheet.RedisCache
{
    public class CacheParameters
    {
        public DBCacheIndex DbCache { get; set; }
        public string ConnectionString { get; set; }
        public int CacheDBEnvironment { get; set; }
        public int CacheExpireTime { get; set; }

    }

    public enum DBCacheIndex
    {
        DB1 = 0,
        DB2 = 1,
        DB3 = 2,
        DB4 = 3,
        DB5 = 4,
        BlackList = 15
    }
}
