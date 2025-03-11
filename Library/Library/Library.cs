using System;
using System.Collections.Generic;

public class Library
{
    private List<Book> books = new();

    public void Add(string title, string author) => books.Add(new Book(title, author));
    public void Show() => books.ForEach(b => Console.WriteLine(b));
    public void Search(string title) => books.FindAll(b => b.Title.Contains(title)).ForEach(b => Console.WriteLine(b));
    public void Filter(string author) => books.FindAll(b => b.Author.Contains(author)).ForEach(b => Console.WriteLine(b));
}