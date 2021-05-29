using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionRepCheck.Util
{
    class FileUtil
    {
        /// <summary>
        /// ファイル選択
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public static string FileSelect(string oldFilePath, string filter)
        {
            string filePath = oldFilePath;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = filter;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(ofd.FileName))
                {
                    filePath = ofd.FileName;
                }
            }
            return filePath;
        }

        /// <summary>
        /// フォルダ選択
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        public static string FolderSelect(string oldFolderPath,string description)
        {
            string folderPath = oldFolderPath;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = description;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(fbd.SelectedPath))
                {
                    folderPath = fbd.SelectedPath;
                }
            }
            return folderPath;
        }
    }
}
