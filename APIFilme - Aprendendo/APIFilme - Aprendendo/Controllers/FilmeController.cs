using APIFilme___Aprendendo.Models;
using APIFilme___Aprendendo.Repository;
using APIFilme___Aprendendo.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace APIFilme___Aprendendo.Controllers
{
    [ApiController]
    [Route("api/v1/filme")]
    public class FilmeController : Controller
    {
        private readonly IFilmeRepository _filmeRepository;

        public FilmeController(IFilmeRepository repositorio)
        {
            _filmeRepository = repositorio;
        }

        [HttpGet]
        [Route("GetAll")]

        public IActionResult GetAll()
        {
            return Ok(_filmeRepository.GetAll());
        }

        [HttpPost]
        [Route("/Filme/Create")]

        public IActionResult CriarFilme(Filme Model)
        {
            _filmeRepository.Add(Model);
            return Ok();
        }

        [HttpDelete]
        [Route("/Delete/{id}")]

        public async Task<IActionResult> DeleteFilme(int FilId) => Ok(await _filmeRepository.DeleteFilme(FilId));

        [HttpPost]
        [Route("Update")]

        public async Task<IActionResult> UpdateFilme(Filme Model) => Ok(await _filmeRepository.UpdateFilme(Model));

        [HttpPost]
        [Route("AdicionarFilmeSemFoto")]


        public IActionResult AdicionarFilmeSemFoto(ViewModelFilmeSemFoto filme)
        {
            try
            {
                _filmeRepository.Add(
                    new Filme() { Titulo = filme.Titulo, Diretor = filme.Diretor, DataLancamento = filme.DataLancamento, Genero = filme.Genero, photourl = null}
                    );
                return Ok("Foto Cadastrada com Sucesso");
            }
            catch (Exception ex)
            {

                return BadRequest("Foto Não Cadastrada.Erro" + ex.Message);
            }
        }

        [HttpPost]
        [Route("AdicionarFilmeComFoto")]

        public IActionResult AdicionarFilmeComFoto(ViewModelFilmeComFoto filme)
        {
            try
            {
                var caminho = Path.Combine("Storange", filme.photo.FileName);
                using Stream fileStram = new FileStream(caminho, FileMode.Create);
                filme.photo.CopyTo(fileStram);

                _filmeRepository.Add(
                    new Filme() { Titulo = filme.Titulo, Diretor = filme.Diretor, DataLancamento = filme.DataLancamento, Genero = filme.Genero, photourl = null }
                    );
                return Ok("Foto Cadastrada com Sucesso");
            }
            catch (Exception ex)
            {

                return BadRequest("Foto Não Cadastrada.Erro" + ex.Message);
            }
        }
    }
}
