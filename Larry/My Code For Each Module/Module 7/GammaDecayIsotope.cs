using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7
{
    public class GammaDecayIsotope : RadioactiveIsotope
    {
        public override string Decay()
        {
            return this.Name + " is radiactive and undergoes gamma decay." + "\n";
        }
    }
}
