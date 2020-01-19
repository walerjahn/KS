using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AhoCorasick;
namespace UnitTestProject3
{
    [TestClass]
    public class LABA3
    {
        [TestMethod]
        public void Find()
        {
            string[] text = "string my string no afaffaseds yes find yes".Split(' ');

            AhoCorasick.Trie<string, bool> trie = new AhoCorasick.Trie<string, bool>();
            trie.Add(new[] { "string" }, true);
            trie.Build();

            Assert.IsTrue(trie.Find(text).Any());
        }
        [TestMethod]
        public void Findtwo()
        {
            string[] text = "string my string my no afaffaseds yes find yes".Split(' ');

            AhoCorasick.Trie<string, bool> trie = new AhoCorasick.Trie<string, bool>();
            trie.Add(new[] { "string", "my"}, true);
            trie.Build();

            Assert.IsTrue(trie.Find(text).Any());

        }
        [TestMethod]
        public void FindNo()
        {
            string[] text = "string my string my no afaffaseds yes find yes".Split(' ');

            AhoCorasick.Trie<string, bool> trie = new AhoCorasick.Trie<string, bool>();
            trie.Add(new[] { "" }, true);
            trie.Build();

            Assert.IsFalse(trie.Find(text).Any());


        }
    }
    }

