using Microsoft.EntityFrameworkCore;
using MovieDiary.Data.Entities;

namespace MovieDiary.Data.Contexts
{
    public class MovieDiaryDbContext : DbContext
    {
        public MovieDiaryDbContext(DbContextOptions<MovieDiaryDbContext> options) : base(options)
        {
            //idk bro
        }
         public DbSet<User> Users { get; set; }
        public DbSet<Entry> Entries {get;set;}
        public DbSet<Movie> Movies {get; set;}
        
    }
}

//create database
