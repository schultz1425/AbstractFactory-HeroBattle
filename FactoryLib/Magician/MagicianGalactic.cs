using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magician
{
    public class MagicianGalactic : AbstractMagician
    {
        public string MagicianName;
        public override string Equipment()
        {
            return "Galactic Equipment";
        }
    }
}
