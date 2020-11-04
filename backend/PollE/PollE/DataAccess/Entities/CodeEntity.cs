using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PollE.DataAccess.Entities
{
    [Table("codes")]
    public class CodeEntity
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        
        [Column("code")]
        public string Code { get; set; }
        
        public PollEntity Poll { get; set; }
    }
}