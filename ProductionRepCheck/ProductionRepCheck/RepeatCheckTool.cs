using ProductionRepCheck.Entity;
using ProductionRepCheck.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionRepCheck
{
    public partial class RepeatCheckTool : Form
    {
        const string NS = "NS用";
        const string DVD = "DVD用";

        public RepeatCheckTool()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ファイルを選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportFilePathBtn_Click(object sender, EventArgs e)
        {
            // type choose
            if (string.IsNullOrEmpty(typeChooseCmb.Text))
            {
                MessageBox.Show("ファイルタイプを指定してください。\nご確認ください。");
                return;
            }

            string filter = string.Empty;
            if (NS.Equals(typeChooseCmb.Text))
            {
                filter = "*.csv|*.CSV";
            }
            if (DVD.Equals(typeChooseCmb.Text))
            {
                filter = "*.pm7|*.PM7";
            }

            string filePath = FileUtil.FileSelect(importFilePathTb.Text, filter);

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("ファイルを選択してください");
            }
            else
            {
                importFilePathTb.Text = filePath;
            }
        }

        /// <summary>
        /// フォルダ選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportFilePathBtn_Click(object sender, EventArgs e)
        {
            string FolderPath = FileUtil.FolderSelect(exportFilePathTb.Text, "選択出力パスフォルダ");
            if (string.IsNullOrEmpty(FolderPath))
            {
                MessageBox.Show("フォルダを指定してください");
            }
            else
            {
                exportFilePathTb.Text = FolderPath;
            }
        }

        /// <summary>
        /// チェック実行ボタンイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataCheckBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(typeChooseCmb.Text))
            {
                MessageBox.Show("ファイルタイプを指定してください。\nご確認ください。");
                typeChooseCmb.Focus();
                return;
            }

            if (!File.Exists(importFilePathTb.Text))
            {
                MessageBox.Show("ファイルパスが入力しません。\nご確認ください。");
                importFilePathTb.Focus();
                return;
            }

            if (string.IsNullOrEmpty(exportFilePathTb.Text))
            {
                MessageBox.Show("結果出力先が入力しません。\nご確認ください。");
                exportFilePathTb.Focus();
                return;
            }

            this.Result.Text = "执行中";

            string dataInputPath = importFilePathTb.Text;
            string dataOutPath = exportFilePathTb.Text;           

           if (typeChooseCmb.Text == NS)
            {
                dataOutPath = Path.Combine(dataOutPath, "test.CSV");
                ThreadRun<NSProductionInfoEntity>(dataInputPath, dataOutPath);            
            }
            if (typeChooseCmb.Text == DVD)
            {
                dataOutPath = Path.Combine(dataOutPath, "PTNSK.CSV");
                ThreadRun<DVDProductionInfoEntity>(dataInputPath, dataOutPath);
            }
        }

        private delegate void ResultDelegate(object result);

        private void ResultThreadRun(object result)
        {
            Thread thread = new Thread(SetReult);
            thread.Start(result);
        }

        private void SetReult(object result)
        {
            if (Result.InvokeRequired)
            {
                ResultDelegate rd = new ResultDelegate(SetReult);
                Result.Invoke(rd, result);
            }
            else
            {
                Result.Text = result.ToString();
            }
        }

        private void ThreadRun<T>(string inPath, string outPath) where T : ProductionInfoEntity, new()
        {
            Thread thread = new Thread(new ThreadStart(delegate
            {
                DataCheck<T> dataCheck = new DataCheck<T>(inPath, outPath);
                dataCheck.Run(out string result);
                ResultThreadRun(result);
            }));
            thread.Start();           
        }       
    }
}
