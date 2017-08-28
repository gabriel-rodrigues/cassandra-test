using System;
using System.Collections.Concurrent;
using Cassandra;

namespace Core.CassandraConfig
{
    public class CassandraSessionCache
    {
        private readonly Cluster _cluster;
        private readonly ConcurrentDictionary<string, Lazy<ISession>> _sessions;

        public CassandraSessionCache()
        {
            _cluster = Cluster.Builder()
                .AddContactPoint("127.0.0.1")
                .WithPort(9042)
                .WithCredentials(" ", " ")
                .Build();
            
            _sessions = new ConcurrentDictionary<string, Lazy<ISession>>();
        }


        public ISession GetSession(string keySpaceName)
        {
            if (!_sessions.ContainsKey(keySpaceName))
            {
                _sessions.GetOrAdd(keySpaceName, key => new Lazy<ISession>(() => _cluster.Connect(key)));
            }

            var result = _sessions[keySpaceName];

            return result.Value;
        }
    }
}