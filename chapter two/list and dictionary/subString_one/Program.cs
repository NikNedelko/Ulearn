using System;

namespace subString_one
{
    class hashOne
    {
        public static bool Equals(string text, string query, int index)
        {
            for (int i = 0; i < query.Length; i++)
                if (text[index + i] != query[i]) return false;
            return true;
        }
        /*
                public static int IndexOf(string text, string query){
                    for (int i = 0; i < text.Length-query.Length; i++)
                    if (Equals(text,query,i)) return i;
                    return -1;
                }
                */
        // ускоряем с помощью хеша
        public static int IndexOf(string text, string query)
        {
            if (text.Length < query.Length) return -1;
            var p = 1000;
            var texthash = 0;
            var queryHash = 0;
            for (int i = 0; i < query.Length; i++)
            {
                texthash = texthash * p + text[i];
                queryHash = queryHash * p + query[i];
            }
            if (texthash == queryHash)
            {
                if (Equals(text, query, 0))
                    return 0;
            }
            return -1;

        }
    }

    class hashTwo
    {
        public static bool Equals(string text, string query, int index)
        {
            for (int i = 0; i < query.Length; i++)
                if (text[index + i] != query[i]) return false;
            return true;
        }
        public static int IndexOf(string text, string query)
        {
            if (text.Length < query.Length) return -1;

            var p = 1000;
            var texthash = 0;
            var queryHash = 0;
            var maxPower = 1;
            for (int i = 0; i < query.Length; i++)
            {
                texthash = texthash * p + text[i];
                queryHash = queryHash * p + query[i];
                maxPower *= p;
            }
            maxPower /= p;
            
           for (int i = 0; ; i++)
           {
                if (texthash == queryHash)
                {
                    if (Equals(text, query, i))
                        return i;
                }
                if (i < text.Length - query.Length) break;
                texthash-=text[i]*maxPower;
                texthash = texthash*p+text[query.Length+i];
           }
            return -1;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
