using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7
{
    public class RadioactiveIsotope : StableIsotope
    {
        //public virtual (RETURN TYPE) (METHOD name) 
        // Allows this method to become available/changeable in other DERIVED classes (POLYMORPHISM)
        public virtual string Decay()
        {
            return this.Name + " is radioactive." + "\n";
        
        }
    }
}
