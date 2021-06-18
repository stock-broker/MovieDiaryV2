using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieDiary.Data.Entities
{
    public class Entry
    {
        [Key]
        public int EntryId { get; set; }
        public Movie Movie { get; set; }
        public DateTime CreatedAt {get; set; } = DateTime.UtcNow;
        public int UserId {get;set;}
    }
}