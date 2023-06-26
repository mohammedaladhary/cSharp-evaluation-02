using System;

internal class Book
{
    public string ISBN { get; private set; }
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int AvailableCopies { get; set; }

    public Book(string isbn, string title, string author, int availableCopies)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
        AvailableCopies = availableCopies;
    }
    public void BookDetails()
    {
        Console.WriteLine(Title + " Book Details:");
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Available Copies: " + AvailableCopies);
    }
    public void BorrowBook()
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

    public void ReturnBook()
    {
        AvailableCopies++;
        Console.WriteLine("Book returned successfully.");
    }
}

