using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Oracle.DB.Models.Oracle
{
    public partial class TBL_PERSON
    {
        [Key]
        public decimal PERSONID { get; set; }
        public string LASTNAME { get; set; }
        public string FIRSTNAME { get; set; }
        public decimal? AGE { get; set; }
    }
}
