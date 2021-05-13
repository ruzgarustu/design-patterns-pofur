using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Memento
    {
        public int Age { get; set; }
        public decimal Weight { get; set; }
        public DateTime SnapshotDate { get; set; }

        public Memento(int age, decimal weight, DateTime snapshotDate)
        {
            Age = age;
            Weight = weight;
            SnapshotDate = snapshotDate;
        }
    }

}
