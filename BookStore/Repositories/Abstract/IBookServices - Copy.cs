﻿using BookStore.Models.Domain;

namespace BookStore.Repositories.Abstract
{
    public interface IBookService
    {

        bool Add(Book model);
        bool Update(Book model);
        bool Delete(int id);
        Book FindById(int id);
        IEnumerable<Book> GetAll();
    }
}
