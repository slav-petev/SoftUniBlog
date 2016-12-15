using System.ComponentModel.DataAnnotations;


namespace SoftUniBlog.Models
{
    public class Comment
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Website { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        public Post Post { get; set; }


    }

}