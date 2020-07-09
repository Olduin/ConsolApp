using ConsolApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolApp
{
    public class Applicate
    {
        public int ID { get; set; }
        public DateTime? Date { get; set; }
        public Type type { get; set; } 
        public virtual IList<ApplicateItems> ApplicateItems { get; set;}
    }
}
