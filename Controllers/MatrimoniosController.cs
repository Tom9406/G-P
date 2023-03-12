using AutoMapper;
using G_P.Dto;
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

        [HttpGet]
        public async Task<ActionResult<List<MatrimoniosDTO>>> Get()
        {
            var matrimonios = await context.Subjects.ToListAsync();

        }
    }
}
