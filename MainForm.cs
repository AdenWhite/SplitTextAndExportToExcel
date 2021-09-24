using NPOI.HSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TextSpliter
{
    public partial class MainForm : Form
    {
        string inStr, outStr, outName = "切割导出表格";
        List<TextBox> txtSplitKeywordList = new List<TextBox>();//分割关键词组的列表
        List<TextBox> txtDeleteKeywordList = new List<TextBox>();//删除关键词组的列表
        List<string[]> txtHandledList;
        bool isDeleteSigns, isDeleteNumbers, isSplitFirstKey;

        public MainForm()
        {
            InitializeComponent();
            AddNewSplitKeyword();
            AddNewSplitKeyword();
            AddNewDeleteKeyword();
            AddNewDeleteKeyword();
            isDeleteSigns = chkDeleteSigns.Checked;
            isDeleteNumbers = chkDeleteNumbers.Checked;
            isSplitFirstKey = chkSplitFirstKey.Checked;
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            txtHandled.Text = "";
            string[] delims = new string[txtSplitKeywordList.Count];
            string[] deleteKeys = new string[txtDeleteKeywordList.Count];
            for (int i = 0; i < txtSplitKeywordList.Count; i++)
            {
                delims[i] = Regex.Unescape(txtSplitKeywordList[i].Text);//防止转义
            }
            for (int i = 0; i < txtDeleteKeywordList.Count; i++)
            {
                deleteKeys[i] = Regex.Unescape(txtDeleteKeywordList[i].Text);//防止转义
            }
            txtHandledList = Split(Delete(txtInput.Text, deleteKeys), delims);
            foreach (var i in txtHandledList)
            {
                foreach (var j in i)
                {
                    txtHandled.Text += j;
                    txtHandled.Text += @" ";
                }
                txtHandled.Text += Environment.NewLine;//还原之前的行
            }
        }

        private void btnAddKeyword_Click(object sender, EventArgs e)
        {
            AddNewSplitKeyword();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            Output(txtOutName.Text, txtHandledList);
        }

        private void btnDeleteKeyword_Click(object sender, EventArgs e)
        {
            AddNewDeleteKeyword();
        }

        private void chkSplitFirstKey_CheckedChanged(object sender, EventArgs e)
        {
            isSplitFirstKey = chkSplitFirstKey.Checked;
        }

        private void chkDeleteSigns_CheckedChanged(object sender, EventArgs e)
        {
            isDeleteSigns = chkDeleteSigns.Checked;
        }

        private void chkDeleteNumbers_CheckedChanged(object sender, EventArgs e)
        {
            isDeleteNumbers = chkDeleteNumbers.Checked;
        }

        public void AddNewKeywordTextBox(List<TextBox> textBoxesList, Panel parent)
        {
            TextBox textBox = new TextBox();
            textBoxesList.Add(textBox);
            textBox.Parent = parent;
            if (textBoxesList.IndexOf(textBox) == 0)
            {
                textBox.Location = new Point(9, 3);
            }
            else
            {
                Point lastBox = textBoxesList[textBoxesList.IndexOf(textBox) - 1].Location;
                textBox.Location = new Point(lastBox.X, lastBox.Y + 30);
            }
        }

        public void AddNewSplitKeyword()
        {
            AddNewKeywordTextBox(txtSplitKeywordList, pnlKeyword);
            //TextBox textBox = new TextBox();
            //txtSplitKeywordList.Add(textBox);
            //textBox.Parent = pnlKeyword;
            //if (txtSplitKeywordList.IndexOf(textBox) == 0)
            //{
            //    textBox.Location = new Point(9, 3);
            //}
            //else
            //{
            //    Point lastBox = txtSplitKeywordList[txtSplitKeywordList.IndexOf(textBox) - 1].Location;
            //    textBox.Location = new Point(lastBox.X, lastBox.Y + 30);
            //}
        }

        public void AddNewDeleteKeyword()
        {
            AddNewKeywordTextBox(txtDeleteKeywordList, pnlDelete);
            //TextBox textBox = new TextBox();
            //txtDeleteKeywordList.Add(textBox);
            //textBox.Parent = pnlDelete;
            //if (txtDeleteKeywordList.IndexOf(textBox) == 0)
            //{
            //    textBox.Location = new Point(9, 3);
            //}
            //else
            //{
            //    Point lastBox = txtDeleteKeywordList[txtDeleteKeywordList.IndexOf(textBox) - 1].Location;
            //    textBox.Location = new Point(lastBox.X, lastBox.Y + 30);
            //}
        }

        public void Output(string outName, List<string[]> txtHandledList)
        {
            if (txtHandledList != null)
            {
                var workbook = new HSSFWorkbook();
                var table = workbook.CreateSheet("切割导出");
                for (var i = 0; i < txtHandledList.Count; i++)
                {
                    var row = table.CreateRow(i);
                    for (int j = 0; j < txtHandledList[i].Length; j++)
                    {
                        var cell = row.CreateCell(j);
                        cell.SetCellValue(txtHandledList[i][j]);
                    }
                }
                FolderBrowserDialog path = new FolderBrowserDialog();
                path.ShowDialog();
                if (path.SelectedPath != "")
                {
                    string outPath = Path.Combine(path.SelectedPath, outName + @".xls");
                    while (File.Exists(outPath))
                    {
                        outName += "重复";
                        outPath = Path.Combine(path.SelectedPath, outName + @".xls");
                    }
                    using (var fs = File.OpenWrite(outPath))
                    {
                        workbook.Write(fs);   //向打开的这个xls文件中写入表并保存。
                        MessageBox.Show("生成成功！");
                    }
                }
            }
            else
            {
                MessageBox.Show("没有处理过的文本！");
            }
        }

        /// <summary>
        /// 删除文本
        /// </summary>
        /// <param name="text">输入文本</param>
        /// <param name="delKeys">删除关键词组</param>
        /// <returns>输出文本</returns>
        public string Delete(string text, string[] delKeys)
        {
            string delText = text;
            if (isDeleteNumbers)
            {
                delText = new Regex("[0-9]").Replace(delText, "");
            }
            if (isDeleteSigns)
            {
                delText = new Regex(@"[,，.。;； :：]").Replace(delText, "");
            }
            for (int i = 0; i < delKeys.Length; i++)
            {
                if (delKeys[i] != null)
                {
                    delText = new Regex(delKeys[i]).Replace(delText, "");
                }
            }
            return delText;
        }

        /// <summary>
        /// 分割文本
        /// </summary>
        /// <param name="text">输入文本</param>
        /// <param name="delims">分割关键词组</param>
        /// <returns>输出文本</returns>
        public List<string[]> Split(string text, string[] delims)
        {
            string[] firstSplitted = Regex.Split(text, "\n");
            List<string[]> secondSplitted = new List<string[]>();
            for (int i = 0; i < delims.Length; i++)
            {
                for (int j = 0; j < firstSplitted.Length; j++)
                {
                    if (isSplitFirstKey)
                    {
                        firstSplitted[j] = new Regex(delims[i]).Replace(firstSplitted[j], "@", 1);
                    }
                    else
                    {
                        firstSplitted[j] = new Regex(delims[i]).Replace(firstSplitted[j], "@");
                    }
                }
            }
            for (int j = 0; j < firstSplitted.Length; j++)
            {
                secondSplitted.Add(Regex.Split(firstSplitted[j], "@"));
            }
            return secondSplitted;
        }
    }
}
