using System.ComponentModel.DataAnnotations;

namespace FootballTeams
{
    public class Team
    {
        [Key] 
        public int id { get; set; }
        [Required] [MaxLength(50)] 
        public string name { get; set; }
        [MaxLength(50)]
        public string city { get; set; }
        public int wins { get; set; }
        public int loses { get; set; }
        public int draws { get; set; }
        public int scored { get; set; }
        public int recieved { get; set; }
    }
}