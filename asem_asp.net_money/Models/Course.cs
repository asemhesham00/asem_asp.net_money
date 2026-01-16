using System.ComponentModel.DataAnnotations;

namespace asem_asp.net_money.Models
{
    public class Course
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string level { get; set; }
        public string imgurl { get; set; }
        public int Category_id { get; set; }
        public int instructor_id { get; set; }
    }
}
