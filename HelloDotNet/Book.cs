using System;

class Book
{
    public string Title;
    public string Author;
    public int PageCount;
    public bool IsFiction;

    public Book(string title, string author, int pageCount, bool isFiction)
    {
        Title = title;
        Author = author;
        PageCount = pageCount;
        IsFiction = isFiction;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Page count: {PageCount}");
        Console.WriteLine($"Is fiction: {IsFiction}");
    }

    public bool isLong()
    {
        if (PageCount > 300)
            return true;
        return false;
    }
}
