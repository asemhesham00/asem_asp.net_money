using System.ComponentModel.DataAnnotations;

namespace asem_asp.net_money.Models
{
    public class Category

    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string img_url { get; set; }

    }
}
