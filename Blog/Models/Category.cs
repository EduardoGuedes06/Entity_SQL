using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Blog.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(80)]
        [MinLength(4)]
        [Column("Name",TypeName = "VARCHAR")]
        public string? Name { get; set; }
        [Required]
        [MaxLength(80)]
        [MinLength(4)]
        [Column("Name", TypeName = "VARCHAR")]
        public string? Slug { get; set; }
    }
}