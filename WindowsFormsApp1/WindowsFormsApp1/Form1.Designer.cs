namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.page2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.next = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.startToggle = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Menu = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Label();
            this.page1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.chooseFolder = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.thirtyMinutes = new System.Windows.Forms.Button();
            this.fiveMinutes = new System.Windows.Forms.Button();
            this.thirtySeconds = new System.Windows.Forms.Button();
            this.fourtySeconds = new System.Windows.Forms.Button();
            this.sixtySeconds = new System.Windows.Forms.Button();
            this.fifteenMinutes = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.folderName = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.page2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.page1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(12, 9);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(44, 13);
            this.timerLabel.TabIndex = 3;
            this.timerLabel.Text = "30 secs";
            // 
            // page2
            // 
            this.page2.Controls.Add(this.pictureBox2);
            this.page2.Controls.Add(this.tableLayoutPanel1);
            this.page2.Controls.Add(this.tableLayoutPanel3);
            this.page2.Location = new System.Drawing.Point(4, 22);
            this.page2.Name = "page2";
            this.page2.Padding = new System.Windows.Forms.Padding(3);
            this.page2.Size = new System.Drawing.Size(721, 744);
            this.page2.TabIndex = 3;
            this.page2.Text = "tabPage4";
            this.page2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.alpaca_by_aznyueying_db0r1c1;
            this.pictureBox2.Location = new System.Drawing.Point(3, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(715, 586);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.14047F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.68567F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.31293F));
            this.tableLayoutPanel1.Controls.Add(this.next, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Previous, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.startToggle, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 632);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(715, 109);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // next
            // 
            this.next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.next.Location = new System.Drawing.Point(536, 3);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(176, 103);
            this.next.TabIndex = 7;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            // 
            // Previous
            // 
            this.Previous.AutoSize = true;
            this.Previous.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Previous.Location = new System.Drawing.Point(3, 3);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(144, 103);
            this.Previous.TabIndex = 6;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = true;
            // 
            // startToggle
            // 
            this.startToggle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startToggle.Location = new System.Drawing.Point(153, 3);
            this.startToggle.Name = "startToggle";
            this.startToggle.Size = new System.Drawing.Size(377, 103);
            this.startToggle.TabIndex = 5;
            this.startToggle.Text = "Start/Pause";
            this.startToggle.UseVisualStyleBackColor = true;
            this.startToggle.Click += new System.EventHandler(this.startToggle_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.70905F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.29095F));
            this.tableLayoutPanel3.Controls.Add(this.Menu, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.timer, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(715, 43);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // Menu
            // 
            this.Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Menu.Location = new System.Drawing.Point(565, 3);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(147, 37);
            this.Menu.TabIndex = 9;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.Location = new System.Drawing.Point(3, 0);
            this.timer.Name = "timer";
            this.timer.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.timer.Size = new System.Drawing.Size(140, 34);
            this.timer.TabIndex = 10;
            this.timer.Text = "30 Seconds";
            // 
            // page1
            // 
            this.page1.Controls.Add(this.tableLayoutPanel6);
            this.page1.Location = new System.Drawing.Point(4, 22);
            this.page1.Name = "page1";
            this.page1.Padding = new System.Windows.Forms.Padding(3);
            this.page1.Size = new System.Drawing.Size(721, 744);
            this.page1.TabIndex = 1;
            this.page1.Text = "tabPage2";
            this.page1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.13279F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.84553F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.02168F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(715, 738);
            this.tableLayoutPanel6.TabIndex = 9;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.chooseFolder, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.start, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 607);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(709, 128);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // chooseFolder
            // 
            this.chooseFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chooseFolder.Location = new System.Drawing.Point(3, 3);
            this.chooseFolder.Name = "chooseFolder";
            this.chooseFolder.Size = new System.Drawing.Size(348, 122);
            this.chooseFolder.TabIndex = 1;
            this.chooseFolder.Text = "Choose Folder";
            this.chooseFolder.UseVisualStyleBackColor = true;
            this.chooseFolder.Click += new System.EventHandler(this.chooseFolder_Click_1);
            // 
            // start
            // 
            this.start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.start.Location = new System.Drawing.Point(357, 3);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(349, 122);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.70681F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.95985F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.thirtyMinutes, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.fiveMinutes, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.thirtySeconds, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.fourtySeconds, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.sixtySeconds, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.fifteenMinutes, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 217);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(709, 384);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // thirtyMinutes
            // 
            this.thirtyMinutes.AutoSize = true;
            this.thirtyMinutes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.thirtyMinutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirtyMinutes.Location = new System.Drawing.Point(474, 195);
            this.thirtyMinutes.Name = "thirtyMinutes";
            this.thirtyMinutes.Size = new System.Drawing.Size(232, 181);
            this.thirtyMinutes.TabIndex = 3;
            this.thirtyMinutes.Text = "30 minutes";
            this.thirtyMinutes.UseVisualStyleBackColor = true;
            this.thirtyMinutes.Click += new System.EventHandler(this.thirtyMinutes_Click);
            // 
            // fiveMinutes
            // 
            this.fiveMinutes.AutoSize = true;
            this.fiveMinutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fiveMinutes.Location = new System.Drawing.Point(3, 195);
            this.fiveMinutes.Name = "fiveMinutes";
            this.fiveMinutes.Size = new System.Drawing.Size(232, 181);
            this.fiveMinutes.TabIndex = 1;
            this.fiveMinutes.Text = "5 minutes";
            this.fiveMinutes.UseVisualStyleBackColor = true;
            this.fiveMinutes.Click += new System.EventHandler(this.fiveMinutes_Click);
            // 
            // thirtySeconds
            // 
            this.thirtySeconds.AutoSize = true;
            this.thirtySeconds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirtySeconds.Location = new System.Drawing.Point(3, 8);
            this.thirtySeconds.Name = "thirtySeconds";
            this.thirtySeconds.Size = new System.Drawing.Size(232, 181);
            this.thirtySeconds.TabIndex = 0;
            this.thirtySeconds.Text = "30 Seconds";
            this.thirtySeconds.UseVisualStyleBackColor = true;
            this.thirtySeconds.Click += new System.EventHandler(this.thirtySeconds_Click);
            // 
            // fourtySeconds
            // 
            this.fourtySeconds.AutoSize = true;
            this.fourtySeconds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourtySeconds.Location = new System.Drawing.Point(241, 8);
            this.fourtySeconds.Name = "fourtySeconds";
            this.fourtySeconds.Size = new System.Drawing.Size(227, 181);
            this.fourtySeconds.TabIndex = 2;
            this.fourtySeconds.Text = "45 Seconds";
            this.fourtySeconds.UseVisualStyleBackColor = true;
            this.fourtySeconds.Click += new System.EventHandler(this.fourtySeconds_Click);
            // 
            // sixtySeconds
            // 
            this.sixtySeconds.AutoSize = true;
            this.sixtySeconds.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sixtySeconds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixtySeconds.Location = new System.Drawing.Point(474, 8);
            this.sixtySeconds.Name = "sixtySeconds";
            this.sixtySeconds.Size = new System.Drawing.Size(232, 181);
            this.sixtySeconds.TabIndex = 4;
            this.sixtySeconds.Text = "60 Seconds";
            this.sixtySeconds.UseVisualStyleBackColor = true;
            this.sixtySeconds.Click += new System.EventHandler(this.sixtySeconds_Click);
            // 
            // fifteenMinutes
            // 
            this.fifteenMinutes.AutoSize = true;
            this.fifteenMinutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fifteenMinutes.Location = new System.Drawing.Point(241, 195);
            this.fifteenMinutes.Name = "fifteenMinutes";
            this.fifteenMinutes.Size = new System.Drawing.Size(227, 181);
            this.fifteenMinutes.TabIndex = 5;
            this.fifteenMinutes.Text = "15 minutes";
            this.fifteenMinutes.UseVisualStyleBackColor = true;
            this.fifteenMinutes.Click += new System.EventHandler(this.fifteenMinutes_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.folderName, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.72803F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.27197F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(709, 208);
            this.tableLayoutPanel7.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 72);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gesture Drawing";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // folderName
            // 
            this.folderName.AutoSize = true;
            this.folderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderName.Location = new System.Drawing.Point(3, 72);
            this.folderName.Name = "folderName";
            this.folderName.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.folderName.Size = new System.Drawing.Size(179, 34);
            this.folderName.TabIndex = 4;
            this.folderName.Text = "Curr Folder: fjdkslgh";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.page1);
            this.tabControl.Controls.Add(this.page2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(729, 770);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 770);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.timerLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.page2.ResumeLayout(false);
            this.page2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.page1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.TabPage page2;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button startToggle;
        private System.Windows.Forms.TabPage page1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button thirtyMinutes;
        private System.Windows.Forms.Button fiveMinutes;
        private System.Windows.Forms.Button thirtySeconds;
        private System.Windows.Forms.Button fourtySeconds;
        private System.Windows.Forms.Button sixtySeconds;
        private System.Windows.Forms.Button fifteenMinutes;
        private System.Windows.Forms.Label folderName;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button chooseFolder;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label timer;
    }
}

