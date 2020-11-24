using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PollE.DataAccess.Entities
{
    [Table("poll_option_images")]
    public class PollOptionImageEntity
    {
            [Key]
            [Column("id")]
            public int? Id { get; set; }
     
            [Column("poll_option")]
            public PollOptionEntity Option { get; set; }

            [Column("name")]
            public string Name { get; set; }
            
            [Column("type")]
            public string FileType { get; set; }
            
            [Column("extension")]
            public string Extension { get; set; }
            
            [Column("data")]
            public byte[] Data { get; set; }
    }
}