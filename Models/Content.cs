using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public abstract class Content
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Plot { get; set; }
        public int ReleaseDate { get; set; }
        public int RunningTime { get; set; }

        // Connessione molti a molti con Genre
        public List<Genre>? Genre { get; set; }

        // Connessione molti a molti con Playlist
        public List<Playlist>? Playlist { get; set; }
        
        // Connessione molti a molti con Profile
        public List<Profile>? Profile { get; set; }


        public Content()
        {
           
        }
    }
    
}
