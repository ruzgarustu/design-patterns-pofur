using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class PofurStatus
    {
        public int PofurAge { get; set; }
        public decimal PofurWeight { get; set; }
        public DateTime SnapshotDate { get; set; }

        public Memento StoreHappyMoment(PofurStatus statusToStore)
        {
            return new Memento(statusToStore.PofurAge, statusToStore.PofurWeight, statusToStore.SnapshotDate);
        }

        public void RestoreHappyMoment(Memento statusToRestore)
        {
            this.SnapshotDate = statusToRestore.SnapshotDate;
            this.PofurAge = statusToRestore.Age;
            this.PofurWeight = statusToRestore.Weight;
        }
    }
}
