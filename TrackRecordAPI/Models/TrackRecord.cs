using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackRecordAPI.Models
{
    [Table("tblTrackRecord")]
    public class TrackRecord
    {
        [Key]
        [Column("TID")]
        public int TrackingId { get; set; }

        [Column("UpdatedColumn", TypeName = "varchar")]
        [MaxLength(50)]
        public string UpdatedColumn { get; set; }

        [Column("OldValue", TypeName = "varchar")]
        [MaxLength(50)]
        public string OldValue { get; set; }

        [Column("UpdatedValue", TypeName = "varchar")]
        [MaxLength(50)]
        public string UpdatedValue { get; set; }
        public TimeSpan UpdatedTime { get; set; }

    }
}
