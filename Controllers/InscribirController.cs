using AutoMapper;
using G_P.Dto;
using G_P.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Any;

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

        [HttpGet("{tomo}/{folio}/{municipio}/{provincia}")]
        public async Task<ActionResult<InscrbirDTO>> GetInscripcion(int tomo, int folio, string municipio, string provincia)
        {
            var inscripcion = await context.inscipciones.FirstOrDefaultAsync(x =>  x.tomo == tomo
                                                                                   && x.folio == folio
                                                                                    && x.municipio == municipio
                                                                                   && x.provincia == provincia);
            if (inscripcion == null)
            {
                return NotFound();
            }

           

            return mapper.Map<InscrbirDTO>(inscripcion);
        }


        [HttpPost("inscripcion")]
        public async Task<ActionResult> Post([FromBody] InscribirCreationDTO inscribirCreationDTO)
        {
            int ultimo = 0;
            string referenceNumber ;
            // Query the database to retrieve the previous record
            var registroAnterior = await context.inscipciones.OrderByDescending(x => x.id).Skip(1).FirstOrDefaultAsync();
            
            // Assign the value of the "id" field of the previous record to the `ultimo` variable
           if ( registroAnterior==null)  {
                ultimo = 1;
                referenceNumber = "REF-" + (ultimo + 1); }

            else { 
            // Create the reference number by concatenating the "REF-" string and the value `ultimo + 1`
            referenceNumber= "REF-" + (ultimo + 2);
            }

            // Assign the created reference number to the "codigo_referencia" property of the `inscribirCreationDTO` object
            inscribirCreationDTO.codigo_referencia = referenceNumber;

            // Use AutoMapper to map the `inscribirCreationDTO` object to an `inscribir_matrimoio` object
            var inscripcion = mapper.Map<inscribir_matrimoio>(inscribirCreationDTO);

            // Add the `inscripcion` object to the database through the database context
            context.Add(inscripcion);

            // Save the changes made to the database
            await context.SaveChangesAsync();

            // Return a "NoContent" action result, indicating that the request has been successfully completed, but there is no data to be returned in the HTTP response
            return NoContent();
        }




    }
}
