using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlg2
{
    public class TrieNode
    {
        public char Val { get; set; }
        public List<TrieNode> Children { get; set; }
        public TrieNode(char v)
        {
            Val = v;
            Children = new List<TrieNode>();
        }
    }
    public class Trie
    {
        public TrieNode Root { get; set; }
        public const char StartKey = '*';
        public const char EndKey = '~';
        public Trie(ISet<string> setWords)
        {
            this.Root = new TrieNode(StartKey);
            foreach (var w in setWords)
            {
                AddWord(this.Root,w);
            }
        }
        public void AddWord(TrieNode root,string word)
        {
            AddWord(root, word, 0);
        }
        public void AddWord(TrieNode root, string word,int index)
        {
            if(index < word.Length)
            {
                TrieNode childMatching = this.GetChildMatching(root, word[index]);
                if (childMatching == null)
                {
                    childMatching = new TrieNode(word[index]);
                    root.Children.Add(childMatching);
                }
                if (index == word.Length - 1 && !this.HasEnd(childMatching))
                {
                    childMatching.Children.Add(new TrieNode(EndKey));
                }
                AddWord(childMatching, word, index + 1);
            }
        }
        public bool HasEnd(TrieNode root)
        {
            foreach(var c in root.Children)
            {
                if(c.Val == EndKey)
                {
                    return true;
                }
            }
            return false;
        }
        public TrieNode GetChildMatching(TrieNode root,char c)
        {
            foreach (var child in root.Children)
            {
                if (child.Val == c)
                {
                    return child;
                }
            }
            return null;
        }

    }
}
