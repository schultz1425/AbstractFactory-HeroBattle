using Warrior;
using Archer;
using Magician;

namespace HeroBattle
{
    public abstract class AbstractHeroBattle
    {
        public string heroBattle;

        public abstract AbstractWarrior GetWarrior();
        public abstract AbstractArcher GetArcher();
        public abstract AbstractMagician GetMagician();

        public string Do()
        {
            return "hello";
        }
    }
}