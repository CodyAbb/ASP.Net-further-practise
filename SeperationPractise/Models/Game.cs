using System;
namespace SeperationPractise.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AgeRating { get; set; }
        public int YearReleased { get; set; }

        public Publisher Publisher { get; set; }
    }
}
