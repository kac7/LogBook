using MyLogbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLogbook.Entities
{
    [Table("subjects")]
    public class Subject : DbEntity
    {
        [Column("title")]
        [StringLength(64)]
        public string Title { get; set; }

        [ForeignKey("teacherId")]
        public Guid TeacherId { get; set; }

        public Teacher Teacher { get; set; }

        public List<Rating> Rating { get; set; } 
        public List<SubjectGoup> SubjectGoup { get; set; } 

    }
}
