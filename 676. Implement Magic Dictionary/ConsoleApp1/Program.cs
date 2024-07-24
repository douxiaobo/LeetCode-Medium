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
    }
    public class MagicDictionary
    {
        class TrieNode
        {
            public TrieNode[] children;
            public bool isWord;
            public TrieNode()
            {
                children = new TrieNode[26];
            }
        }
        TrieNode root;

        public MagicDictionary()
        {
            root = new TrieNode();
        }

        public void BuildDict(string[] dictionary)
        {
            foreach (string word in dictionary)
            {
                TrieNode node = root;
                foreach (char ch in word.ToCharArray())
                {
                    if (node.children[ch - 'a'] == null)
                    {
                        node.children[ch - 'a'] = new TrieNode();
                    }
                    node = node.children[ch - 'a'];
                }
                node.isWord = true;
            }
        }

        public bool Search(string searchWord)
        {
            return dfs(root, searchWord, 0, 0);
        }
        private bool dfs(TrieNode root, string word, int i, int edit)
        {
            if (root == null)
            {
                return false;
            }
            if (root.isWord && i == word.Length && edit == 1)
            {
                return true;
            }
            if (i < word.Length && edit <= 1)
            {
                bool found = false;
                for (int j = 0; j < 26 && !found; j++)
                {
                    int next = j == word[i] - 'a' ? edit : edit + 1;
                    found = dfs(root.children[j], word, i + 1, next);
                }
                return found;
            }
            return false;
        }
    }
}
