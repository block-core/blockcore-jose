using System;
using System.Collections.Generic;
using System.Linq;

namespace Blockcore.Jose
{
    public class Dictionaries
    {
        /// <summary>
        /// Appends `other` key/value pairs to 'src'. Conflicting keys are not appended (e.g. 'src' keys has priority).
        /// Operation in mutable, 'src' modified as result. Null safe operation.
        /// </summary>
        public static void Append<K, V>(IDictionary<K, V> src, IDictionary<K, V> other)
        {
            if (src!=null && other != null)
            {
                foreach (var pair in other.Where(pair => !src.ContainsKey(pair.Key)))
                {
                    src.Add(pair);
                }
            }
        }

        /// <summary>
        /// Syntax sugar for IDictionary.TryGetValue() to lookup unknown keys.
        /// </summary>
        public static V Get<K, V>(IDictionary<K, V> src, K key)
        {
            V value;
            src.TryGetValue(key, out value);

            return value;
        }
    }
}