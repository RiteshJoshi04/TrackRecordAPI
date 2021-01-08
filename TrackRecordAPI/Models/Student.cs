using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackRecordAPI.Models
{
    [Table("tblStudent")]
    public class Student
    {
        public int StudentId { get; set; }

        [Column("FirstName", TypeName ="varchar")]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Column("LastName", TypeName = "varchar")]
        [MaxLength(50)]
        public string LastName { get; set; }
        public int StudentAge { get; set; }
        public DateTime DOB { get; set; }
        public bool IsUpdated { get; set; }
    }
}
