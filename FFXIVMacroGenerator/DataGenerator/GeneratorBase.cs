using DataGenerator.Dict;
using DataGenerator.Interface;
using System;

namespace DataGenerator
{
    public abstract class GeneratorBase : IGenerator
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        private bool isExist { get; set; }

        public GeneratorBase()
        {
            this.Name = this.GetType().Name;
            this.isExist = GeneratorDict.pathMap.ContainsKey(this.Name);
            if (this.isExist) this.ImagePath = GeneratorDict.pathMap[this.Name];
        }

        public bool InitPath()
        {
            return true;
        }

        public virtual bool CreateJsonData()
        {
            return true;
        }
    }
}
