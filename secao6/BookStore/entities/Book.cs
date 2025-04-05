using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.entities
{
    public struct Book
    {
        public string Title { get;}
        public int YearRelease { get;}
        public double Price { get;}
        public string Author { get;}
        public int Quantity { get;}

        public Book(string title, int yearRelease, string author, double price, int quantity) => (Title, YearRelease, Author, Price, Quantity) = (title, yearRelease, author, price, quantity);

        public double ValueTotalInStock(){
            return Price * Quantity;
        }

        override public string ToString() => $"Book: {Title} - {Author}({YearRelease}): {Price}";
        }
}