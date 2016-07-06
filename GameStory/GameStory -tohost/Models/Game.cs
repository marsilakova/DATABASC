using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStory.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string gName { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}