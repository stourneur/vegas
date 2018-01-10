using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vegas.Controllers.Resources;
using vegas.Models;
using vegas.Persistence;

namespace vegas.Controllers
{
    public class MakesController : Controller
    {
        private readonly VegasDbContext context;
        private readonly IMapper mapper;

        public MakesController(VegasDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();

            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}