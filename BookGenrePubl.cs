using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_2
{
    public class BookGenrePubl:BookGenre
    {
        private string publisher;

        public BookGenrePubl(string title, string author, double price, string genre, string publisher) : base(title, author, price, genre)
        {
            this.publisher = publisher;
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Издатель: {publisher}");
        }
    }
}