using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class HeavyEnemy : EnemyBase
    {
        public HeavyEnemy()
                : base("Heavy", 6, 0.15)
        {
        }
    }

    public class FastEnemy : EnemyBase
    {
        public FastEnemy()
                : base("Fast", 2, 0.5)
        {
        }
    }
}
