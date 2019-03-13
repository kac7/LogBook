using MyLogbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLogbook.Entities
{
    [Table("teachers")]
    public class Teacher: DbEntity
    {
        [Column("firstname")]
        [StringLength(64)]
        public string FirstName { get; set; }

        [Column("lastname")]
        [StringLength(64)]
        public string LastName { get; set; }

        public List<Subject> Subjects { get; set; } 
    }
}
