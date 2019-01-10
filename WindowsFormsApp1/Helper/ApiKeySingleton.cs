using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Libraries
{
    public sealed class Singleton
    {
        private static Singleton instance;
        private static readonly Lazy<Singleton> lazy =
            new Lazy<Singleton>(() => new Singleton());

        private string API_KEY; 

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        private Singleton()
        {
            API_KEY = String.Empty;
        }

        public void Set(string key)
        {
            API_KEY = key;
        }

        public string Get()
        {
            return API_KEY;
        }
    }
}
