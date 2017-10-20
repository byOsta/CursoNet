using System.ComponentModel;

namespace CursoNET.Models
{
    public class VideoGenre
    {
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

    }
}