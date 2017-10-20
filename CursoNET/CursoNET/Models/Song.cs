using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoNET.Models
{
    public class Song
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Link { get; set; }

        public DateTime UploadTime { get; set; }

        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author { get; set; }

        public int SongGenreId { get; set; }

        [ForeignKey("SongGenreId")]
        public SongGenre SongGenre { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        public bool Active { get; set; }
    }
}