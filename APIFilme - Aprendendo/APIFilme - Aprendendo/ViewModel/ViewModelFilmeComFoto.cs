namespace APIFilme___Aprendendo.ViewModel
{
    public class ViewModelFilmeComFoto
    {
        public string Titulo { get; set; }

        public string Diretor { get; set; }

        public DateTime DataLancamento { get; set; }

        public string Genero { get; set; }

        public IFormFile photo { get; set; }
    }
}
