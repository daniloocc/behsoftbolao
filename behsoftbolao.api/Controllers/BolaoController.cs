using AutoMapper;
using BehSoft.DataAccess.Repository.IRepository;
using behsoftbolao.api.CustomActionFilters;
using behsoftbolao.api.Managers.Interfaces;
using Core.Models;
using Core.Utils;
using DataAccess.Data.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using static System.Reflection.Metadata.BlobBuilder;

namespace behsoftbolao.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BolaoController : ControllerBase
    {
        private readonly IBolaoManager _bolaoManager;
        private readonly ILogger<BolaoController> _logger;

        public BolaoController(IBolaoManager bolaoManager, ILogger<BolaoController> logger)
        {
            _bolaoManager = bolaoManager;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? filterOn, [FromQuery] string? filterQuery,
            [FromQuery] string? sortBy, [FromQuery] bool? isAscending, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 1000)
        {
            _logger.LogInformation("GetAll action method was invoked");

            var boloesDto = await _bolaoManager.GetAll(filterOn, filterQuery, sortBy, isAscending, pageNumber, pageSize);            

            return Ok(boloesDto);
        }

        [HttpGet("{codigo}")]
        public async Task<IActionResult> GetByCodigo([FromRoute] string codigo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var bolaoDto = await _bolaoManager.GetByCode(codigo);

            if (bolaoDto == null)
            {
                return NotFound();
            }

            // retornar dto
            return Ok(bolaoDto);
        }

        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] CreateBolaoDto bolaoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _bolaoManager.InserirBolao(bolaoDto);

            return CreatedAtAction(nameof(GetByCodigo), new { codigo = bolaoDto.Codigo }, result);

        }

        [HttpDelete("{idBolao}")]
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> RemoveBolao(string idBolao)
        {
            throw new NotImplementedException();
        }
    }
}
