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
        public IActionResult GetAll()
        {
            var boloes = _unityOfWork.Bolao.GetAll();

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
        public IActionResult GetByCodigo([FromRoute] string codigo)
        {
            // domain model
            var bolao = _unityOfWork.Bolao.Get(b => b.Codigo == codigo);

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
        public IActionResult Create([FromBody] CreateBolaoDto bolaoDto)
        {
            // map dto to domain model
            var dm = new Bolao
            {
                Titulo = bolaoDto.Titulo,
                DonoId = bolaoDto.DonoId,
                Codigo = StringUtils.RandomAlfaString(6),
                CampeonatoAnualId = bolaoDto.CampeonatoAnualId,
                CriadoEm = DateTime.Now
            };

            // use domain model to create region
            _unityOfWork.Bolao.Add(dm);
            _unityOfWork.Save();

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
