using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            foreach (string str in strs)
            {
                char[] chs = str.ToCharArray();
                Array.Sort(chs);
                string key = new string(chs);
                if (!dict.ContainsKey(key))
                {
                    dict[key] = new List<string>();
                }
                dict[key].Add(str);
            }
            IList<IList<string>> result = new List<IList<string>>();
            foreach (List<string> value in dict.Values)
            {
                result.Add(value);
            }
            return result;
        }//Runtime:185 ms Beats:82.28% Memory:61.3 MB Beats:43.71%
        public IList<IList<string>> GroupAnagrams1(string[] strs)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            foreach (string str in strs)
            {
                char[] chs = str.ToCharArray();
                Array.Sort(chs);
                string key = new string(chs);
                if (!dict.ContainsKey(key))
                {
                    dict[key] = new List<string>();
                }
                dict[key].Add(str);
            }
            return new List<IList<string>>(dict.Values);
        }//Runtime:176 ms Beats:96.11% Memory:61.1 MB Beats:53.97%
        public IList<IList<string>> GroupAnagrams2(string[] strs)
        {
            int[] hash = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 63, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101 };
            Dictionary<long, List<string>> groups = new Dictionary<long, List<string>>();
            foreach (string str in strs)
            {
                long wordHash = 1;
                for (int i = 0; i < str.Length; i++)
                {
                    wordHash *= hash[str[i] - 'a'];
                }
                if (!groups.ContainsKey(wordHash))
                {
                    groups[wordHash] = new List<string>();
                }
                groups[wordHash].Add(str);
            }
            return new List<IList<string>>(groups.Values);
        }
    }
}
