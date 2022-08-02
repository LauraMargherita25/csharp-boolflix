using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class Playlist
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        // Connessione molti a molti con Content
        public List<Content> Content { get; set; }

        // Connessione molti a molti con Profile
        public List<Profile> Profile { get; set; }

        public Playlist()
        {
          
        }
    }
}
