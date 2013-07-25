namespace DDBot
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
            this.ClickVal = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bitmapa = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TimVal = new System.Windows.Forms.NumericUpDown();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.LTime = new System.Windows.Forms.Label();
            this.LbX = new System.Windows.Forms.Label();
            this.LbY = new System.Windows.Forms.Label();
            this.NudX = new System.Windows.Forms.NumericUpDown();
            this.NudY = new System.Windows.Forms.NumericUpDown();
            this.PbCap = new System.Windows.Forms.PictureBox();
            this.CBklik = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bEnConf = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.lHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClickVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitmapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCap)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClickVal
            // 
            this.ClickVal.Location = new System.Drawing.Point(126, 35);
            this.ClickVal.Maximum = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.ClickVal.Name = "ClickVal";
            this.ClickVal.Size = new System.Drawing.Size(78, 20);
            this.ClickVal.TabIndex = 1;
            this.ClickVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ClickVal.ValueChanged += new System.EventHandler(this.ClickerVal_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "T between click";
            // 
            // bitmapa
            // 
            this.bitmapa.Location = new System.Drawing.Point(7, 34);
            this.bitmapa.Name = "bitmapa";
            this.bitmapa.Size = new System.Drawing.Size(400, 360);
            this.bitmapa.TabIndex = 6;
            this.bitmapa.TabStop = false;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(7, 6);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(113, 24);
            this.Start.TabIndex = 7;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Refresh rate";
            // 
            // TimVal
            // 
            this.TimVal.Location = new System.Drawing.Point(126, 9);
            this.TimVal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TimVal.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.TimVal.Name = "TimVal";
            this.TimVal.Size = new System.Drawing.Size(78, 20);
            this.TimVal.TabIndex = 9;
            this.TimVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TimVal.Value = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.TimVal.ValueChanged += new System.EventHandler(this.TimVal_ValueChanged);
            // 
            // timer2
            // 
            this.timer2.Interval = 90000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(210, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(210, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "sw";
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(126, 6);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(113, 24);
            this.Stop.TabIndex = 12;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.button1_Click);
            // 
            // LTime
            // 
            this.LTime.AutoSize = true;
            this.LTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LTime.Location = new System.Drawing.Point(390, 495);
            this.LTime.Name = "LTime";
            this.LTime.Size = new System.Drawing.Size(39, 16);
            this.LTime.TabIndex = 13;
            this.LTime.Text = "Time";
            this.LTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LbX
            // 
            this.LbX.AccessibleName = "Coor";
            this.LbX.AutoSize = true;
            this.LbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LbX.Location = new System.Drawing.Point(248, 13);
            this.LbX.Name = "LbX";
            this.LbX.Size = new System.Drawing.Size(48, 16);
            this.LbX.TabIndex = 14;
            this.LbX.Text = "Coor X";
            // 
            // LbY
            // 
            this.LbY.AccessibleName = "Coor";
            this.LbY.AutoSize = true;
            this.LbY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LbY.Location = new System.Drawing.Point(247, 39);
            this.LbY.Name = "LbY";
            this.LbY.Size = new System.Drawing.Size(49, 16);
            this.LbY.TabIndex = 15;
            this.LbY.Text = "Coor Y";
            // 
            // NudX
            // 
            this.NudX.Location = new System.Drawing.Point(302, 9);
            this.NudX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NudX.Name = "NudX";
            this.NudX.Size = new System.Drawing.Size(78, 20);
            this.NudX.TabIndex = 16;
            this.NudX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudX.Value = new decimal(new int[] {
            502,
            0,
            0,
            0});
            // 
            // NudY
            // 
            this.NudY.Location = new System.Drawing.Point(302, 39);
            this.NudY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NudY.Name = "NudY";
            this.NudY.Size = new System.Drawing.Size(77, 20);
            this.NudY.TabIndex = 17;
            this.NudY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudY.Value = new decimal(new int[] {
            361,
            0,
            0,
            0});
            // 
            // PbCap
            // 
            this.PbCap.Location = new System.Drawing.Point(6, 33);
            this.PbCap.Name = "PbCap";
            this.PbCap.Size = new System.Drawing.Size(402, 362);
            this.PbCap.TabIndex = 18;
            this.PbCap.TabStop = false;
            // 
            // CBklik
            // 
            this.CBklik.AutoSize = true;
            this.CBklik.Checked = true;
            this.CBklik.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBklik.Location = new System.Drawing.Point(245, 11);
            this.CBklik.Name = "CBklik";
            this.CBklik.Size = new System.Drawing.Size(49, 17);
            this.CBklik.TabIndex = 19;
            this.CBklik.Text = "Click";
            this.CBklik.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(386, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "px";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(386, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "px";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(421, 427);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bEnConf);
            this.tabPage2.Controls.Add(this.PbCap);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(413, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configure";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bEnConf
            // 
            this.bEnConf.Location = new System.Drawing.Point(6, 6);
            this.bEnConf.Name = "bEnConf";
            this.bEnConf.Size = new System.Drawing.Size(267, 24);
            this.bEnConf.TabIndex = 25;
            this.bEnConf.Text = "Start configuration";
            this.bEnConf.UseVisualStyleBackColor = true;
            this.bEnConf.Click += new System.EventHandler(this.bEnConf_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bitmapa);
            this.tabPage1.Controls.Add(this.Start);
            this.tabPage1.Controls.Add(this.CBklik);
            this.tabPage1.Controls.Add(this.Stop);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(413, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Play";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // timer3
            // 
            this.timer3.Interval = 200;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Hint:";
            // 
            // lHint
            // 
            this.lHint.AutoSize = true;
            this.lHint.Location = new System.Drawing.Point(46, 494);
            this.lHint.Name = "lHint";
            this.lHint.Size = new System.Drawing.Size(35, 13);
            this.lHint.TabIndex = 24;
            this.lHint.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 516);
            this.Controls.Add(this.lHint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NudY);
            this.Controls.Add(this.NudX);
            this.Controls.Add(this.LbY);
            this.Controls.Add(this.LbX);
            this.Controls.Add(this.LTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimVal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClickVal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "DDbot - © 2013 JK";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClickVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitmapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCap)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown ClickVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox bitmapa;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TimVal;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label LTime;
        private System.Windows.Forms.Label LbX;
        private System.Windows.Forms.Label LbY;
        private System.Windows.Forms.NumericUpDown NudX;
        private System.Windows.Forms.NumericUpDown NudY;
        private System.Windows.Forms.PictureBox PbCap;
        private System.Windows.Forms.CheckBox CBklik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lHint;
        private System.Windows.Forms.Button bEnConf;
    }
}

