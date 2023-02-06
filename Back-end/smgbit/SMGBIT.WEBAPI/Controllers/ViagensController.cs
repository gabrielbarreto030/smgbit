using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SMGBIT.Application.DTO;
using SMGBIT.Application.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMGBIT.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViagensController : ControllerBase
    {
        private readonly ITabelaFreteService _tabelaFreteService;
        private readonly IViagensService _viagensService;
        public ViagensController(IViagensService viagensService,ITabelaFreteService tabelaFreteService)
        {
            this._viagensService= viagensService;
            this._tabelaFreteService = tabelaFreteService;
        }
        // GET: api/<ViagensController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ViagemDTO>>> Get()
        {
            try { 
                return Ok(await _viagensService.getViagens());
             }
            catch (Exception ex)
             {
                return BadRequest(ex.Message);
             }
        }

        // GET api/<ViagensController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                return Ok(await _viagensService.getById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<ViagensController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ViagemDTO value)
        {
            try
            {
                var tabelas = await _tabelaFreteService.getTabelas();

                var tabelaAtual = tabelas.Where(x => x.TipoVeiculo == value.TipoVeiculo &&
                 x.Cliente == value.Origem
                 ).ToList();
                if (tabelaAtual.Count() > 1)
                {
                    tabelaAtual = tabelas.Where(x => x.TipoVeiculo == value.TipoVeiculo &&
                x.Cliente == value.Origem && x.Destino == value.Destino
                ).ToList();
                }
                if (!tabelaAtual.IsNullOrEmpty())
                {
                    value.ValorViagem = tabelaAtual.First().Valor;
                    value.TabelaViagem = tabelaAtual.First().NomeTabela;
                }              
                await _viagensService.Add(value);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
         

        }

        // PUT api/<ViagensController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put([FromBody] ViagemDTO value)
        {
            try
            {
                await _viagensService.Update(value);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ViagensController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _viagensService.Remove(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
