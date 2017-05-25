using System.Collections.Generic;

namespace SportApp.Models
{
    public class Gym 
    {
        public int Id { get; set; }
        public string GymName { get; set; }
        public int GymRate { get; set; }
        public string GymLocation { get; set; }
        public string GoogleLocation { get; set; }
        public int MbrshipPrice { get; set; }
        public int GymArea { get; set; }
        public int FoundYear { get; set; }
        public string Facilities { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string GymImgUrl { get; set; }

        public List<Comment> Comments { get; set; }
    }
}