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

        /// <summary>
        /// Retrieves a list of all matrimonios.
        /// </summary>
        /// <returns>A list of MatrimoniosDTO objects.</returns>
        [HttpGet("matrimonio")]
        public async Task<ActionResult<List<MatrimoniosDTO>>> GetMatrimonios()
        {
            // Retrieve all matrimonios from the database.
            var matrimonio = await context.matrimonios.ToListAsync();
            // Map the retrieved matrimonios to a list of MatrimoniosDTO objects.
            return mapper.Map<List<MatrimoniosDTO>>(matrimonio);
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<MatrimoniosDTO>> GetMatrimonios(int id)
        {
            // Search for the matrimonio with the specified id
            var matrimonio = await context.matrimonios.FirstOrDefaultAsync(x => x.id == id);

            // If no matrimonio is found, return 404 Not Found
            if (matrimonio == null)
            {
                return NotFound();
            }

            // Otherwise, return the matrimonio mapped to MatrimoniosDTO
            return mapper.Map<MatrimoniosDTO>(matrimonio);
        }


        [HttpGet("id_matrimonios")]
        public async Task<ActionResult<MatrimoniosDTO>> GetMatrimonios_id(int id_matrimonio)
        {
            // Find the matrimonio with the given id_matrimonio in the database
            var matrimonio = await context.matrimonios.FirstOrDefaultAsync(x => x.id_matrimonio == id_matrimonio);

            // If no matrimonio is found, return a 404 Not Found response
            if (matrimonio == null)
            {
                return NotFound();
            }

            // Map the matrimonio to a MatrimoniosDTO and return it as a 200 OK response
            return mapper.Map<MatrimoniosDTO>(matrimonio);
        }


        [HttpGet("id_inscripion")]
        public async Task<ActionResult<MatrimoniosDTO>> GetMatrimonios_id_inscripcion(int id_inscripion)
        {
            // find the first matrimonio with the given id_inscripion
            var matrimonio = await context.matrimonios.FirstOrDefaultAsync(x => x.id_inscripion == id_inscripion);
            // if the matrimonio is not found, return a NotFound response
            if (matrimonio == null)
            {
                return NotFound();
            }
            // map the matrimonio to a MatrimoniosDTO and return it
            return mapper.Map<MatrimoniosDTO>(matrimonio);
        }


        /// <summary>
        /// Retrieves the matrimonial record with the specified ID of annulment.
        /// </summary>
        /// <param name="id_anulacion">The ID of the annulment record.</param>
        /// <returns>The matrimonial record with the specified ID of annulment.</returns>
        /// <response code="200">Returns the requested matrimonial record.</response>
        /// <response code="404">If no matrimonial record with the specified ID of annulment was found.</response>
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


        /// <summary>
        /// Retrieves a matrimonial record by its reference ID.
        /// </summary>
        /// <param name="id_referencia">The reference ID of the matrimonial record to retrieve.</param>
        /// <returns>The matrimonial record with the specified reference ID.</returns>
        /// <response code="200">Returns the requested matrimonial record.</response>
        /// <response code="404">If a matrimonial record with the specified reference ID is not found.</response>
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


        /// <summary>
        /// Gets the matrimonio with the specified id_tramite.
        /// </summary>
        /// <param name="id_tramite">The id_tramite of the matrimonio to retrieve.</param>
        /// <returns>The matrimonio with the specified id_tramite.</returns>
        [HttpGet("id_tramite")]
        public async Task<ActionResult<MatrimoniosDTO>> GetMatrimonios_id_tramite(int id_tramite)
        {
            // Retrieve the matrimonio with the specified id_tramite from the database
            var matrimonio = await context.matrimonios.FirstOrDefaultAsync(x => x.id_tramite == id_tramite);

            // If no matrimonio with the specified id_tramite was found, return a 404 Not Found status code
            if (matrimonio == null)
            {
                return NotFound();
            }

            // Map the matrimonio to a MatrimoniosDTO object and return it
            return mapper.Map<MatrimoniosDTO>(matrimonio);
        }


        /// <summary>
        /// Retrieves a matrimonio by its fecha.
        /// </summary>
        /// <param name="fecha">The fecha of the matrimonio to retrieve.</param>
        /// <returns>The retrieved matrimonio.</returns>
        [HttpGet("fecha")]
        public async Task<ActionResult<MatrimoniosDTO>> GetMatrimonios_fecha(DateTime fecha)
        {
            // Retrieve the matrimonio by its fecha.
            var matrimonio = await context.matrimonios.FirstOrDefaultAsync(x => x.fecha == fecha);

            // If no matrimonio is found, return a NotFound error.
            if (matrimonio == null)
            {
                return NotFound();
            }

            // Map the retrieved matrimonio to a MatrimoniosDTO object and return it.
            return mapper.Map<MatrimoniosDTO>(matrimonio);
        }

        /// <summary>
        /// Creates a new matrimonios record in the database based on the provided data.
        /// </summary>
        /// <param name="matrimoniosCreationDTO">The data for the new matrimonios record.</param>
        /// <returns>A response with status 204 No Content if successful.</returns>

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
            // Map the `matrimoniosCreationDTO` object to a `matrimonios` object using AutoMapper
            var matrimonios = mapper.Map<matrimonios>(matrimoniosCreationDTO);

            // Assign the `id` value to the `id` property of the `matrimonios` object
            matrimonios.id = id;

            // Change the state of the `matrimonios` object to "Modified" so that Entity Framework will update the corresponding record in the database
            context.Entry(matrimonios).State = EntityState.Modified;

            // Save the changes made to the database
            await context.SaveChangesAsync();

            // Return a "NoContent" action result, indicating that the request has been successfully completed, but there is no data to be returned in the HTTP response
            return NoContent();
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            // Query the database to retrieve the matrimonios record with the specified id
            var matrimonios = await context.matrimonios.FirstOrDefaultAsync(x => x.id == id);

            // If the matrimonios record is not found, return a "NotFound" action result
            if (matrimonios == null) { return NotFound(); }

            // Remove the matrimonios record from the database through the database context
            context.Remove(matrimonios);

            // Save the changes made to the database
            await context.SaveChangesAsync();

            // Return a "NoContent" action result, indicating that the request has been successfully completed, but there is no data to be returned in the HTTP response
            return NoContent();
        }


    }
}
