using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PollE.DataAccess.Entities
{
    [Table("polls")]
    public class PollEntity
    {
        [Column("id")]
        [Key]
        public int? Id { get; set; }
        
        [Column("title")]
        public string Title { get; set; }
        
        
        //[Column("category")]
        //public int? CategoryId { get; set; }
        public CategoryEntity Category { get; set; }

        //[Column("code")]
        //public int? CodeId { get; set; }
        public CodeEntity Code { get; set; }
    }
}