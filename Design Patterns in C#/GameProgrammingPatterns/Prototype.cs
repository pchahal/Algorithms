using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace GameProgrammingPatterns
{
    public abstract class Monster
    {
        public abstract Monster clone();
    }

    public class Ghost : Monster
    {
        private readonly int _health;
        private readonly int _speed;

        public Ghost(int health,int speed)
        {
            _health = health;
            _speed = speed;
        }

        public override Monster clone()
        {
            return new Ghost(_health,_speed);
        }
    }

    public class Spawner
    {
        public Spawner(Monster _prototype)
        {
            prototype = _prototype;
        }

        public Monster SpawnMonster()
        {
            return prototype.clone();
        }

        private Monster prototype;
    }
}
