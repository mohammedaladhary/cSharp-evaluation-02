using System;
using System.Collections.Generic;
using System.Linq;
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
        }

        public void AddLibraryMember(LibraryMembers member)
        {
            members.Add(member);
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("All Books in the Library:");
            foreach (Book book in books)
            {
                book.BookDetails();
                Console.WriteLine();
            }
        }

        public void DisplayAllLibraryMembers()
        {
            Console.WriteLine("All Library Members:");
            foreach (LibraryMembers member in members)
            {
                member.MemberDetails();
                Console.WriteLine();
            }
        }
    }
}
