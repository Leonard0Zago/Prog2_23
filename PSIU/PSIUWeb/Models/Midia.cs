using System.ComponentModel.DataAnnotations;

namespace PSIUWeb.Models
{
    public class Midia
    {
        [Key]
        public int Id { get; set; }
        public string? URL { get; set; }
        public string? TipoMidia { get; set; }
    }
}
