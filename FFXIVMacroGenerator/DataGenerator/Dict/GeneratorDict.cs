using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator.Dict
{
    public static class GeneratorDict
    {
        public static readonly Dictionary<string, string> pathMap = new Dictionary<string, string>()
        {
            { "ActionDataGenerator", "/Image/FFXIVIcons Battle(PvE)" },
            { "CraftDataGenerator", "/Image/FFXIVIcons Craft" },
        };
    }
}
