using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> books = new MyDictionary<string>();

            books.Add("Tekvin");
            books.Add("Patasana");
            books.Add("Kaşağı");
            books.Add("Sefiller");
            Console.WriteLine("Kitaplar");
            Console.WriteLine("-----------------");

            foreach (var book in books.Items)
            {
                
                Console.WriteLine(book);
            }
            
            MyDictionary<int> pages = new MyDictionary<int>();

            pages.Add(350);
            pages.Add(268);
            pages.Add(154);
            pages.Add(745);
            Console.WriteLine("-----------------");
            Console.WriteLine("Sayfaları");
            Console.WriteLine("-----------------");

            foreach (var page in pages.Items)
            {              
                Console.WriteLine(page);
            }

        }
    }
}