using System.ComponentModel;

namespace CursoNET.Models
{
    public class Author
    {
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Apellido")]
        public string Surname { get; set; }
    }
}