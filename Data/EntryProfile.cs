using AutoMapper;
using MovieDiary.Data.Entities;
using MovieDiary.Models;

namespace MovieDiary.Data
{
    public class EntryProfile : Profile
    {
        public EntryProfile()
        {
        CreateMap<EntryModel, Entry>();            
        }
    }
}