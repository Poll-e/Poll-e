using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PollE.DataAccess.Entities
{
    [Table("votes")]
    public class VoteEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("nickname")]
        public string Nickname { get; set; }
        
        [Column("likes")]
        public bool Likes { get; set; }

        public PollOptionEntity Option { get; set; } 
    }
}