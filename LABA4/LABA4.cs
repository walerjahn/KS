using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AhoCorasick;

    [TestClass]
    public class LABA4
    {
        [TestMethod]
    
     
 
            public void String()
            {
                string text = "string and stringa ta fsd fafad string!";

                AhoCorasick.Trie trie = new AhoCorasick.Trie();
                trie.Add("string");
                trie.Add("and");
                trie.Build();

                trie.Add("NONONO");
                trie.Add("NaNaNa");
                trie.Build();

        string[] matches = trie.Find(text).ToArray();
    }

            [TestMethod]
            public void Contains()
            {
                string text = "string and stringa ta fsd fafad string!";

                AhoCorasick.Trie trie = new AhoCorasick.Trie();
                trie.Add("sring");
                trie.Add("stringa");
                trie.Build();

                Assert.IsTrue(trie.Find(text).Any());
            }

            [TestMethod]
            public void LineNumbers()
            {
                string text = "stringa, and and stringb!";
                string[] words = new[] { "stringb", "stringa" };

                AhoCorasick.Trie<int> trie = new AhoCorasick.Trie<int>();
                for (int i = 0; i < words.Length; i++)
                    trie.Add(words[i], i);
                trie.Build();

                int[] lines = trie.Find(text).ToArray();

                Assert.AreEqual(2, lines.Length);
                Assert.AreEqual(1, lines[0]);
                Assert.AreEqual(0, lines[1]);
            }

            [TestMethod]
            public void Words()
            {
                string[] text = "string1 string2 string3".Split(' ');

                AhoCorasick.Trie<string, bool> trie = new AhoCorasick.Trie<string, bool>();
                trie.Add(new[] { "string1", "string2" }, true);
                trie.Build();

                Assert.IsTrue(trie.Find(text).Any());
            }
        }
    
