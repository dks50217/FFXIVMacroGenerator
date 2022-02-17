using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFXIVMacroGenerator.Models
{
    public class JobModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public List<ActionModel> ActionList { get; set; }
    }
}
