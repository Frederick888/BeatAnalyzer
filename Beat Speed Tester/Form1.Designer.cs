namespace Beat_Speed_Tester
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Beat Sum";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(167, 6);
            this.maskedTextBox1.Mask = "9999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(75, 46);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Beats Left";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(406, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 46);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(487, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "(Re)Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(672, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Finished in";
            // 
            // textBoxSec
            // 
            this.textBoxSec.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSec.Location = new System.Drawing.Point(888, 7);
            this.textBoxSec.Name = "textBoxSec";
            this.textBoxSec.Size = new System.Drawing.Size(150, 46);
            this.textBoxSec.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1044, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "Secs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(672, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 38);
            this.label5.TabIndex = 10;
            this.label5.Text = "Avg BPM(1/4)";
            // 
            // textBoxBPM
            // 
            this.textBoxBPM.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBPM.Location = new System.Drawing.Point(888, 59);
            this.textBoxBPM.Name = "textBoxBPM";
            this.textBoxBPM.Size = new System.Drawing.Size(234, 46);
            this.textBoxBPM.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(672, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 38);
            this.label6.TabIndex = 12;
            this.label6.Text = "Max BPS(1s~)";
            // 
            // textBoxBPS
            // 
            this.textBoxBPS.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBPS.Location = new System.Drawing.Point(888, 111);
            this.textBoxBPS.Name = "textBoxBPS";
            this.textBoxBPS.Size = new System.Drawing.Size(234, 46);
            this.textBoxBPS.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(672, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 38);
            this.label7.TabIndex = 14;
            this.label7.Text = "Blue Key";
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBlue.Location = new System.Drawing.Point(813, 163);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(80, 46);
            this.textBoxBlue.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(899, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 38);
            this.label8.TabIndex = 16;
            this.label8.Text = "Red Key";
            // 
            // textBoxRed
            // 
            this.textBoxRed.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRed.Location = new System.Drawing.Point(1034, 163);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(80, 46);
            this.textBoxRed.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(672, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 38);
            this.label9.TabIndex = 18;
            this.label9.Text = "Blue Stability";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(672, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 38);
            this.label10.TabIndex = 19;
            this.label10.Text = "Red Stability";
            // 
            // textBoxBlueSta
            // 
            this.textBoxBlueSta.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBlueSta.Location = new System.Drawing.Point(888, 215);
            this.textBoxBlueSta.Name = "textBoxBlueSta";
            this.textBoxBlueSta.Size = new System.Drawing.Size(234, 46);
            this.textBoxBlueSta.TabIndex = 20;
            // 
            // textBoxRedSta
            // 
            this.textBoxRedSta.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRedSta.Location = new System.Drawing.Point(888, 267);
            this.textBoxRedSta.Name = "textBoxRedSta";
            this.textBoxRedSta.Size = new System.Drawing.Size(234, 46);
            this.textBoxRedSta.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(672, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 38);
            this.label11.TabIndex = 22;
            this.label11.Text = "Overall";
            // 
            // textBoxOverall
            // 
            this.textBoxOverall.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOverall.Location = new System.Drawing.Point(888, 319);
            this.textBoxOverall.Name = "textBoxOverall";
            this.textBoxOverall.Size = new System.Drawing.Size(234, 46);
            this.textBoxOverall.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 386);
            this.Controls.Add(this.textBoxOverall);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxRedSta);
            this.Controls.Add(this.textBoxBlueSta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxRed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxBlue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxBPS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxBPM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beat Speed Tester Rev1 by Frederick888";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
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

    }
}

