using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static volatile Singleton Instance;
        private static object m_lock = new object();

        private Singleton()
        {
            Fields = new Dictionary<string, object>();
        }

        public static Singleton GetInstance()
        {
            lock (m_lock)
            {
                if (Instance == null)
                {
                    Instance = new Singleton();
                }
            }
            return Instance;
        }

        public Dictionary<string, object> Fields { get; set; }
    }
}
