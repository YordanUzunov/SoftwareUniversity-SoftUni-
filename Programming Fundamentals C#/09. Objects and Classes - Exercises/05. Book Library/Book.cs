using System;

public class Book
{
    private string title, author, publisher, isbn;
    private DateTime releaseDate;  

    public Book(string title, string author, string publisher, DateTime releaseDate, string isbn, double price)
    {
        this.title = title;
        this.author = author;
        this.publisher = publisher;
        this.releaseDate = releaseDate;
        this.isbn = isbn;
        this.Price = price;
    }

    public double Price { get; set; }

    public string Author { get { return this.author; } }

}

