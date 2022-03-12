using DataGenerator;
using System;

namespace GeneratorTool
{
    class Program
    {
        static void Main(string[] args)
        {
            ActionDataGenerator gen = new ActionDataGenerator();
            gen.CreateJsonData();
        }
    }
}
