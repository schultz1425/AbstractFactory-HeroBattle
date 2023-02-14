using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magician
{
    public class MagicianColiseum : AbstractMagician
    {
        public string MagicianName;
        public override string Equipment()
        {
            return "Coliseum Equipment";
        }
    }
}
