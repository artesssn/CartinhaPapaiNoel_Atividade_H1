namespace CartinhaPapaiNoel.Controllers
{
    using CartinhaPapaiNoel.DTOs;
    using CartinhaPapaiNoel.Models;
    using CartinhaPapaiNoel.Persistence;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    [ApiController]
    [Route("api/[controller]")]
    public class LettersController : ControllerBase
    {
        private readonly ILetterRepository _repository;

        public LettersController(ILetterRepository repository)
        {
            _repository = repository;
        }

       [HttpGet]
        public ActionResult<IEnumerable<Letter>> GetAll()
        {
            var letters = _repository.GetAll();
            return Ok(letters);
        }

       [HttpGet("{id}")]
        public ActionResult<Letter> GetById(Guid id)
        {
            var letter = _repository.GetById(id);
            if (letter == null) return NotFound();
            return Ok(letter);
        }

       [HttpPost]
        public ActionResult<Letter> Create([FromBody] LetterCreateDto dto)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem(ModelState);
            }

            var letter = new Letter
            {
                Id = Guid.NewGuid(),
                NomeCrianca = dto.NomeCrianca.Trim(),
                Endereco = dto.Endereco,
                Idade = dto.Idade,
                TextoCarta = dto.TextoCarta.Trim(),
                CreatedAt = DateTime.UtcNow
            };

            _repository.Add(letter);

            return CreatedAtAction(nameof(GetById), new { id = letter.Id }, letter);
        }
    }
}
