using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFXIVMacroGenerator.Generator
{
    public class GeneratorBase
    {
        public virtual bool CreateJsonData()
        {
            return true;
        }
    }
}
