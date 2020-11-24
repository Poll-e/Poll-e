using System.Collections;
using System.Collections.Generic;
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
        
        
        [Column("category")]
        public string Category { get; set; }

        [Column("code")]
        public string Code { get; set; }
        
        public ICollection<PollOptionEntity> Options { get; set; }
    }
}