using MyLogbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLogbook.Entities
{
    [Table("students")]
    public class Student:DbEntity
    {
        [Column("firstName")]
        [StringLength(64)]
        public string FirstName { get; set; }

        [Column("lastName")]
        [StringLength(64)]
        public string LastName { get; set; }

        [ForeignKey("groupId")]
        public Guid GroupId { get; set; }

        public virtual Group Group { get; set; }

        public List<Rating> Rating { get; set; }


    }
}
