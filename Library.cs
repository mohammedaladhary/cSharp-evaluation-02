using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace evaluation_02
{
    internal class Library
    {
        private List<Book> books;
        private List<LibraryMembers> members;

        public Library()
        {
            books = new List<Book>();
            members = new List<LibraryMembers>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("book added to the library");
        }

        public void AddLibraryMember(LibraryMembers member)
        {
            members.Add(member);
        }

        public void DisplayAllBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books in the library.");
            }
            else
            {
                Console.WriteLine("Books available in the library:");
                foreach (var book in books)
                {
                    Console.WriteLine("Title :" + book.Title, "Author :" + book.Author , "Available Copies :" +book.AvailableCopies);
                }
            }
        }
        public void DisplayAllLibraryMembers()
        {
            Console.WriteLine("Library Members Detail:");
            Console.WriteLine();
            foreach (LibraryMembers member in members)
            {
                member.MemberDetails();
                Console.WriteLine();
            }
        }
    }
}
