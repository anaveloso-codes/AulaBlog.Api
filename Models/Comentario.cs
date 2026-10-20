namespace AulaBlog.Api.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public DateTime DataCriacao { get; set; }
        public int PostId { get; set; }
    }
}
