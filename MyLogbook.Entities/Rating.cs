using MyLogbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLogbook.Entities
{
    [Table("ratings")]
    public class Rating : DbEntity
    {
        [Column("bal")]
        public int Bal { get; set; }

        [ForeignKey("studenId")]
        public Guid StudenId { get; set; }

        [ForeignKey("subjectId")]
        public Guid SubjectId { get; set; }

        public Student Student { get; set; }
        public Subject Subject { get; set; } 


    }
}
