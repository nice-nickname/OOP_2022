using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public abstract class EnemyBase : IEnemy
    {
        public string Type { get; }
        public int LifeDuration { get; set; }
        public double ReproductionProbability { get; }

        protected EnemyBase(string type, int lifeDuration, double reproductionProbability)
        {
            Type = type;
            LifeDuration = lifeDuration;
            ReproductionProbability = reproductionProbability;
        }

        public override string ToString()
        {
            return $"Enemy type=\"{Type}\"";
        }
    }
}
