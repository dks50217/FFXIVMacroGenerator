using System;
using System.Collections.Generic;
using System.Text;

namespace DataGenerator.Model
{
    public class JobModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public List<ActionModel> ActionList { get; set; }
    }
}
