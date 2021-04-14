namespace JustRenameIT
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.txtDestinationFolder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.prefixIterateFrom = new System.Windows.Forms.NumericUpDown();
            this.appendIterateFrom = new System.Windows.Forms.NumericUpDown();
            this.appendCheckBox = new System.Windows.Forms.CheckBox();
            this.prefixCheckbox = new System.Windows.Forms.CheckBox();
            this.fileAppend = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.filePrefix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prefixIterateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appendIterateFrom)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Just Rename It";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Source Folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination Folder";
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Location = new System.Drawing.Point(20, 39);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(387, 20);
            this.txtSourceFolder.TabIndex = 3;
            this.txtSourceFolder.Text = "C:\\Temp\\In";
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.Enabled = false;
            this.txtDestinationFolder.Location = new System.Drawing.Point(20, 103);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.Size = new System.Drawing.Size(387, 20);
            this.txtDestinationFolder.TabIndex = 4;
            this.txtDestinationFolder.Text = "C:\\Temp\\Out";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(413, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtSourceFolder);
            this.groupBox1.Controls.Add(this.txtDestinationFolder);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 133);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files Location";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Copy it. Do Not Rename it";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.prefixIterateFrom);
            this.groupBox2.Controls.Add(this.appendIterateFrom);
            this.groupBox2.Controls.Add(this.appendCheckBox);
            this.groupBox2.Controls.Add(this.prefixCheckbox);
            this.groupBox2.Controls.Add(this.fileAppend);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.fileName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.filePrefix);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 157);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Options";
            // 
            // prefixIterateFrom
            // 
            this.prefixIterateFrom.Location = new System.Drawing.Point(373, 37);
            this.prefixIterateFrom.Name = "prefixIterateFrom";
            this.prefixIterateFrom.Size = new System.Drawing.Size(78, 20);
            this.prefixIterateFrom.TabIndex = 9;
            this.prefixIterateFrom.ValueChanged += new System.EventHandler(this.prefixIterateFrom_ValueChanged);
            // 
            // appendIterateFrom
            // 
            this.appendIterateFrom.Location = new System.Drawing.Point(373, 122);
            this.appendIterateFrom.Name = "appendIterateFrom";
            this.appendIterateFrom.Size = new System.Drawing.Size(78, 20);
            this.appendIterateFrom.TabIndex = 8;
            this.appendIterateFrom.ValueChanged += new System.EventHandler(this.appendIterateFrom_ValueChanged);
            // 
            // appendCheckBox
            // 
            this.appendCheckBox.AutoSize = true;
            this.appendCheckBox.Location = new System.Drawing.Point(217, 125);
            this.appendCheckBox.Name = "appendCheckBox";
            this.appendCheckBox.Size = new System.Drawing.Size(150, 17);
            this.appendCheckBox.TabIndex = 7;
            this.appendCheckBox.Text = "number iteration starting at";
            this.appendCheckBox.UseVisualStyleBackColor = true;
            this.appendCheckBox.CheckedChanged += new System.EventHandler(this.appendCheckBox_CheckedChanged);
            // 
            // prefixCheckbox
            // 
            this.prefixCheckbox.AutoSize = true;
            this.prefixCheckbox.Location = new System.Drawing.Point(217, 40);
            this.prefixCheckbox.Name = "prefixCheckbox";
            this.prefixCheckbox.Size = new System.Drawing.Size(150, 17);
            this.prefixCheckbox.TabIndex = 6;
            this.prefixCheckbox.Text = "number iteration starting at";
            this.prefixCheckbox.UseVisualStyleBackColor = true;
            this.prefixCheckbox.CheckedChanged += new System.EventHandler(this.prefixCheckbox_CheckedChanged);
            // 
            // fileAppend
            // 
            this.fileAppend.Location = new System.Drawing.Point(20, 122);
            this.fileAppend.Name = "fileAppend";
            this.fileAppend.Size = new System.Drawing.Size(190, 20);
            this.fileAppend.TabIndex = 5;
            this.fileAppend.TextChanged += new System.EventHandler(this.fileAppend_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Suffix";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(20, 80);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(190, 20);
            this.fileName.TabIndex = 3;
            this.fileName.TextChanged += new System.EventHandler(this.fileName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "New Filename";
            // 
            // filePrefix
            // 
            this.filePrefix.Location = new System.Drawing.Point(20, 38);
            this.filePrefix.Name = "filePrefix";
            this.filePrefix.Size = new System.Drawing.Size(190, 20);
            this.filePrefix.TabIndex = 1;
            this.filePrefix.TextChanged += new System.EventHandler(this.filePrefix_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prefix";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(371, 453);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "Just Do it!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\Users\\strydomj\\Pictures\\tmp-shared";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(18, 453);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 30);
            this.button4.TabIndex = 10;
            this.button4.Text = "About";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPreview);
            this.groupBox3.Location = new System.Drawing.Point(12, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 78);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output Preview";
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.Location = new System.Drawing.Point(6, 37);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(106, 13);
            this.lblPreview.TabIndex = 0;
            this.lblPreview.Text = "[filename].[extension]";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 499);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Just Rename It - V0.1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prefixIterateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appendIterateFrom)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.TextBox txtDestinationFolder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox filePrefix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox appendCheckBox;
        private System.Windows.Forms.CheckBox prefixCheckbox;
        private System.Windows.Forms.TextBox fileAppend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.NumericUpDown prefixIterateFrom;
        private System.Windows.Forms.NumericUpDown appendIterateFrom;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPreview;
    }
}

