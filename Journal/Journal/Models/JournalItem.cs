using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Journal.Models
{
    public class JournalItem
    {
        [Key]        public int Id { get; set; }        public string voucher_code { get; set; }        public DateTime date { get; set; }        public string payee { get; set; }
    }
}