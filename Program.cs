using evaluation_02;
using System.Net.NetworkInformation;

namespace evaluation_02
{
    
    internal class Program
    {
        //Library Management System
        static void Main(string[] args)
        {
            // book object initiated
            Book book = new Book("11111", "The Great Wall", "Mohammed AL Adhary", 5);

            book.BookDetails();
            Console.WriteLine("--------------------------------------------");
            book.borrowBook();
            Console.WriteLine("Available Copies: " + book.AvailableCopies);
            Console.WriteLine();
            book.returnBook();
            Console.WriteLine("Available Copies: " + book.AvailableCopies);
            Console.WriteLine("--------------------------------------------");

            //// LibraryMember object initiated
            LibraryMembers member = new LibraryMembers("M6499", "khalifa", "souq seeb street", 9236253);

            member.MemberDetails();
            Console.WriteLine("--------------------------------------------");

            //borrow/return book and call the member details
            member.BorrowBook(book);
            Console.WriteLine("Available Copies: " + book.AvailableCopies);
            Console.WriteLine();
            member.ReturnBook(book);
            Console.WriteLine("Available Copies: " + book.AvailableCopies);
            Console.WriteLine("--------------------------------------------");

            Library bookShop = new Library();

            Book book2 = new Book("9876543210", "how to sleep well", "Harper Lee", 3);
            bookShop.AddBook(book);
            bookShop.AddBook(book2);
            // Add the books to the bookShop library
            //book.BookDetails();
            //Console.WriteLine();
            //bookShop.AddBook(book);
            //Console.WriteLine("-------------");
            //book2.BookDetails();
            //Console.WriteLine();
            //bookShop.AddBook(book2);

            // Create some LibraryMember objects
            LibraryMembers member1 = new LibraryMembers("C321", "Ahmed", "Barka Street", 8273526);
            LibraryMembers member2 = new LibraryMembers("H821", "Omran", "Ibri Street", 1243727);
            bookShop.AddLibraryMember(member1);
            bookShop.AddLibraryMember(member2);
            Console.WriteLine("------------------");
            // Display all members/books in the bookShop
            bookShop.DisplayAllLibraryMembers();
            bookShop.DisplayAllBooks();

            // Member1 borrows book2
            //bookShop.BorrowBook(member1, book2);

            // Member1 returns book2
            ////bookShop.ReturnBook(member1, book2);
            //Console.WriteLine("---------------------------------------------");

            ////by using interface ILendable
            //Book specialBook = new Book("S213","End of the Chapter","Ammar",3);
            //specialBook.BookDetails();
            //specialBook.borrowBook();
            //specialBook.returnBook();
        }
    }
}