using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZiiBlog.Models
{
    public class post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int id { get; set; }

        public string title { get; set; }

        public string Content { get; set; }

        public DateTime createdDate { get; set; }

        public DateTime updatedDate { get; set; }
    }
}
