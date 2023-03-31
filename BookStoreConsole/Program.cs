using BookStoreConsole.DataContext;
using BookStoreConsole.Models;
using BookStoreConsole.DLL;
using System.Security.Cryptography.X509Certificates;
using BookStoreConsole.Queries;
using BookStoreConsole.Repositories;
using BookStoreConsole.DTOs;

Console.WriteLine("Hello, World!");

var bookQueries = new BookQueries(new BookQueriesRepository());

List<Book> books = bookQueries.FindAll();
foreach(Book book in books)
{
    Console.WriteLine(book.title);
    Console.WriteLine(book.quantity);
}