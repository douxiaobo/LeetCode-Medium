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
            Solution solution = new Solution();
            List<string> list= new List<string>(solution.RestoreIpAddresses("101023"));
            foreach(string ip in list) { Console.WriteLine(ip); }
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            List<string> result = new List<string>();
            helper(s, 0, 0, "", "", result);
            return result;
        }
        private void helper(string s, int i, int segI, string seg, string ip, List<string> result)
        {
            if (i == s.Length && segI == 3 && isValidSeg(seg))
            {
                result.Add(ip + seg);
            }
            else if (i < s.Length && segI <= 3)
            {
                char ch = s[i];
                if (isValidSeg(seg + ch))
                {
                    helper(s, i + 1, segI, seg + ch, ip, result);
                }
                if (seg.Length > 0 && segI < 3)
                {
                    helper(s, i + 1, segI + 1, "" + ch, ip + seg + ".", result);
                }
            }
        }
        private bool isValidSeg(string seg)
        {
            return int.Parse(seg) <= 255 && (seg == "0" || seg[0] != '0');
        }
    }
}
