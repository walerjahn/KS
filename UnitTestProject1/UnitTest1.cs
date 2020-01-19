using NUnit.Framework;
using System;
using System.IO;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void findsome()
        {


            string textfile = "";
            using (StreamReader fs = new StreamReader(@"C:\Новая папка\1.txt"))
            {
                while (true)
                {
                    string temp = fs.ReadLine();
                    if (temp == null) break;
                    textfile += temp;
                }
            }

            AhoCorasick.Trie trie = new AhoCorasick.Trie();
            trie.Add("hello");
            // trie.Add("word");
            trie.Build();

            string[] matches = trie.Find(textfile).ToArray();

            Assert.AreEqual(5, matches.Length);
            Assert.AreEqual("hello", matches[0]);
            // Assert.AreEqual("hellonull",matches[1]);
            // Assert.AreEqual("word", matches[1]);
        }

        [Test]
        public void Contains()
        {
            string text = "hello and welcome to this beautiful world!";

            AhoCorasick.Trie trie = new AhoCorasick.Trie();
            trie.Add("hello");
            trie.Add("world");
            trie.Build();

            Assert.IsTrue(trie.Find(text).Any());
        }

        [Test]
        public void LineNumbers()
        {
            string textfile = "";

            using (StreamReader fs = new StreamReader(@"C:\Новая папка\1.txt"))
            {
                while (true)
                {
                    string temp = fs.ReadLine();
                    if (temp == null) break;
                    textfile += temp;
                }
            }
            string[] words = new[] { "hello", "word" };

            AhoCorasick.Trie<int> trie = new AhoCorasick.Trie<int>();
            for (int i = 0; i < words.Length; i++)
                trie.Add(words[i], i);
            trie.Build();

            int[] lines = trie.Find(textfile).ToArray();

            Assert.AreEqual(5, lines.Length);
            // Assert.AreEqual(1, lines[0]);
            // Assert.AreEqual(1, lines[1]);
        }

        [Test]
        public void Words()
        {
            string[] text = "hello:hello:wor:ddsdsdf:word:hello".Split(':');

            AhoCorasick.Trie<string, bool> trie = new AhoCorasick.Trie<string, bool>();
            trie.Add(new[] { "wol" }, true);
            trie.Build();

            Assert.IsFalse(trie.Find(text).Any());
        }
    }
}