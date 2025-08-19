using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeeTypeForm.Models
{
    public class FeeType
    {
        public int FeeTypeID { get; set; }
        public string FeeName { get; set; } = "";
        public Decimal Amount { get; set; }
        public int ApplicableGradeID { get; set; }
        public bool ActiveStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } = "";
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; } = "";
        public bool IsDeleted { get; set; }
    }
}
