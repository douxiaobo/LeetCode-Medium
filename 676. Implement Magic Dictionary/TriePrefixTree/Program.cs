using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriePrefixTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();
            trie.Insert("hello");
            trie.Insert("world");
            Console.WriteLine(trie.Search("hello")); // true
            Console.WriteLine(trie.Search("world")); // true
            Console.WriteLine(trie.Search("hi")); // false
            Console.WriteLine(trie.StartsWith("he")); // true
            Console.WriteLine(trie.StartsWith("w")); // true
            Console.ReadKey();
        }
    }
    public class TrieNode
    {
        public char val;
        public bool isWord;
        public Dictionary<char, TrieNode> children;

        public TrieNode(char c)
        {
            val = c;
            isWord = false;
            children = new Dictionary<char, TrieNode>();
        }
    }

    public class Trie
    {
        private TrieNode root;

        public Trie()
        {
            root = new TrieNode(' ');
        }

        public void Insert(string word)
        {
            TrieNode curr = root;
            foreach (char c in word)
            {
                if (!curr.children.ContainsKey(c))
                {
                    curr.children.Add(c, new TrieNode(c));
                }
                curr = curr.children[c];
            }
            curr.isWord = true;
        }

        public bool Search(string word)
        {
            TrieNode curr = root;
            foreach (char c in word)
            {
                if (!curr.children.ContainsKey(c))
                {
                    return false;
                }
                curr = curr.children[c];
            }
            return curr.isWord;
        }

        public bool StartsWith(string prefix)
        {
            TrieNode curr = root;
            foreach (char c in prefix)
            {
                if (!curr.children.ContainsKey(c))
                {
                    return false;
                }
                curr = curr.children[c];
            }
            return true;
        }
    }
}
