namespace Beat_Analyzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBPM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBPS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxBlueSta = new System.Windows.Forms.TextBox();
            this.textBoxRedSta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxOverall = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSE = new System.Windows.Forms.TextBox();
            this.buttonSE = new System.Windows.Forms.Button();
            this.groupBoxSpeedMode = new System.Windows.Forms.GroupBox();
            this.groupBoxTimeLineMode = new System.Windows.Forms.GroupBox();
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxOuter = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxStopWatch = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxApproachRate = new System.Windows.Forms.TextBox();
            this.textBoxCircleSize = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxBeatSum = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxModeSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonTimeLineMode = new System.Windows.Forms.RadioButton();
            this.radioButtonSpeedMode = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxSpeedMode.SuspendLayout();
            this.groupBoxTimeLineMode.SuspendLayout();
            this.groupBoxModeSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Beats Sum";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(174, 20);
            this.maskedTextBox1.Mask = "9999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(75, 46);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Left";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(330, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 46);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(494, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "(Re)Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Finished in";
            // 
            // textBoxSec
            // 
            this.textBoxSec.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSec.Location = new System.Drawing.Point(222, 72);
            this.textBoxSec.Name = "textBoxSec";
            this.textBoxSec.Size = new System.Drawing.Size(150, 46);
            this.textBoxSec.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "Secs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 38);
            this.label5.TabIndex = 10;
            this.label5.Text = "Avg BPM(1/4)";
            // 
            // textBoxBPM
            // 
            this.textBoxBPM.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBPM.Location = new System.Drawing.Point(222, 124);
            this.textBoxBPM.Name = "textBoxBPM";
            this.textBoxBPM.Size = new System.Drawing.Size(234, 46);
            this.textBoxBPM.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 38);
            this.label6.TabIndex = 12;
            this.label6.Text = "Max BPS(1s~)";
            // 
            // textBoxBPS
            // 
            this.textBoxBPS.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBPS.Location = new System.Drawing.Point(222, 176);
            this.textBoxBPS.Name = "textBoxBPS";
            this.textBoxBPS.Size = new System.Drawing.Size(234, 46);
            this.textBoxBPS.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 38);
            this.label7.TabIndex = 14;
            this.label7.Text = "Blue Key";
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBlue.Location = new System.Drawing.Point(147, 228);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(84, 46);
            this.textBoxBlue.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(237, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 38);
            this.label8.TabIndex = 16;
            this.label8.Text = "Red Key";
            // 
            // textBoxRed
            // 
            this.textBoxRed.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRed.Location = new System.Drawing.Point(372, 228);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(84, 46);
            this.textBoxRed.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 38);
            this.label9.TabIndex = 18;
            this.label9.Text = "Blue Stability";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 38);
            this.label10.TabIndex = 19;
            this.label10.Text = "Red Stability";
            // 
            // textBoxBlueSta
            // 
            this.textBoxBlueSta.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBlueSta.Location = new System.Drawing.Point(222, 280);
            this.textBoxBlueSta.Name = "textBoxBlueSta";
            this.textBoxBlueSta.Size = new System.Drawing.Size(234, 46);
            this.textBoxBlueSta.TabIndex = 20;
            // 
            // textBoxRedSta
            // 
            this.textBoxRedSta.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRedSta.Location = new System.Drawing.Point(222, 332);
            this.textBoxRedSta.Name = "textBoxRedSta";
            this.textBoxRedSta.Size = new System.Drawing.Size(234, 46);
            this.textBoxRedSta.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 38);
            this.label11.TabIndex = 22;
            this.label11.Text = "Overall";
            // 
            // textBoxOverall
            // 
            this.textBoxOverall.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOverall.Location = new System.Drawing.Point(222, 384);
            this.textBoxOverall.Name = "textBoxOverall";
            this.textBoxOverall.Size = new System.Drawing.Size(234, 46);
            this.textBoxOverall.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 38);
            this.label12.TabIndex = 24;
            this.label12.Text = "Sound Effect";
            // 
            // textBoxSE
            // 
            this.textBoxSE.Enabled = false;
            this.textBoxSE.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F);
            this.textBoxSE.Location = new System.Drawing.Point(212, 9);
            this.textBoxSE.Name = "textBoxSE";
            this.textBoxSE.Size = new System.Drawing.Size(224, 46);
            this.textBoxSE.TabIndex = 25;
            // 
            // buttonSE
            // 
            this.buttonSE.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F);
            this.buttonSE.Location = new System.Drawing.Point(442, 8);
            this.buttonSE.Name = "buttonSE";
            this.buttonSE.Size = new System.Drawing.Size(46, 46);
            this.buttonSE.TabIndex = 26;
            this.buttonSE.Text = "...";
            this.buttonSE.UseVisualStyleBackColor = true;
            this.buttonSE.Click += new System.EventHandler(this.buttonSE_Click);
            // 
            // groupBoxSpeedMode
            // 
            this.groupBoxSpeedMode.Controls.Add(this.label3);
            this.groupBoxSpeedMode.Controls.Add(this.textBoxSec);
            this.groupBoxSpeedMode.Controls.Add(this.textBoxRed);
            this.groupBoxSpeedMode.Controls.Add(this.label4);
            this.groupBoxSpeedMode.Controls.Add(this.label8);
            this.groupBoxSpeedMode.Controls.Add(this.textBox1);
            this.groupBoxSpeedMode.Controls.Add(this.label5);
            this.groupBoxSpeedMode.Controls.Add(this.label2);
            this.groupBoxSpeedMode.Controls.Add(this.label9);
            this.groupBoxSpeedMode.Controls.Add(this.maskedTextBox1);
            this.groupBoxSpeedMode.Controls.Add(this.textBoxOverall);
            this.groupBoxSpeedMode.Controls.Add(this.label1);
            this.groupBoxSpeedMode.Controls.Add(this.textBoxBlue);
            this.groupBoxSpeedMode.Controls.Add(this.textBoxBPM);
            this.groupBoxSpeedMode.Controls.Add(this.label10);
            this.groupBoxSpeedMode.Controls.Add(this.label11);
            this.groupBoxSpeedMode.Controls.Add(this.label7);
            this.groupBoxSpeedMode.Controls.Add(this.label6);
            this.groupBoxSpeedMode.Controls.Add(this.textBoxBlueSta);
            this.groupBoxSpeedMode.Controls.Add(this.textBoxRedSta);
            this.groupBoxSpeedMode.Controls.Add(this.textBoxBPS);
            this.groupBoxSpeedMode.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSpeedMode.Location = new System.Drawing.Point(672, 93);
            this.groupBoxSpeedMode.Name = "groupBoxSpeedMode";
            this.groupBoxSpeedMode.Size = new System.Drawing.Size(470, 440);
            this.groupBoxSpeedMode.TabIndex = 28;
            this.groupBoxSpeedMode.TabStop = false;
            this.groupBoxSpeedMode.Text = "Speed Mode";
            // 
            // groupBoxTimeLineMode
            // 
            this.groupBoxTimeLineMode.Controls.Add(this.button2);
            this.groupBoxTimeLineMode.Controls.Add(this.label15);
            this.groupBoxTimeLineMode.Controls.Add(this.textBox2);
            this.groupBoxTimeLineMode.Controls.Add(this.label25);
            this.groupBoxTimeLineMode.Controls.Add(this.label13);
            this.groupBoxTimeLineMode.Controls.Add(this.textBoxInterval);
            this.groupBoxTimeLineMode.Controls.Add(this.label24);
            this.groupBoxTimeLineMode.Controls.Add(this.label22);
            this.groupBoxTimeLineMode.Controls.Add(this.textBoxOuter);
            this.groupBoxTimeLineMode.Controls.Add(this.label23);
            this.groupBoxTimeLineMode.Controls.Add(this.label21);
            this.groupBoxTimeLineMode.Controls.Add(this.label19);
            this.groupBoxTimeLineMode.Controls.Add(this.textBoxStopWatch);
            this.groupBoxTimeLineMode.Controls.Add(this.label20);
            this.groupBoxTimeLineMode.Controls.Add(this.label18);
            this.groupBoxTimeLineMode.Controls.Add(this.textBoxApproachRate);
            this.groupBoxTimeLineMode.Controls.Add(this.textBoxCircleSize);
            this.groupBoxTimeLineMode.Controls.Add(this.label17);
            this.groupBoxTimeLineMode.Controls.Add(this.label16);
            this.groupBoxTimeLineMode.Controls.Add(this.textBoxBeatSum);
            this.groupBoxTimeLineMode.Controls.Add(this.label14);
            this.groupBoxTimeLineMode.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.groupBoxTimeLineMode.Location = new System.Drawing.Point(672, 93);
            this.groupBoxTimeLineMode.Name = "groupBoxTimeLineMode";
            this.groupBoxTimeLineMode.Size = new System.Drawing.Size(470, 440);
            this.groupBoxTimeLineMode.TabIndex = 30;
            this.groupBoxTimeLineMode.TabStop = false;
            this.groupBoxTimeLineMode.Text = "Time Line Mode";
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInterval.Location = new System.Drawing.Point(176, 124);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(228, 46);
            this.textBoxInterval.TabIndex = 42;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(6, 128);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(121, 38);
            this.label24.TabIndex = 41;
            this.label24.Text = "Interval";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(410, 283);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 38);
            this.label22.TabIndex = 40;
            this.label22.Text = "px";
            // 
            // textBoxOuter
            // 
            this.textBoxOuter.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOuter.Location = new System.Drawing.Point(176, 280);
            this.textBoxOuter.Name = "textBoxOuter";
            this.textBoxOuter.Size = new System.Drawing.Size(228, 46);
            this.textBoxOuter.TabIndex = 39;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 283);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(161, 38);
            this.label23.TabIndex = 38;
            this.label23.Text = "Outer Size";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(361, 335);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(103, 38);
            this.label21.TabIndex = 37;
            this.label21.Text = "ms/px";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(410, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 38);
            this.label19.TabIndex = 35;
            this.label19.Text = "s";
            // 
            // textBoxStopWatch
            // 
            this.textBoxStopWatch.Enabled = false;
            this.textBoxStopWatch.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStopWatch.Location = new System.Drawing.Point(176, 20);
            this.textBoxStopWatch.Name = "textBoxStopWatch";
            this.textBoxStopWatch.Size = new System.Drawing.Size(228, 46);
            this.textBoxStopWatch.TabIndex = 33;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(165, 38);
            this.label20.TabIndex = 34;
            this.label20.Text = "Stopwatch";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(410, 230);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 38);
            this.label18.TabIndex = 32;
            this.label18.Text = "px";
            // 
            // textBoxApproachRate
            // 
            this.textBoxApproachRate.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApproachRate.Location = new System.Drawing.Point(236, 332);
            this.textBoxApproachRate.Name = "textBoxApproachRate";
            this.textBoxApproachRate.Size = new System.Drawing.Size(119, 46);
            this.textBoxApproachRate.TabIndex = 31;
            // 
            // textBoxCircleSize
            // 
            this.textBoxCircleSize.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCircleSize.Location = new System.Drawing.Point(176, 228);
            this.textBoxCircleSize.Name = "textBoxCircleSize";
            this.textBoxCircleSize.Size = new System.Drawing.Size(228, 46);
            this.textBoxCircleSize.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 335);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(224, 38);
            this.label17.TabIndex = 29;
            this.label17.Text = "Approach Rate";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 231);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(158, 38);
            this.label16.TabIndex = 28;
            this.label16.Text = "Circle Size";
            // 
            // textBoxBeatSum
            // 
            this.textBoxBeatSum.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBeatSum.Location = new System.Drawing.Point(176, 72);
            this.textBoxBeatSum.Name = "textBoxBeatSum";
            this.textBoxBeatSum.Size = new System.Drawing.Size(228, 46);
            this.textBoxBeatSum.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 38);
            this.label14.TabIndex = 25;
            this.label14.Text = "Beats Sum";
            // 
            // groupBoxModeSelect
            // 
            this.groupBoxModeSelect.Controls.Add(this.radioButtonTimeLineMode);
            this.groupBoxModeSelect.Controls.Add(this.radioButtonSpeedMode);
            this.groupBoxModeSelect.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.groupBoxModeSelect.Location = new System.Drawing.Point(672, 12);
            this.groupBoxModeSelect.Name = "groupBoxModeSelect";
            this.groupBoxModeSelect.Size = new System.Drawing.Size(470, 75);
            this.groupBoxModeSelect.TabIndex = 29;
            this.groupBoxModeSelect.TabStop = false;
            this.groupBoxModeSelect.Text = "Mode Select";
            // 
            // radioButtonTimeLineMode
            // 
            this.radioButtonTimeLineMode.AutoSize = true;
            this.radioButtonTimeLineMode.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F);
            this.radioButtonTimeLineMode.Location = new System.Drawing.Point(134, 26);
            this.radioButtonTimeLineMode.Name = "radioButtonTimeLineMode";
            this.radioButtonTimeLineMode.Size = new System.Drawing.Size(169, 42);
            this.radioButtonTimeLineMode.TabIndex = 1;
            this.radioButtonTimeLineMode.Text = "Time Line";
            this.radioButtonTimeLineMode.UseVisualStyleBackColor = true;
            this.radioButtonTimeLineMode.CheckedChanged += new System.EventHandler(this.radioButtonTimeLineMode_CheckedChanged);
            // 
            // radioButtonSpeedMode
            // 
            this.radioButtonSpeedMode.AutoSize = true;
            this.radioButtonSpeedMode.Checked = true;
            this.radioButtonSpeedMode.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F);
            this.radioButtonSpeedMode.Location = new System.Drawing.Point(6, 26);
            this.radioButtonSpeedMode.Name = "radioButtonSpeedMode";
            this.radioButtonSpeedMode.Size = new System.Drawing.Size(122, 42);
            this.radioButtonSpeedMode.TabIndex = 0;
            this.radioButtonSpeedMode.TabStop = true;
            this.radioButtonSpeedMode.Text = "Speed";
            this.radioButtonSpeedMode.UseVisualStyleBackColor = true;
            this.radioButtonSpeedMode.CheckedChanged += new System.EventHandler(this.radioButtonSpeedMode_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(410, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 38);
            this.label13.TabIndex = 43;
            this.label13.Text = "ms";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(410, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 38);
            this.label15.TabIndex = 46;
            this.label15.Text = "s";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(176, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 46);
            this.textBox2.TabIndex = 45;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(6, 180);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(164, 38);
            this.label25.TabIndex = 44;
            this.label25.Text = "Total Time";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 33);
            this.button2.TabIndex = 47;
            this.button2.Text = "test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 541);
            this.Controls.Add(this.groupBoxTimeLineMode);
            this.Controls.Add(this.groupBoxModeSelect);
            this.Controls.Add(this.groupBoxSpeedMode);
            this.Controls.Add(this.buttonSE);
            this.Controls.Add(this.textBoxSE);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beat Analyzer 2.0 by Frederick888";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBoxSpeedMode.ResumeLayout(false);
            this.groupBoxSpeedMode.PerformLayout();
            this.groupBoxTimeLineMode.ResumeLayout(false);
            this.groupBoxTimeLineMode.PerformLayout();
            this.groupBoxModeSelect.ResumeLayout(false);
            this.groupBoxModeSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBPM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBPS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxBlueSta;
        private System.Windows.Forms.TextBox textBoxRedSta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxOverall;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSE;
        private System.Windows.Forms.Button buttonSE;
        private System.Windows.Forms.GroupBox groupBoxSpeedMode;
        private System.Windows.Forms.GroupBox groupBoxModeSelect;
        private System.Windows.Forms.RadioButton radioButtonTimeLineMode;
        private System.Windows.Forms.RadioButton radioButtonSpeedMode;
        private System.Windows.Forms.GroupBox groupBoxTimeLineMode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxBeatSum;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxStopWatch;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxApproachRate;
        private System.Windows.Forms.TextBox textBoxCircleSize;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxOuter;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;

    }
}

