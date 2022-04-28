using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    using System.Collections;

    public class PoolItem
    {
        public int Id { get; }
        public IEnemy Value { get; }
        public bool IsUsed { get; set; }

        public PoolItem(IEnemy value, int id)
        {
            Value = value;
            Id = id;
        }

        public override bool Equals(object obj)
        {
            return obj != null && this.Id == ((PoolItem)obj).Id;
        }
    }

    public class EnemyPool
    {
        private List<PoolItem> pool;
        private readonly IEnemyFactory factory;

        public int MaxPoolItems { get; private set; }
        public float ResizeFactor { get; }


        public EnemyPool(int maxPoolItems, IEnemyFactory factory, float resizeFactor = 1.5f)
        {
            pool = new List<PoolItem>();
            MaxPoolItems = maxPoolItems;
            this.factory = factory;
            ResizeFactor = resizeFactor;

            for (var i = 0; i < MaxPoolItems; i++)
            {
                pool.Add(new PoolItem(factory.Create(), i));
            }
        }

        public PoolItem GetEnemy()
        {
            for (int i = 0; i < MaxPoolItems; i++)
            {
                if (!pool[i].IsUsed)
                {
                    pool[i].IsUsed = true;
                    return pool[i];
                }
            }

            int oldSize = MaxPoolItems;
            MaxPoolItems = (int)(MaxPoolItems * ResizeFactor);

            var newList = new List<PoolItem>();
            newList.AddRange(pool);
            for (int i = oldSize; i < MaxPoolItems; i++)
            {
                newList.Add(new PoolItem(factory.Create(), i));
            }

            pool = newList;
            return GetEnemy();
        }

        public void FreeEnemy(PoolItem enemy)
        {
            pool[enemy.Id].IsUsed = false;
        }
    }
}
