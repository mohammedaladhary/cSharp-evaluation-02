using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluation_02
{ 
    internal class LibraryMembers
    {
        public string MemberId { get; private set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNo { get; private set; }
        public List<Book> BorrowedBooks { get; private set; }

        public LibraryMembers(string memberId, string name, string address, int phoneNo)
        {
            MemberId = memberId;
            Name = name;
            Address = address;
            PhoneNo = phoneNo;
            BorrowedBooks = new List<Book>();
        }
        public void MemberDetails()
        {
            Console.WriteLine(Name + " Member Details:");
            Console.WriteLine("ID: " + MemberId);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("PhoneNo: " + PhoneNo);
            //Console.WriteLine("BorrowedBooks: " + BorrowBook);
        }
        public void BorrowBook(Book book)
        {
            if (book.AvailableCopies > 0)
            {
                BorrowedBooks.Add(book);
                book.borrowBook(); // Call the BorrowBook() method from the Book class
                Console.WriteLine("Book borrowed successfully.");
            }
            else
            {
                Console.WriteLine("Book is not available for borrowing.");
            }
        }

        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                book.returnBook(); // Call the ReturnBook() method from the Book class
                Console.WriteLine("Book returned successfully.");
            }
            else
            {
                Console.WriteLine("Book is not borrowed by this member.");
            }
        }
    }
}
