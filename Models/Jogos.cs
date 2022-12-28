using System.ComponentModel.DataAnnotations;

namespace JogosVintageWebApplication.Models
{
    public class Jogos
    {
        public int ID { get; set; }
        public string? Imagem { get; set;}

        [Display(Name = "Nome")]

        public string? Name { get; set;}
        public string? Descrição { get; set; }
        public string? Plataforma  { get; set; }
        public string? Modelo  { get; set; }
        public string? Idioma  { get; set; }
        
    }
}
