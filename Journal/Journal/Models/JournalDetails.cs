using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Journal.Models
{
    public class JournalDetails
    {
        [Key]
        public int Id { get; set; }
        public string journal_id { get; set; }
        public string sign { get; set; }
        public string type { get; set; }
        public string account { get; set; }
        public string reftype { get; set; }
        public string refno { get; set; }
        public float amount { get; set; }
        public string costcenter { get; set; }
        public string narration { get; set; }
    }
}