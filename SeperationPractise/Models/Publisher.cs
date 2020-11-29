using System;
using System.Collections.Generic;

namespace SeperationPractise.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double NetWorth { get; set; }
        public ICollection<Game> PublishedGames { get; set; }
    }
}
