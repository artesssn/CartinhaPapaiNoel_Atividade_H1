namespace CartinhaPapaiNoel.Models
{
    public class Letter
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NomeCrianca { get; set; }
        public Address Endereco { get; set; }
        public int Idade { get; set; }
        public string TextoCarta { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
