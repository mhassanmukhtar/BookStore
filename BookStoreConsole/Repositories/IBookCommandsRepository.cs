﻿using BookStoreConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsole.Repositories
{
    public interface IBookCommandsRepository
    {
        void SaveBook(Book book);
        void UpdateBook(Book book, Guid id);
        bool DeleteBook(Guid id);
    }
}
