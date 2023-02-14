using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Warrior;
using Archer;
using Magician;

namespace HeroBattle
{
    public class FightColiseum : AbstractHeroBattle
    {
        public override AbstractWarrior GetWarrior()
        {
            return new WarriorColiseum();
        }
        public override AbstractArcher GetArcher()
        {
            return new ArcherColiseum();
        }
        public override AbstractMagician GetMagician()
        {
            return new MagicianColiseum();
        }
    }
}
