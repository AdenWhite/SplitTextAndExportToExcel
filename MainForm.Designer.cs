
namespace TextSpliter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.pnlKeyword = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnSplit = new System.Windows.Forms.Button();
            this.grpHandled = new System.Windows.Forms.GroupBox();
            this.txtHandled = new System.Windows.Forms.TextBox();
            this.grpSplit = new System.Windows.Forms.GroupBox();
            this.btnAddKeyword = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.txtOutName = new System.Windows.Forms.TextBox();
            this.lblOutName = new System.Windows.Forms.Label();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnDeleteKeyword = new System.Windows.Forms.Button();
            this.chkDeleteSigns = new System.Windows.Forms.CheckBox();
            this.chkDeleteNumbers = new System.Windows.Forms.CheckBox();
            this.chkSplitFirstKey = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.pnlKeyword.SuspendLayout();
            this.grpHandled.SuspendLayout();
            this.grpSplit.SuspendLayout();
            this.grpDelete.SuspendLayout();
            this.pnlDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.txtInput);
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(354, 184);
            this.grpInput.TabIndex = 99;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "输入";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(6, 22);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInput.Size = new System.Drawing.Size(342, 156);
            this.txtInput.TabIndex = 0;
            // 
            // pnlKeyword
            // 
            this.pnlKeyword.AutoScroll = true;
            this.pnlKeyword.Controls.Add(this.splitter1);
            this.pnlKeyword.Location = new System.Drawing.Point(6, 22);
            this.pnlKeyword.Name = "pnlKeyword";
            this.pnlKeyword.Size = new System.Drawing.Size(151, 156);
            this.pnlKeyword.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 156);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(553, 252);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(151, 39);
            this.btnSplit.TabIndex = 4;
            this.btnSplit.Text = "删除并切割";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // grpHandled
            // 
            this.grpHandled.Controls.Add(this.txtHandled);
            this.grpHandled.Location = new System.Drawing.Point(12, 202);
            this.grpHandled.Name = "grpHandled";
            this.grpHandled.Size = new System.Drawing.Size(354, 184);
            this.grpHandled.TabIndex = 99;
            this.grpHandled.TabStop = false;
            this.grpHandled.Text = "处理后";
            // 
            // txtHandled
            // 
            this.txtHandled.Location = new System.Drawing.Point(7, 23);
            this.txtHandled.Multiline = true;
            this.txtHandled.Name = "txtHandled";
            this.txtHandled.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHandled.Size = new System.Drawing.Size(341, 155);
            this.txtHandled.TabIndex = 1;
            // 
            // grpSplit
            // 
            this.grpSplit.Controls.Add(this.pnlKeyword);
            this.grpSplit.Location = new System.Drawing.Point(372, 12);
            this.grpSplit.Name = "grpSplit";
            this.grpSplit.Size = new System.Drawing.Size(163, 184);
            this.grpSplit.TabIndex = 99;
            this.grpSplit.TabStop = false;
            this.grpSplit.Text = "分割词设置（一行一个）";
            // 
            // btnAddKeyword
            // 
            this.btnAddKeyword.Location = new System.Drawing.Point(409, 202);
            this.btnAddKeyword.Name = "btnAddKeyword";
            this.btnAddKeyword.Size = new System.Drawing.Size(80, 34);
            this.btnAddKeyword.TabIndex = 3;
            this.btnAddKeyword.Text = "增加分割词";
            this.btnAddKeyword.UseVisualStyleBackColor = true;
            this.btnAddKeyword.Click += new System.EventHandler(this.btnAddKeyword_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(553, 342);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(151, 40);
            this.btnOutput.TabIndex = 5;
            this.btnOutput.Text = "导出（选择路径）";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // txtOutName
            // 
            this.txtOutName.Location = new System.Drawing.Point(553, 314);
            this.txtOutName.Name = "txtOutName";
            this.txtOutName.Size = new System.Drawing.Size(151, 23);
            this.txtOutName.TabIndex = 100;
            this.txtOutName.Text = "切割导出表格";
            // 
            // lblOutName
            // 
            this.lblOutName.AutoSize = true;
            this.lblOutName.Location = new System.Drawing.Point(553, 294);
            this.lblOutName.Name = "lblOutName";
            this.lblOutName.Size = new System.Drawing.Size(80, 17);
            this.lblOutName.TabIndex = 101;
            this.lblOutName.Text = "导出文件名：";
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.pnlDelete);
            this.grpDelete.Location = new System.Drawing.Point(541, 12);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(163, 184);
            this.grpDelete.TabIndex = 100;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "删除词设置（一行一个）";
            // 
            // pnlDelete
            // 
            this.pnlDelete.AutoScroll = true;
            this.pnlDelete.Controls.Add(this.splitter2);
            this.pnlDelete.Location = new System.Drawing.Point(6, 22);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(151, 156);
            this.pnlDelete.TabIndex = 2;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 156);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // btnDeleteKeyword
            // 
            this.btnDeleteKeyword.Location = new System.Drawing.Point(586, 202);
            this.btnDeleteKeyword.Name = "btnDeleteKeyword";
            this.btnDeleteKeyword.Size = new System.Drawing.Size(80, 34);
            this.btnDeleteKeyword.TabIndex = 102;
            this.btnDeleteKeyword.Text = "增加删除词";
            this.btnDeleteKeyword.UseVisualStyleBackColor = true;
            this.btnDeleteKeyword.Click += new System.EventHandler(this.btnDeleteKeyword_Click);
            // 
            // chkDeleteSigns
            // 
            this.chkDeleteSigns.AutoSize = true;
            this.chkDeleteSigns.Location = new System.Drawing.Point(378, 243);
            this.chkDeleteSigns.Name = "chkDeleteSigns";
            this.chkDeleteSigns.Size = new System.Drawing.Size(139, 21);
            this.chkDeleteSigns.TabIndex = 103;
            this.chkDeleteSigns.Text = "删除,，.。;； :：符号";
            this.chkDeleteSigns.UseVisualStyleBackColor = true;
            this.chkDeleteSigns.CheckedChanged += new System.EventHandler(this.chkDeleteSigns_CheckedChanged);
            // 
            // chkDeleteNumbers
            // 
            this.chkDeleteNumbers.AutoSize = true;
            this.chkDeleteNumbers.Location = new System.Drawing.Point(378, 270);
            this.chkDeleteNumbers.Name = "chkDeleteNumbers";
            this.chkDeleteNumbers.Size = new System.Drawing.Size(111, 21);
            this.chkDeleteNumbers.TabIndex = 104;
            this.chkDeleteNumbers.Text = "删除阿拉伯数字";
            this.chkDeleteNumbers.UseVisualStyleBackColor = true;
            this.chkDeleteNumbers.CheckedChanged += new System.EventHandler(this.chkDeleteNumbers_CheckedChanged);
            // 
            // chkSplitFirstKey
            // 
            this.chkSplitFirstKey.AutoSize = true;
            this.chkSplitFirstKey.Checked = true;
            this.chkSplitFirstKey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSplitFirstKey.Location = new System.Drawing.Point(378, 297);
            this.chkSplitFirstKey.Name = "chkSplitFirstKey";
            this.chkSplitFirstKey.Size = new System.Drawing.Size(159, 21);
            this.chkSplitFirstKey.TabIndex = 105;
            this.chkSplitFirstKey.Text = "每一行仅分割第一个匹配";
            this.chkSplitFirstKey.UseVisualStyleBackColor = true;
            this.chkSplitFirstKey.CheckedChanged += new System.EventHandler(this.chkSplitFirstKey_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(566, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 11);
            this.label1.TabIndex = 106;
            this.label1.Text = "出现问题请联系作者 黄越（Aden）";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(711, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkSplitFirstKey);
            this.Controls.Add(this.chkDeleteNumbers);
            this.Controls.Add(this.chkDeleteSigns);
            this.Controls.Add(this.btnDeleteKeyword);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.lblOutName);
            this.Controls.Add(this.txtOutName);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnAddKeyword);
            this.Controls.Add(this.grpSplit);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.grpHandled);
            this.Controls.Add(this.btnSplit);
            this.Name = "MainForm";
            this.Text = "文本切割导出";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.pnlKeyword.ResumeLayout(false);
            this.grpHandled.ResumeLayout(false);
            this.grpHandled.PerformLayout();
            this.grpSplit.ResumeLayout(false);
            this.grpDelete.ResumeLayout(false);
            this.pnlDelete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpHandled;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Panel pnlKeyword;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox txtHandled;
        private System.Windows.Forms.GroupBox grpSplit;
        private System.Windows.Forms.Button btnAddKeyword;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.TextBox txtOutName;
        private System.Windows.Forms.Label lblOutName;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btnDeleteKeyword;
        private System.Windows.Forms.CheckBox chkDeleteSigns;
        private System.Windows.Forms.CheckBox chkDeleteNumbers;
        private System.Windows.Forms.CheckBox chkSplitFirstKey;
        private System.Windows.Forms.Label label1;
    }
}

