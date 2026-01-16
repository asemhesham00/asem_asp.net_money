using System.ComponentModel.DataAnnotations;

namespace asem_asp.net_money.Models
{
    public class Lesson
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string  videourl{ get; set; }
        public string duration { get; set; }
        public int ordernum { get; set; }
        public int Course_id { get; set; }

    }
}
