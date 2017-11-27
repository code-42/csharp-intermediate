using System;
using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        // Indexer is an easy way to access elements in Dictionary
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        // Indexer
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}