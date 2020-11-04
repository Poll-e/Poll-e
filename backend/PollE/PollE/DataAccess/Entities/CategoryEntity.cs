using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;

namespace PollE.DataAccess.Entities
{
    [Table("categories")]
    public class CategoryEntity
    {
        [Key]
        [Column("id")]
        public int? Id { get; set; }

        [Column("label")]
        public string Label { get; set; }
        
        public IEnumerable<PollEntity> Polls { get; set; }
    }
}