using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PollE.Controllers.DTOs;

namespace PollE.DataAccess.Entities
{
    [Table("poll_options")]
    public class PollOptionEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("text")]
        public string Text { get; set; }

        public PollEntity Poll { get; set; }
        
        public PollOptionImageEntity Image { get; set; }
        
        public ICollection<VoteEntity> Votes { get; set; } 
    }
}