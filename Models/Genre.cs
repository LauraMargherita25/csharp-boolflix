using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        // Connessione molti a molti con Content
        public List<Content> Content { get; set; }

        public Genre()
        {
            
        }
    }
}
