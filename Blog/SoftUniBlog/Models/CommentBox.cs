using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SoftUniBlog.Models
{
    public class CommentBox
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
        public string content { get; set; }
      

      

    }

}