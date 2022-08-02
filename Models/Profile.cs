using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool ChildProfile { get; set; }

        // Connessione molti a molti con Content
        public List<Content> Content { get; set; }
        
        // Connessione molti a molti con Playlist
        public List<Playlist> Playlist { get; set; }

        public Profile()
        {
           
        }
    }
}
