using AutoMapper;
using G_P.Dto;
using G_P.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace G_P.Controllers

{
    [Route("inscripcion")]
    [ApiController]
    public class InscribirController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public InscribirController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost("inscripcion")]
        public async Task<ActionResult> Post([FromBody] InscribirCreationDTO inscribirCreationDTO)
        {
            var inscripcion = mapper.Map<inscribir_matrimoio>(inscribirCreationDTO);
            context.Add(inscripcion);
            await context.SaveChangesAsync();
            return NoContent();
        }



    }
}
