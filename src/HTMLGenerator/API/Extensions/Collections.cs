using System.Collections.Generic;

namespace API.Extensions
{
    public static class Collections
    {
        public static void AddStyle(this Dictionary<string, string> styles, string attr, string value)
        {
            if (styles.ContainsKey(attr))
            {
                styles[attr] = value;
            }
            else
            {
                styles.Add(attr, value);
            }
        }
    }
}
