namespace ProductionRepCheck
{
    partial class RepeatCheckTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exportFilePathBtn = new System.Windows.Forms.Button();
            this.exportFilePathTb = new System.Windows.Forms.TextBox();
            this.exportFilePathLbl = new System.Windows.Forms.Label();
            this.dataCheckBtn = new System.Windows.Forms.Button();
            this.tyoeChooseLbl = new System.Windows.Forms.Label();
            this.typeChooseCmb = new System.Windows.Forms.ComboBox();
            this.importFilePathBtn = new System.Windows.Forms.Button();
            this.importFilePathTb = new System.Windows.Forms.TextBox();
            this.importFilePathLbl = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exportFilePathBtn
            // 
            this.exportFilePathBtn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.exportFilePathBtn.Location = new System.Drawing.Point(544, 123);
            this.exportFilePathBtn.Name = "exportFilePathBtn";
            this.exportFilePathBtn.Size = new System.Drawing.Size(71, 26);
            this.exportFilePathBtn.TabIndex = 23;
            this.exportFilePathBtn.Text = "参照";
            this.exportFilePathBtn.UseVisualStyleBackColor = true;
            this.exportFilePathBtn.Click += new System.EventHandler(this.ExportFilePathBtn_Click);
            // 
            // exportFilePathTb
            // 
            this.exportFilePathTb.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.exportFilePathTb.Location = new System.Drawing.Point(130, 126);
            this.exportFilePathTb.Name = "exportFilePathTb";
            this.exportFilePathTb.Size = new System.Drawing.Size(383, 23);
            this.exportFilePathTb.TabIndex = 22;
            // 
            // exportFilePathLbl
            // 
            this.exportFilePathLbl.AutoSize = true;
            this.exportFilePathLbl.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.exportFilePathLbl.Location = new System.Drawing.Point(22, 133);
            this.exportFilePathLbl.Name = "exportFilePathLbl";
            this.exportFilePathLbl.Size = new System.Drawing.Size(97, 16);
            this.exportFilePathLbl.TabIndex = 21;
            this.exportFilePathLbl.Text = "結果出力先:";
            // 
            // dataCheckBtn
            // 
            this.dataCheckBtn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dataCheckBtn.Location = new System.Drawing.Point(496, 283);
            this.dataCheckBtn.Name = "dataCheckBtn";
            this.dataCheckBtn.Size = new System.Drawing.Size(119, 41);
            this.dataCheckBtn.TabIndex = 20;
            this.dataCheckBtn.Text = "チェック実行\n";
            this.dataCheckBtn.UseVisualStyleBackColor = true;
            this.dataCheckBtn.Click += new System.EventHandler(this.DataCheckBtn_Click);
            // 
            // tyoeChooseLbl
            // 
            this.tyoeChooseLbl.AutoSize = true;
            this.tyoeChooseLbl.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tyoeChooseLbl.Location = new System.Drawing.Point(24, 25);
            this.tyoeChooseLbl.Name = "tyoeChooseLbl";
            this.tyoeChooseLbl.Size = new System.Drawing.Size(95, 16);
            this.tyoeChooseLbl.TabIndex = 19;
            this.tyoeChooseLbl.Text = "ファイル種類:";
            // 
            // typeChooseCmb
            // 
            this.typeChooseCmb.FormattingEnabled = true;
            this.typeChooseCmb.Items.AddRange(new object[] {
            "DVD用",
            "NS用"});
            this.typeChooseCmb.Location = new System.Drawing.Point(130, 21);
            this.typeChooseCmb.Name = "typeChooseCmb";
            this.typeChooseCmb.Size = new System.Drawing.Size(145, 20);
            this.typeChooseCmb.TabIndex = 18;
            // 
            // importFilePathBtn
            // 
            this.importFilePathBtn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.importFilePathBtn.Location = new System.Drawing.Point(544, 65);
            this.importFilePathBtn.Name = "importFilePathBtn";
            this.importFilePathBtn.Size = new System.Drawing.Size(71, 26);
            this.importFilePathBtn.TabIndex = 17;
            this.importFilePathBtn.Text = "参照";
            this.importFilePathBtn.UseVisualStyleBackColor = true;
            this.importFilePathBtn.Click += new System.EventHandler(this.ImportFilePathBtn_Click);
            // 
            // importFilePathTb
            // 
            this.importFilePathTb.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.importFilePathTb.Location = new System.Drawing.Point(130, 68);
            this.importFilePathTb.Name = "importFilePathTb";
            this.importFilePathTb.Size = new System.Drawing.Size(383, 23);
            this.importFilePathTb.TabIndex = 16;
            // 
            // importFilePathLbl
            // 
            this.importFilePathLbl.AutoSize = true;
            this.importFilePathLbl.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.importFilePathLbl.Location = new System.Drawing.Point(31, 75);
            this.importFilePathLbl.Name = "importFilePathLbl";
            this.importFilePathLbl.Size = new System.Drawing.Size(88, 16);
            this.importFilePathLbl.TabIndex = 15;
            this.importFilePathLbl.Text = "ファイルパス:";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Result.Location = new System.Drawing.Point(127, 186);
            this.Result.Name = "Result";
            this.Result.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Result.Size = new System.Drawing.Size(0, 16);
            this.Result.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(34, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 25;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.resultLbl.Location = new System.Drawing.Point(39, 186);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(80, 16);
            this.resultLbl.TabIndex = 26;
            this.resultLbl.Text = "実行結果:";
            // 
            // RepeatCheckTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 336);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.exportFilePathBtn);
            this.Controls.Add(this.exportFilePathTb);
            this.Controls.Add(this.exportFilePathLbl);
            this.Controls.Add(this.dataCheckBtn);
            this.Controls.Add(this.tyoeChooseLbl);
            this.Controls.Add(this.typeChooseCmb);
            this.Controls.Add(this.importFilePathBtn);
            this.Controls.Add(this.importFilePathTb);
            this.Controls.Add(this.importFilePathLbl);
            this.Name = "RepeatCheckTool";
            this.Text = "生産年式マスタの重複レコード検出ツール";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exportFilePathBtn;
        private System.Windows.Forms.TextBox exportFilePathTb;
        private System.Windows.Forms.Label exportFilePathLbl;
        private System.Windows.Forms.Button dataCheckBtn;
        private System.Windows.Forms.Label tyoeChooseLbl;
        private System.Windows.Forms.ComboBox typeChooseCmb;
        private System.Windows.Forms.Button importFilePathBtn;
        private System.Windows.Forms.TextBox importFilePathTb;
        private System.Windows.Forms.Label importFilePathLbl;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultLbl;
    }
}

