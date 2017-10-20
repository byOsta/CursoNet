using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoNET.Models
{
    public class Video
    {
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "El título debe ser menor de 50 carácteres")]
        public string Title { get; set; }

        public string Link { get; set; }

        public DateTime UploadTime { get; set; }

        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author { get; set; }

        public int VideoGenreId { get; set; }

        [ForeignKey("VideoGenreId")]
        public VideoGenre VideoGenre { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        public bool Active { get; set; }
    }
}