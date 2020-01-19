using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AhoCorasick;
namespace UnitTestProject2
{
    [TestClass]
    public class LABA2
    {
        [TestMethod]
        public void SingleString()
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
            trie.Add("STRING");

            trie.Build();

            string[] matches = trie.Find(textfile).ToArray();

            Assert.AreEqual(1, matches.Length);
            Assert.AreEqual("STRING", matches[0]);

        }
        
        [TestMethod]
        public void MultiString()
        { 
        string textfile = "";
            using (StreamReader fs = new StreamReader(@"C:\Новая папка\2.txt"))
            {
                while (true)
                {
                    string temp = fs.ReadLine();
                    if (temp == null) break;
                    textfile += temp;
                }
            }


         

            AhoCorasick.Trie trie = new AhoCorasick.Trie();
            trie.Add("STRING1");
            trie.Add("STRING2");
            trie.Build();

            string[] matches = trie.Find(textfile).ToArray();

Assert.AreEqual(2, matches.Length);
            Assert.AreEqual("STRING1", matches[0]);
            Assert.AreEqual("STRING2", matches[1]);
        }

        [TestMethod]
        public void NoString()
        { 
        string textfile = "";
            using (StreamReader fs = new StreamReader(@"C:\Новая папка\3.txt"))
            {
                while (true)
                {
                    string temp = fs.ReadLine();
                    if (temp == null) break;
                    textfile += temp;
                }
            }


         

            AhoCorasick.Trie trie = new AhoCorasick.Trie();
trie.Add("NONONO");
            trie.Build();

            string[] matches = trie.Find(textfile).ToArray();

Assert.AreEqual(0, matches.Length);
           
        }

    }
        }
