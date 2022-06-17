using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    abstract class Race
    {
        private List<Worker> workers = new List<Worker>();
        private List<Unit> units = new List<Unit>();

        public void addWorker(Worker worker)
            => workers.Add(worker);

        public void addUnit(Unit unit)
            => units.Add(unit);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n  Workers: ");
            foreach (Worker worker in workers)
                sb.Append(worker.ToString())
                    .Append(' ');

            sb.Append("\n  Units: ");
            foreach (Unit unit in units)
                sb.Append(unit.ToString())
                    .Append(' ');

            return sb.ToString();
        }
    }
}
