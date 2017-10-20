using System.ComponentModel;

namespace CursoNET.Models
{
    public class SongGenre
    {
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

    }
}