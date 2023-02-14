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
    public class FightGalactic : AbstractHeroBattle
    {
        public override AbstractWarrior GetWarrior()
        {
            return new WarriorGalactic();
        }
        public override AbstractArcher GetArcher()
        {
            return new ArcherGalactic();
        }
        public override AbstractMagician GetMagician()
        {
            return new MagicianGalactic();
        }
    }
}
