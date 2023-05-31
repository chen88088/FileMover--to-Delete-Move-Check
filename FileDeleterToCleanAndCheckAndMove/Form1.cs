using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Configuration;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Reflection;

namespace FileDeleterToCleanAndCheckAndMove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 用來存放待刪除檔案路徑的list
        /// </summary>
        private static List<string> deleteFileList = new List<string>();

        /// <summary>
        /// 用來存放備份檔案路徑(key)/搬運檔案存放路徑(value)的字典
        /// </summary>
        private static Dictionary<string, string> FileMovementRecordDictionary = new Dictionary<string, string>();

        /// <summary>
        /// 用來存放比對項目(應該要搬運成功而存在的檔案)的List
        /// </summary>
        private static List<string> restoreFilePathCheckList = new List<string>();

        /// <summary>
        /// 讀取檔案的按鈕
        /// </summary>
        /// <param name="sender">控件对象</param>
        /// <param name="e">记录事件传递过来的额外信息</param>
        private void ReadFileBnt_Click(object sender, EventArgs e)
        {
            // 清空1.刪除檔案清單list 2.備份檔案路徑清單List 3.紀錄搬運來源與目的地字典
            deleteFileList.Clear();
            restoreFilePathCheckList.Clear();
            FileMovementRecordDictionary.Clear();

            // 顯示讀檔路徑並且存到變數filePath
            string filePath = ReadFileShowPathOnTextBox();

            if (filePath == string.Empty)
            {
                // 使用者防呆: 點選"讀取檔案"按鈕，卻沒有選擇檔案讀取
                // 對策: 啥都不做
            }
            else
            {
                // 讀取檔案清單
                FileReader fileReader = new FileReader(filePath);
                deleteFileList = fileReader.ReadFileAndStorePath();
            }
        }

       

        /// <summary>
        /// 讀取檔案對話視窗抓取檔案路徑並顯示出來
        /// </summary>
        /// <returns>檔案路徑名稱</returns>
        public string ReadFileShowPathOnTextBox()
        {
            OpenFileDialog openReadFileDialog = new OpenFileDialog();

            openReadFileDialog.Title = "請開啟(.txt)檔案";
            string fileName = string.Empty;

            if (openReadFileDialog.ShowDialog() == DialogResult.OK)
            {
                //顯示路徑
                fileName = openReadFileDialog.FileName;
                FilePathTextBox.Text = fileName;
            }
            return fileName;
        }

        private void FilePathTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CleanFileBnt_Click(object sender, EventArgs e)
        {
            if (deleteFileList.Count() != 0 )
            {
                FileCleaner fileCleaner = new FileCleaner(deleteFileList);
                fileCleaner.CleanFile();
            }
            else
            {
                string checkRemindMsg = "請確認是否有讀取清單";
                MessageBox.Show(checkRemindMsg);
            }            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FilePathChangeBnt_Click(object sender, EventArgs e)
        {
            string encryptionPattern = RegexExpressTextBox.Text;
            string[] encryptedFilePathPrefix = EncryptedFiePathPrefixTextBox.Text.Split(',');
            string backupSourcePathPrefix = BacpUpSourcePathPrefixTextBox.Text;

            // 檢查是否有讀取清單--> 只要有內容則list必然有東西-->除非沒讀檔才導致首項為空
            if (deleteFileList.Count() == 0)
            {
                string checkRemindMsg = "請確認是否有讀取清單";
                MessageBox.Show(checkRemindMsg);
            }
            else if (encryptionPattern == string.Empty)
            {
                string checkRemindMsg = "請輸入被加密的pattern";
                MessageBox.Show(checkRemindMsg);
            }
            //若是"加密檔案路徑開頭"輸入為空-- > 陣列初項必為空字串--->用來檢查使用者輸入
            else if (encryptedFilePathPrefix.First() == string.Empty)
            {
                string inputRemindMsg = "請輸入被加密(欲更改)的檔案路徑開頭";
                MessageBox.Show(inputRemindMsg);
            }
            else if (backupSourcePathPrefix == string.Empty)
            {
                string inputRemindMsg = "請輸入備份檔案來源路徑開頭";
                MessageBox.Show(inputRemindMsg);
            }
            else
            {
                FileMover fileMover = new FileMover(backupSourcePathPrefix);

                // 將備份檔案的路徑加入清查用的字典
                foreach (string encrytedFilePath in deleteFileList)
                {
                    string decrytedFilePath = fileMover.CaptureFilePath(encrytedFilePath, encryptionPattern);
                    string backupFilePath = fileMover.GetBackupFilePath(decrytedFilePath, encryptedFilePathPrefix);

                    fileMover.AddBackupFilePathIntoDictionary(FileMovementRecordDictionary, backupFilePath);
                }
                string updateFileCompleteMsg = "建立備份檔案路徑成功";
                MessageBox.Show(updateFileCompleteMsg);
            }
        }

        private void FileMoveBnt_Click(object sender, EventArgs e)
        {
            string backupSourcePathPrefix = BacpUpSourcePathPrefixTextBox.Text;
            string storageFilePathPrefix = StoreFilePathPrefixTextBox.Text;

            if (FileMovementRecordDictionary.Keys.Count() == 0)
            {
                string checkRemindMsg = "請確認是否有讀取清單並完成檔案路徑更改";
                MessageBox.Show(checkRemindMsg);
            }
            else if (storageFilePathPrefix == string.Empty)
            {
                string inputRemindMsg = "請輸入檔案搬運存檔路徑開頭";
                MessageBox.Show(inputRemindMsg);
            }
            else
            {
                FileMover fileMover = new FileMover(backupSourcePathPrefix);
                fileMover.MoveFile(storageFilePathPrefix, FileMovementRecordDictionary);
            }
        }

        private void CheckFileMovementResultBnt_Click(object sender, EventArgs e)
        {
            string backupSourcePathPrefix = BacpUpSourcePathPrefixTextBox.Text;
            string storageFilePathPrefix = StoreFilePathPrefixTextBox.Text;

            if (FileMovementRecordDictionary.Values.Count() == 0)
            {
                string checkRemindMsg = "請先確認已完成檔案搬運";
                MessageBox.Show(checkRemindMsg);
            }
            else
            {
                FileChecker fileChecker = new FileChecker(FileMovementRecordDictionary);

                fileChecker.BulidCheckList(backupSourcePathPrefix, storageFilePathPrefix, restoreFilePathCheckList);

                fileChecker.CheckWhetherFileMovementComplete(restoreFilePathCheckList);
            }
            
        }

        private void StoreFilePathPrefix_Click(object sender, EventArgs e)
        {

        }

        private void StoreFilePathPrefixTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BacpUpSourcePathPrefixLabel_Click(object sender, EventArgs e)
        {

        }

        private void EncryptedFiePathPrefixLabel_Click(object sender, EventArgs e)
        {

        }

        private void BacpUpSourcePathPrefixTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EncryptedFiePathPrefixTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FilePathTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}