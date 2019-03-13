using MyLogbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLogbook.Entities
{
    public class SubjectGoup : DbEntity
    {
        [ForeignKey("gubjectId")]
        public Guid SubjectId { get; set; }

        [ForeignKey("groupId")]
        public Guid GroupId { get; set; }

        public Subject Subject { get; set; }
        public Group Group { get; set; } 
    }
}
