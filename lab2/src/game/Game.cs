using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    using System.Net.Mime;
    using System.Threading;

    public class Game
    {
        private readonly int enemiesStartCount;
        public static readonly ILogger Logger = new ConsoleLogger();
        public static readonly Random Random = new Random();

        private List<PoolItem> currentEnemies;

        private EnemyPool pool;

        public Game(int enemiesStartCount)
        {
            this.enemiesStartCount = enemiesStartCount;
            currentEnemies = new List<PoolItem>();
            pool = new EnemyPool(enemiesStartCount + 10, new RandomEnemyFactory());
        }

        private void AddEnemy()
        {
            var e = pool.GetEnemy();
            currentEnemies.Add(e);
            Logger.Log($"Enemy created. {e.Value}");
        }

        private void PrintEnemies()
        {
            Logger.Log($"Current enemies: count={currentEnemies.Count}");
            for (int i = 0; i < currentEnemies.Count; i++)
            {
                Logger.Log($"{i}: Enemy LifeDuration={currentEnemies[i].Value.LifeDuration} ReproductionProbability={currentEnemies[i].Value.LifeDuration} Type={currentEnemies[i].Value.Type}");
            }
            Logger.Log("");
        }

        private void IsGameOver()
        {
            if (!currentEnemies.Any())
            {
                Logger.Log("THERE IS NO MORE ENEMIES, GAME OVER...");
                Environment.Exit(0);
            }
        }
        
        public void Start()
        {
            for (int i = 0; i < enemiesStartCount; i++)
            {
                AddEnemy();
            }

            Logger.Log("");
            int loop = 0;
            while (true)
            {
                Logger.Log($"=== GENERATION #{loop} STARTS");

                IsGameOver();
                PrintEnemies();

                var toAdd = new List<PoolItem>();
                var toDelete = new List<PoolItem>();

                foreach (var enemy in currentEnemies)
                {
                    var p = enemy.Value.ReproductionProbability;
                    var p1 = Random.NextDouble();
                    if (p1 <= p)
                    {
                        var e = pool.GetEnemy();
                        Logger.Log($"+: Enemy created. {e.Value}");
                        toAdd.Add(e);
                    }
                }


                foreach (var enemy in currentEnemies)
                {
                    enemy.Value.LifeDuration--;
                    if (enemy.Value.LifeDuration == 0)
                    {
                        toDelete.Add(enemy);
                    }
                }
                foreach (var del in toDelete)
                {
                    Logger.Log($"-: Enemy died. {del.Value}");
                    currentEnemies.Remove(del);
                }

                currentEnemies.AddRange(toAdd);

                Logger.Log($"=== GENERATION #{loop++} ENDS");
                Console.ReadLine();
            }
        }
    }
}
