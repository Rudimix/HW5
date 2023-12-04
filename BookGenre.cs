using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_2
{
    public class BookGenre: Book
    {
        private string genre;

        public BookGenre(string title, string author, double price, string genre) : base(title, author, price)
        {
            this.genre = genre;
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Жанр: {genre}");
        }
    }
}