using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDeleterToCleanAndCheckAndMove
{
    /// <summary>
    /// 清除檔案的物件
    /// </summary>
    public class FileCleaner
    {
        /// <summary>
        /// 屬性: 待清除的檔案清單
        /// </summary>
        public List<string> TargetFileList { get; set; }

        /// <summary>
        /// 建構子 
        /// </summary>
        /// <param name="DeleteFileList">檔案清單</param>
        public FileCleaner(List<string>DeleteFileList)
        {
            TargetFileList = DeleteFileList;
        }

        /// <summary>
        /// 方法--清除檔案
        /// </summary>
        /// <param name="TargetFileList">待清除的檔案名單</param>
        /// <returns></returns>
        public void CleanFile()
        {
            foreach (string pathofFile in TargetFileList)
            {
                try
                {
                    File.Delete(pathofFile);
                    
                }
                catch (Exception e)
                {
                    string fileMsg = string.Format($"刪除檔案時出現錯誤: {0}", e.Message);
                    
                    Console.WriteLine( fileMsg);
                }
            }
            string successMsg = "檔案刪除成功";
            MessageBox.Show(successMsg);
        }

    }
}
