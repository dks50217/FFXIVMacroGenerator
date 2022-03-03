using DataGenerator.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataGenerator
{
    class ActionDataGenerator : GeneratorBase
    {
        private string _rootPath;

        public ActionDataGenerator(string path)
        {
            _rootPath = path;
        }

        /// <summary>
        /// 建立Action Json資料結構
        /// </summary>
        /// <returns>True:成功/False:失敗</returns>
        public override bool CreateJsonData()
        {
            List<JobModel> JobModelList = new List<JobModel>();
            var imagePath = $"{_rootPath}/Image/FFXIVIcons Battle(PvE)";
            string[] dirs = Directory.GetDirectories(imagePath, "*", SearchOption.AllDirectories);

            foreach (var path in dirs)
            {
                JobModel jobModel = new JobModel();
                List<ActionModel> actionModelList = new List<ActionModel>();
                var fileList = Directory.GetFiles(path);
                var dirName = new DirectoryInfo(path).Name;

                if (dirName.Contains("_"))
                {
                    var dirArray = dirName.Split('_');
                    jobModel.ID = dirArray[0];
                    jobModel.Name = dirArray[1];
                }

                foreach (var actionPath in fileList)
                {
                    ActionModel actionModel = new ActionModel();
                    actionModel.ActionName = Path.GetFileName(actionPath);
                    actionModel.ID = jobModel.ID;
                    actionModel.Path = actionPath;
                    actionModelList.Add(actionModel);
                }

                jobModel.ActionList = actionModelList;
                JobModelList.Add(jobModel);
            }


            return true;
        }
    }
}
