using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public interface IEnemyFactory
    {
        IEnemy Create();
    }

    public class RandomEnemyFactory : IEnemyFactory

    {
        private static readonly Random random = new Random();


        public IEnemy Create()
        {
            var type = random.Next() % 2;
            var nameLength = random.Next() % 5 + 1;
            switch (type)
            {
                case 0:
                    return new FastEnemy();
                case 1: 
                    return new HeavyEnemy();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
