using System;

namespace DateTimeFormatterPro.Models
{
    public class FormatHistory
    {
        public int Id { get; set; }

        public DateTime OriginalDate { get; set; }

        public string FormatString { get; set; }

        public string Result { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}