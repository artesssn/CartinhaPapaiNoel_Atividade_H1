namespace CartinhaPapaiNoel.Persistence
{
    using CartinhaPapaiNoel.Models;
    using System;
    using System.Collections.Generic;

    public interface ILetterRepository
    {
        IEnumerable<Letter> GetAll();
        Letter GetById(Guid id);
        void Add(Letter letter);
    }
}
