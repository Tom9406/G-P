using AutoMapper;
using G_P.Dto;
using G_P.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace G_P.Controllers
{
    [Route("matrimonios")]
    [ApiController]
    public class MatrimoniosController:ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public MatrimoniosController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("matrimonio")]
        public async Task<ActionResult<List<MatrimoniosDTO>>> GetMatrimonios()
        {

            var matrimonio = await context.matrimonios.ToListAsync();           
            return mapper.Map<List<MatrimoniosDTO>>(matrimonio);

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<MatrimoniosDTO>> GetMatrimonios(int id)
        {
            var matrimonio = await context.matrimonios.FirstOrDefaultAsync(x => x.id == id);
            if (matrimonio == null)
            {
                return NotFound();
            }
            return mapper.Map<MatrimoniosDTO>(matrimonio);
        }

        [HttpGet("id_matrimonios")]
        public async Task<ActionResult<MatrimoniosDTO>> GetMatrimonios_id(int id_matrimonio)
        {
            var matrimonio = await context.matrimonios.FirstOrDefaultAsync(x => x.id_matrimonio == id_matrimonio);
            if (matrimonio == null)
            {
                return NotFound();
            }
            return mapper.Map<MatrimoniosDTO>(matrimonio);
        }

        [HttpGet("id_inscripion")]
        public async Task<ActionResult<MatrimoniosDTO>> GetMatrimonios_id_inscripcion(int id_inscripion)
        {
            var matrimonio = await context.matrimonios.FirstOrDefaultAsync(x => x.id_inscripion == id_inscripion);
            if (matrimonio == null)
            {
                return NotFound();
            }
            return mapper.Map<MatrimoniosDTO>(matrimonio);
        }

        [HttpGet("id_anulacion")]
        public async Task<ActionResult<MatrimoniosDTO>> GetMatrimonios_id_anulacion(int id_anulacion)
        {
            var matrimonio = await context.matrimonios.FirstOrDefaultAsync(x => x.id_anulacion == id_anulacion);
            if (matrimonio == null)
            {
                return NotFound();
            }
            return mapper.Map<MatrimoniosDTO>(matrimonio);
        }

        [HttpGet("id_referencia")]
        public async Task<ActionResult<MatrimoniosDTO>> GetMatrimonios_id_referencia(string id_referencia)
        {
            var matrimonio = await context.matrimonios.FirstOrDefaultAsync(x => x.id_referencia == id_referencia);
            if (matrimonio == null)
            {
                return NotFound();
            }
            return mapper.Map<MatrimoniosDTO>(matrimonio);
        }

        [HttpGet("id_tramite")]
        public async Task<ActionResult<MatrimoniosDTO>> GetMatrimonios_id_tramite(int id_tramite)
        {
            var matrimonio = await context.matrimonios.FirstOrDefaultAsync(x => x.id_tramite == id_tramite);
            if (matrimonio == null)
            {
                return NotFound();
            }
            return mapper.Map<MatrimoniosDTO>(matrimonio);
        }

        [HttpGet("fecha")]
        public async Task<ActionResult<MatrimoniosDTO>> GetMatrimonios_fecha(DateTime fecha)
        {
            var matrimonio = await context.matrimonios.FirstOrDefaultAsync(x => x.fecha == fecha);
            if (matrimonio == null)
            {
                return NotFound();
            }
            return mapper.Map<MatrimoniosDTO>(matrimonio);
        }

        [HttpPost("matrimonios")]
        public async Task<ActionResult> Post([FromBody] MatrimoniosCreationDTO matrimoniosCreationDTO)
        {
            var matrimonios = mapper.Map<matrimonios>(matrimoniosCreationDTO);
            context.Add(matrimonios);
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] MatrimoniosCreationDTO matrimoniosCreationDTO)
        {
            var matrimonios = mapper.Map<matrimonios>(matrimoniosCreationDTO);
            matrimonios.id = id;
            context.Entry(matrimonios).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var matrimonios = await context.matrimonios.FirstOrDefaultAsync(x => x.id == id);
            if (matrimonios == null) { return NotFound(); }
            context.Remove(matrimonios);
            await context.SaveChangesAsync();
            return NoContent();
        }

    }
}
