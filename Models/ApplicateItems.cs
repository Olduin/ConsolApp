using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolApp.Models
{
    public class ApplicateItems
    {
        public int ID { get; set;  }
        public string StateNumber { get; set; }
        //public vehicle
        public string DescriptionWork { get; set; }
        public DateTime? TimeFiling { get; set; }
        public DateTime? DurationUse { get; set; }
        public string AddressSupply { get; set; }
    }
}
