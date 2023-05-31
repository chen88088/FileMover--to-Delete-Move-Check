using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDeleterToCleanAndCheckAndMove
{
    public class FileChecker
    {
        public Dictionary<string, string> MovementCheckDictionary { get; set; }

        public FileChecker(Dictionary<string, string> fileMovementCheckDictionary)
        {
            MovementCheckDictionary = fileMovementCheckDictionary;
        }

        public void BulidCheckList(string BackupSourcePathPrefix, string storageFilePathPrefix, List<string> checkList )
        {
            foreach(string filePath in MovementCheckDictionary.Keys)
            {
                // 建立預期結果[目的地儲存檔案路徑]
                string destinationStorageFilePath = filePath.Replace(BackupSourcePathPrefix, storageFilePathPrefix);
                checkList.Add(destinationStorageFilePath);
            } 
        }

        public void CheckWhetherFileMovementComplete(List<string> checkList)
        {
            // 建立 Dictionary 物件
            Dictionary<string, string> reportData= new Dictionary<string, string>();
            foreach (string path in checkList)
            {

                if (File.Exists(path))
                {
                    string successMsg = "恢復成功";
                    reportData.Add(path, successMsg);
                }
                else
                {
                    string failMsg = "無法恢復";
                    reportData.Add(path, failMsg);
                }
            }


            // 使用 SaveFileDialog 讓使用者指定存放位置與檔名
           SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV 檔 (*.csv)|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string csvPath = saveFileDialog.FileName;

                // 建立 StreamWriter 物件
                using (StreamWriter writer = new StreamWriter(csvPath))
                {
                    
                    // 寫入標題行
                    writer.WriteLine("檢查結果, 目標檔案路徑");

                    // 寫入每一行資料
                    foreach (KeyValuePair<string, string> pair in reportData)
                    {
                        writer.WriteLine($"{pair.Value} ,{pair.Key}");
                    }
                }
            }
        }
    }
}
