using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace semiphp.Models
{
    public class Spec
    {
        [Key]
        public int fID { get; set; }
        public int fGetDate { get; set; }
        public string fName { get; set; }
        public string fInstitution { get; set; }
    }
}