namespace CompressionFormsC_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EncodeBtn = new System.Windows.Forms.Button();
            this.Inputdata = new System.Windows.Forms.TextBox();
            this.Outputdata = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LZ77ParamGroupBox = new System.Windows.Forms.GroupBox();
            this.LookaheadWindTxtBox = new System.Windows.Forms.TextBox();
            this.SearchWinTxtBox = new System.Windows.Forms.TextBox();
            this.LookaheadWindLabel = new System.Windows.Forms.Label();
            this.SearchWinLabel = new System.Windows.Forms.Label();
            this.LZWRadioBtn = new System.Windows.Forms.RadioButton();
            this.LZ78RadioBtn = new System.Windows.Forms.RadioButton();
            this.LZ77RadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ComprRatio = new System.Windows.Forms.Label();
            this.EncodedSize = new System.Windows.Forms.Label();
            this.InitialSize = new System.Windows.Forms.Label();
            this.DecodeTime = new System.Windows.Forms.Label();
            this.EncodeTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.LZ77ParamGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncodeBtn
            // 
            this.EncodeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncodeBtn.Location = new System.Drawing.Point(79, 286);
            this.EncodeBtn.Name = "EncodeBtn";
            this.EncodeBtn.Size = new System.Drawing.Size(148, 41);
            this.EncodeBtn.TabIndex = 0;
            this.EncodeBtn.Text = "Encode";
            this.EncodeBtn.UseVisualStyleBackColor = true;
            this.EncodeBtn.Click += new System.EventHandler(this.EncodeBtn_Click);
            // 
            // Inputdata
            // 
            this.Inputdata.Location = new System.Drawing.Point(12, 79);
            this.Inputdata.Multiline = true;
            this.Inputdata.Name = "Inputdata";
            this.Inputdata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Inputdata.Size = new System.Drawing.Size(317, 201);
            this.Inputdata.TabIndex = 1;
            // 
            // Outputdata
            // 
            this.Outputdata.Location = new System.Drawing.Point(12, 333);
            this.Outputdata.Multiline = true;
            this.Outputdata.Name = "Outputdata";
            this.Outputdata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Outputdata.Size = new System.Drawing.Size(317, 201);
            this.Outputdata.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter text and select algorithm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LZ77ParamGroupBox);
            this.groupBox1.Controls.Add(this.LZWRadioBtn);
            this.groupBox1.Controls.Add(this.LZ78RadioBtn);
            this.groupBox1.Controls.Add(this.LZ77RadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(335, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 167);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithms";
            // 
            // LZ77ParamGroupBox
            // 
            this.LZ77ParamGroupBox.Controls.Add(this.LookaheadWindTxtBox);
            this.LZ77ParamGroupBox.Controls.Add(this.SearchWinTxtBox);
            this.LZ77ParamGroupBox.Controls.Add(this.LookaheadWindLabel);
            this.LZ77ParamGroupBox.Controls.Add(this.SearchWinLabel);
            this.LZ77ParamGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LZ77ParamGroupBox.Location = new System.Drawing.Point(76, 28);
            this.LZ77ParamGroupBox.Name = "LZ77ParamGroupBox";
            this.LZ77ParamGroupBox.Size = new System.Drawing.Size(320, 74);
            this.LZ77ParamGroupBox.TabIndex = 3;
            this.LZ77ParamGroupBox.TabStop = false;
            // 
            // LookaheadWindTxtBox
            // 
            this.LookaheadWindTxtBox.Location = new System.Drawing.Point(119, 47);
            this.LookaheadWindTxtBox.Name = "LookaheadWindTxtBox";
            this.LookaheadWindTxtBox.Size = new System.Drawing.Size(195, 20);
            this.LookaheadWindTxtBox.TabIndex = 3;
            this.LookaheadWindTxtBox.Text = "4";
            // 
            // SearchWinTxtBox
            // 
            this.SearchWinTxtBox.Location = new System.Drawing.Point(119, 16);
            this.SearchWinTxtBox.Name = "SearchWinTxtBox";
            this.SearchWinTxtBox.Size = new System.Drawing.Size(195, 20);
            this.SearchWinTxtBox.TabIndex = 2;
            this.SearchWinTxtBox.Text = "6";
            // 
            // LookaheadWindLabel
            // 
            this.LookaheadWindLabel.AutoSize = true;
            this.LookaheadWindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LookaheadWindLabel.Location = new System.Drawing.Point(7, 47);
            this.LookaheadWindLabel.Name = "LookaheadWindLabel";
            this.LookaheadWindLabel.Size = new System.Drawing.Size(103, 15);
            this.LookaheadWindLabel.TabIndex = 1;
            this.LookaheadWindLabel.Text = "Lookahead buffer";
            // 
            // SearchWinLabel
            // 
            this.SearchWinLabel.AutoSize = true;
            this.SearchWinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchWinLabel.Location = new System.Drawing.Point(7, 16);
            this.SearchWinLabel.Name = "SearchWinLabel";
            this.SearchWinLabel.Size = new System.Drawing.Size(91, 15);
            this.SearchWinLabel.TabIndex = 0;
            this.SearchWinLabel.Text = "Search window";
            // 
            // LZWRadioBtn
            // 
            this.LZWRadioBtn.AutoSize = true;
            this.LZWRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LZWRadioBtn.Location = new System.Drawing.Point(6, 108);
            this.LZWRadioBtn.Name = "LZWRadioBtn";
            this.LZWRadioBtn.Size = new System.Drawing.Size(61, 24);
            this.LZWRadioBtn.TabIndex = 2;
            this.LZWRadioBtn.TabStop = true;
            this.LZWRadioBtn.Text = "LZW";
            this.LZWRadioBtn.UseVisualStyleBackColor = true;
            this.LZWRadioBtn.CheckedChanged += new System.EventHandler(this.LZWRadioBtn_CheckedChanged);
            // 
            // LZ78RadioBtn
            // 
            this.LZ78RadioBtn.AutoSize = true;
            this.LZ78RadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LZ78RadioBtn.Location = new System.Drawing.Point(6, 78);
            this.LZ78RadioBtn.Name = "LZ78RadioBtn";
            this.LZ78RadioBtn.Size = new System.Drawing.Size(64, 24);
            this.LZ78RadioBtn.TabIndex = 1;
            this.LZ78RadioBtn.TabStop = true;
            this.LZ78RadioBtn.Text = "LZ78";
            this.LZ78RadioBtn.UseVisualStyleBackColor = true;
            this.LZ78RadioBtn.CheckedChanged += new System.EventHandler(this.LZ78RadioBtn_CheckedChanged);
            // 
            // LZ77RadioBtn
            // 
            this.LZ77RadioBtn.AutoSize = true;
            this.LZ77RadioBtn.Checked = true;
            this.LZ77RadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LZ77RadioBtn.Location = new System.Drawing.Point(6, 47);
            this.LZ77RadioBtn.Name = "LZ77RadioBtn";
            this.LZ77RadioBtn.Size = new System.Drawing.Size(64, 24);
            this.LZ77RadioBtn.TabIndex = 0;
            this.LZ77RadioBtn.TabStop = true;
            this.LZ77RadioBtn.Text = "LZ77";
            this.LZ77RadioBtn.UseVisualStyleBackColor = true;
            this.LZ77RadioBtn.CheckedChanged += new System.EventHandler(this.LZ77RadioBtn_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ComprRatio);
            this.groupBox3.Controls.Add(this.EncodedSize);
            this.groupBox3.Controls.Add(this.InitialSize);
            this.groupBox3.Controls.Add(this.DecodeTime);
            this.groupBox3.Controls.Add(this.EncodeTime);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(341, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 210);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistics";
            // 
            // ComprRatio
            // 
            this.ComprRatio.AutoSize = true;
            this.ComprRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComprRatio.Location = new System.Drawing.Point(6, 123);
            this.ComprRatio.Name = "ComprRatio";
            this.ComprRatio.Size = new System.Drawing.Size(130, 17);
            this.ComprRatio.TabIndex = 9;
            this.ComprRatio.Text = "Compression ratio: ";
            // 
            // EncodedSize
            // 
            this.EncodedSize.AutoSize = true;
            this.EncodedSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncodedSize.Location = new System.Drawing.Point(6, 101);
            this.EncodedSize.Name = "EncodedSize";
            this.EncodedSize.Size = new System.Drawing.Size(101, 17);
            this.EncodedSize.TabIndex = 8;
            this.EncodedSize.Text = "Encoded size: ";
            // 
            // InitialSize
            // 
            this.InitialSize.AutoSize = true;
            this.InitialSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InitialSize.Location = new System.Drawing.Point(6, 79);
            this.InitialSize.Name = "InitialSize";
            this.InitialSize.Size = new System.Drawing.Size(77, 17);
            this.InitialSize.TabIndex = 7;
            this.InitialSize.Text = "Initial size: ";
            // 
            // DecodeTime
            // 
            this.DecodeTime.AutoSize = true;
            this.DecodeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecodeTime.Location = new System.Drawing.Point(6, 57);
            this.DecodeTime.Name = "DecodeTime";
            this.DecodeTime.Size = new System.Drawing.Size(168, 17);
            this.DecodeTime.TabIndex = 6;
            this.DecodeTime.Text = "Time spent on decoding: ";
            // 
            // EncodeTime
            // 
            this.EncodeTime.AutoSize = true;
            this.EncodeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncodeTime.Location = new System.Drawing.Point(6, 35);
            this.EncodeTime.Name = "EncodeTime";
            this.EncodeTime.Size = new System.Drawing.Size(168, 17);
            this.EncodeTime.TabIndex = 0;
            this.EncodeTime.Text = "Time spent on encoding: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 570);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Outputdata);
            this.Controls.Add(this.Inputdata);
            this.Controls.Add(this.EncodeBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Compressin app";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.LZ77ParamGroupBox.ResumeLayout(false);
            this.LZ77ParamGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EncodeBtn;
        private System.Windows.Forms.TextBox Inputdata;
        private System.Windows.Forms.TextBox Outputdata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox LZ77ParamGroupBox;
        private System.Windows.Forms.Label LookaheadWindLabel;
        private System.Windows.Forms.Label SearchWinLabel;
        private System.Windows.Forms.RadioButton LZWRadioBtn;
        private System.Windows.Forms.RadioButton LZ78RadioBtn;
        private System.Windows.Forms.RadioButton LZ77RadioBtn;
        private System.Windows.Forms.TextBox LookaheadWindTxtBox;
        private System.Windows.Forms.TextBox SearchWinTxtBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label EncodeTime;
        private System.Windows.Forms.Label EncodedSize;
        private System.Windows.Forms.Label InitialSize;
        private System.Windows.Forms.Label DecodeTime;
        private System.Windows.Forms.Label ComprRatio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}

