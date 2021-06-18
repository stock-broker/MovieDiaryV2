using System.ComponentModel.DataAnnotations.Schema;

namespace MovieDiary.Data.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string MovieYear { get; set; }
        public string MovieGenre { get; set; }
        public string MovieReview { get; set; }
        public int MovieRating { get; set; }
    }
}