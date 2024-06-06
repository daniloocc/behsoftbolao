using AutoMapper;
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
        private readonly IMapper _mapper;

        public BolaoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unityOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var boloes = await _unityOfWork.Bolao.GetAll(includeProperties: "Dono,CampeonatoAnual,CampeonatoAnual.Campeonato");

            // mapear domain model para dto
            List<ReadBolaoDto> boloesDtos = _mapper.Map<List<ReadBolaoDto>>(boloes);

            // retornar dto
            return Ok(boloesDtos);
        }

        [HttpGet("{codigo}")]
        public async Task<IActionResult> GetByCodigo([FromRoute] string codigo)
        {
            // domain model
            var bolao = await _unityOfWork.Bolao.Get(b => b.Codigo.ToUpper() == codigo.ToUpper(), includeProperties: "Dono,CampeonatoAnual,CampeonatoAnual.Campeonato");

            if (bolao == null)
            {
                return NotFound();
            }

            // map para dto
            ReadBolaoDto bolaoDto = _mapper.Map<ReadBolaoDto>(bolao);

            // retornar dto
            return Ok(bolaoDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBolaoDto bolaoDto)
        {
            // map dto to domain model
            var dm = _mapper.Map<Bolao>(bolaoDto);

            // use domain model to create region
            await _unityOfWork.Bolao.Add(dm);
            await _unityOfWork.Save();

            // map domain back to dto
            //var result = _mapper.Map<ReadBolaoDto>(dm);

            var result = await _unityOfWork.Bolao.Get(b => b.Codigo == dm.Codigo, includeProperties: "Dono,CampeonatoAnual,CampeonatoAnual.Campeonato");

            return CreatedAtAction(nameof(GetByCodigo), new { codigo = bolaoDto.Codigo }, _mapper.Map<ReadBolaoDto>(result));
        }
    }
}
