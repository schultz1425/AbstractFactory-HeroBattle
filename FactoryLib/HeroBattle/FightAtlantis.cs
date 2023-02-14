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
    public class FightAtlantis : AbstractHeroBattle
    {
        public override AbstractWarrior GetWarrior()
        {
            return new WarriorAtlantis();
        }
        public override AbstractArcher GetArcher()
        {
            return new ArcherAtlantis();
        }
        public override AbstractMagician GetMagician()
        {
            return new MagicianAtlantis();
        }
    }
}
