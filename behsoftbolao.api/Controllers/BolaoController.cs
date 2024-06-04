using BehSoft.DataAccess.Repository.IRepository;
using Core.Models;
using Core.Utils;
using DataAccess.Data.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace behsoftbolao.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BolaoController : ControllerBase
    {
        private readonly IUnitOfWork _unityOfWork;
        public BolaoController(IUnitOfWork unitOfWork)
        {
            _unityOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var boloes = await _unityOfWork.Bolao.GetAll();

            // mapear domain model para dto
            List<ReadBolaoDto> boloesDtos = new();

            boloesDtos = boloes.Select(b => new ReadBolaoDto
            {
                Codigo = b.Codigo,
                Titulo = b.Titulo,
                CriadoEm = b.CriadoEm,
            }).ToList();

            // retornar dto
            return Ok(boloesDtos);
        }

        [HttpGet("{codigo}")]
        public async Task<IActionResult> GetByCodigo([FromRoute] string codigo)
        {
            // domain model
            var bolao = await _unityOfWork.Bolao.Get(b => b.Codigo.ToUpper() == codigo.ToUpper());

            if (bolao == null)
            {
                return NotFound();
            }

            // map para dto
            ReadBolaoDto bolaoDto = new()
            {
                Codigo = bolao.Codigo,
                Titulo = bolao.Titulo,
                CriadoEm = bolao.CriadoEm,
            };

            // retornar dto
            return Ok(bolaoDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBolaoDto bolaoDto)
        {
            // map dto to domain model
            var dm = new Bolao
            {
                Titulo = bolaoDto.Titulo,
                DonoId = bolaoDto.DonoId,
                Codigo = bolaoDto.Codigo,
                CampeonatoAnualId = bolaoDto.CampeonatoAnualId,
                CriadoEm = DateTime.Now
            };

            // use domain model to create region
            await _unityOfWork.Bolao.Add(dm);
            await _unityOfWork.Save();

            // map domain back to dto
            var result = new ReadBolaoDto
            {
                Titulo = dm.Titulo,
                Codigo = dm.Codigo,
                CriadoEm = dm.CriadoEm
            };

            return CreatedAtAction(nameof(GetByCodigo), new { codigo = bolaoDto.Codigo }, result);
        }
    }
}
