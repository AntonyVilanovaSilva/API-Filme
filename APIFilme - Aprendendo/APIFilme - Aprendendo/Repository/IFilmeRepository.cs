using APIFilme___Aprendendo.Models;

namespace APIFilme___Aprendendo.Repository
{
    public interface IFilmeRepository
    {
        List<Filme> GetAll();

        void Add(Filme filme);

        Task<bool> DeleteFilme(int FilId);

        Task<Filme> UpdateFilme(Filme Model);
    }
}
