using System.ComponentModel.DataAnnotations;

namespace JogosVintageWebApplication.Models
{ 
    public class Consolas
    {
        public int ID { get; set; }

        public string? Imagem { get; set;}


        [Display(Name = "Nome")]

        public string? Name { get; set;}

        public string? Descrição { get; set;}

        public string? Processador { get; set; }

        public string? RAM { get; set; }

        public string? Saida { get; set; }

        public int? Ano { get; set; }
    }
}
