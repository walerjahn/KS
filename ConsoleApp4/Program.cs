using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AhoCorasick;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            string textfile = "";

            using (StreamReader fs = new StreamReader(@"C:\Новая папка\1.txt"))
            {
                while (true)
                {
                   string temp = fs.ReadLine();
                    if (temp == null) break;
                    textfile += temp +':';
                }
            }
        
        Console.WriteLine(textfile);

            Console.ReadKey();
            AhoCorasick.Trie trie = new AhoCorasick.Trie();
            trie.Add("string");
            trie.Build();
            string[] matches = trie.Find(textfile).ToArray();
            foreach (var item in matches)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
        }
    }
}
