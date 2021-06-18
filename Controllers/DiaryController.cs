using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieDiary.Data.Contexts;
using MovieDiary.Data.Entities;
using MovieDiary.Models;

namespace MovieDiary
{
    [ApiController]

    public class DiaryController : ControllerBase
    {
        private readonly MovieDiaryDbContext _db;
        private readonly IMapper _mapper;
        public DiaryController(MovieDiaryDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        [Route("/AddEntry")]
        [HttpPost]
        public async Task<ActionResult<EntryModel>> AddEntry(EntryModel model)
        {
            var entry = _mapper.Map<Entry>(model);
            await _db.AddAsync(entry);
            _db.SaveChanges();
            return Ok(entry);
        }
    }
}