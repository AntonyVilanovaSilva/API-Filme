using APIFilme___Aprendendo.Infraestrutura;
using APIFilme___Aprendendo.Models;
using Microsoft.EntityFrameworkCore;

namespace APIFilme___Aprendendo.Repository
{
    public class FilmeRepository : IFilmeRepository
    {
        ConexãoSQL bdConexao = new ConexãoSQL();

        public void Add(Filme filme)
        {
            bdConexao.Add(filme);
            bdConexao.SaveChanges();
        }

        public List<Filme> GetAll()
        {
            return bdConexao.Filme.ToList();
        }

        public async Task<bool> DeleteFilme(int FilId)
        {
            var a = await bdConexao.Filme.FirstOrDefaultAsync(x => x.FilId == FilId);
            bdConexao.Filme.Remove(a);
            await bdConexao.SaveChangesAsync();
            return true;
        }

        public async Task<Filme> UpdateFilme(Filme Model)
        {
            bdConexao.Update(Model);
            await bdConexao.SaveChangesAsync();
            return Model;
        }
    }
}
