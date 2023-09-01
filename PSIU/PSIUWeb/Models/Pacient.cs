using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSIUWeb.Models
{
    public enum Race { 
        Asiatico
        , Branco
        , Indio
        , Negro
        , Pardo
        , Outros
    }

    public class Pacient
    {
        [Key] //Para deixar esplicito que o Id é chave primária
        public int Id { get; set; }
        public string? Name { get; set; }
        [Required(ErrorMessage = "Nome requerido.")]
        [Display(Name = "Nome")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Data requerida.")]
        [Display(Name = "Data")]
        public decimal Weight { get; set; }
        [Required(ErrorMessage = "Peso requerido.")]
        [Display(Name = "Peso")]
        public decimal Height { get; set; }
        [Required(ErrorMessage = "Altura requerida.")]
        [Display(Name = "Altura")]
        public Race Race { get; set; }

        [ForeignKey("User")]
        public string? UserId { get; set; }
        //Atributo de navegação ou navigation property
        public AppUser? User { get; set; }
    }
}
