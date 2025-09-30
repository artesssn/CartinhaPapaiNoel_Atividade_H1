namespace CartinhaPapaiNoel.Persistence
{
    using CartinhaPapaiNoel.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LetterRepository : ILetterRepository
    {
        private readonly List<Letter> _letters = new();
        private readonly object _lock = new();

        public IEnumerable<Letter> GetAll()
        {
            lock (_lock)
            {
                return _letters.Select(l => l).ToList();
            }
        }

        public Letter GetById(Guid id)
        {
            lock (_lock)
            {
                return _letters.FirstOrDefault(l => l.Id == id);
            }
        }

        public void Add(Letter letter)
        {
            if (letter == null) throw new ArgumentNullException(nameof(letter));

            letter.NomeCrianca = letter.NomeCrianca?.Trim();
            letter.TextoCarta = letter.TextoCarta?.Trim();

            lock (_lock)
            {
                _letters.Add(letter);
            }
        }
    }
}
