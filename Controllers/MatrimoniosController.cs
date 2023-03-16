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
        [HttpPost("matrimonios")]
        public async Task<ActionResult> Post([FromBody] MatrimoniosCreationDTO matrimoniosCreationDTO)
        {
            var matrimonios = mapper.Map<matrimonios>(matrimoniosCreationDTO);
            context.Add(matrimonios);
            await context.SaveChangesAsync();
            return NoContent();
        }

    }
}
