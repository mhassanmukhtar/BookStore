using BookStoreConsole.DTOs;
using BookStoreConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.Queries
{
    internal interface IBookQueries
    {
        List<Book> FindAll();
        Book FindByID(Guid id);
        //void FindByName(string name);
    }
}
