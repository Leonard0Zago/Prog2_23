using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSIUWeb.Models
{
    public class ContentMidia
    {
        [Key]
        public int Id { get; set; }
        public int ContentId { get; set; }
        [ForeignKey("ContentId")]
        public int MidiaId { get; set; }
        [ForeignKey("MidiaId")]
    }
}
