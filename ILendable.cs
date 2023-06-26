using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluation_02
{
    internal interface ILendable
    {
        void borrowBook();
        void returnBook();
    }

    public class Book : ILendable
    {
        public string ISBN { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int AvailableCopies { get; private set; }

        public Book(string isbn, string title, string author, int availableCopies)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            AvailableCopies = availableCopies;
        }

        public void BookDetails()
        {
            Console.WriteLine("Book Details:");
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Available Copies: " + AvailableCopies);
        }

        public void borrowBook()
        {
            if (AvailableCopies > 0)
            {
                AvailableCopies--;
                Console.WriteLine("Book borrowed successfully.");
            }
            else
            {
                Console.WriteLine("Book is not available for borrowing.");
            }
        }

        public void returnBook()
        {
            AvailableCopies++;
            Console.WriteLine("Book returned successfully.");
        }
    }
}
