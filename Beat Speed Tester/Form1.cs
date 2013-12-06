﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Beat_Speed_Tester
{
    public partial class Form1 : Form
    {
        List<long> beatL = new List<long>();
        List<long> beatR = new List<long>();
        List<long> beat = new List<long>();
        DateTime start;
        int keyL, keyR;

        FileInfo se = null;

        const int BmpX = 600, BmpY = 350;

        Bitmap bmp = new Bitmap(BmpX, BmpY);
        double xScale, yScale;
        bool keyLUp = true, keyRUp = true;

        void refresh()
        {
            this.CreateGraphics().DrawImage(bmp, 25, 65);
        }

        long getInterval(DateTime st, DateTime ed)
        {
            TimeSpan t = ed - st;
            long re = t.Ticks / 100000;
            return Math.Abs(re);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, 0, 0, BmpX - 1, BmpY - 1);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int tmp;

            //MessageBox.Show(e.KeyValue.ToString());

            if (((e.KeyValue <= 'Z' && e.KeyValue >= 'A') || e.KeyValue == 188 || e.KeyValue == 190 || e.KeyValue == 191 || e.KeyValue == 186 || e.KeyValue == 222
                || e.KeyValue == 219 || e.KeyValue == 221 || e.KeyValue == 220 || (e.KeyValue >= 96 && e.KeyValue <= 107)
                || (e.KeyValue >= 109 && e.KeyValue <= 111) || e.KeyValue == 189 || e.KeyValue == 187 || e.KeyValue == 192
                || (e.KeyValue >= 48 && e.KeyValue <= 57))
                && Int32.TryParse(textBox1.Text, out tmp))
            {
                try
                {
                    if (Convert.ToInt32(maskedTextBox1.Text) < 10)
                    {
                        MessageBox.Show("10 Beats at Least!", "Error");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid input!", "Error");
                    return;
                }

                
                if (tmp > 0)
                {
                    if(se!=null)
                        if (se.Exists)
                        {
                            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
                            player.URL = se.FullName;
                        }

                    if (keyL == -1)
                    {
                        keyL = e.KeyValue;
                        start = DateTime.Now;
                    }
                    else
                    {
                        if (keyR == -1 && e.KeyValue != keyL)
                        {
                            keyR = e.KeyValue;
                        }
                    }

                    if (e.KeyValue == keyL && keyLUp)
                    {
                        beatL.Add(getInterval(start, DateTime.Now));
                        textBox1.Text = (Convert.ToInt32(textBox1.Text) - 1).ToString();
                        keyLUp = false;
                    }

                    if (e.KeyValue == keyR && keyRUp)
                    {
                        beatR.Add(getInterval(start, DateTime.Now));
                        textBox1.Text = (Convert.ToInt32(textBox1.Text) - 1).ToString();
                        keyRUp = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = maskedTextBox1.Text;
            beatL.Clear();
            beatR.Clear();
            beat.Clear();
            keyL = -1;
            keyR = -1;

            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, 0, 0, BmpX, BmpY);
            refresh();
        }

        double rCal(List<long> b)
        {
            double SumX = 0;
            foreach (long i in b)
                SumX += i;
            double SumY = 0;
            for (int i = 0; i < b.Count; i++)
                SumY += i;
            double AverX = SumX / b.Count;
            double AverY = SumY / b.Count;
            double xiMxTyiMy = 0;
            for (int i = 0; i < b.Count; i++)
                xiMxTyiMy += (b[i] - AverX) * (i - AverY);
            double xiMxPow = 0;
            for (int i = 0; i < b.Count; i++)
                xiMxPow += Math.Pow(b[i] - AverX, 2);
            double yiMyPow = 0;
            for (int i = 0; i < b.Count; i++)
                yiMyPow += Math.Pow(i - AverY, 2);
            double r = xiMxTyiMy / Math.Sqrt(xiMxPow) / Math.Sqrt(yiMyPow) * 100;
            return r;
        }

        string convert2Key(int a)
        {
            if (a >= 'A' && a <= 'Z')
                return Convert.ToChar(a).ToString();
            if (a >= 96 && a <= 105)
            {
                return "(N)" + (a - 96).ToString();
            }
            if (a >= 48 && a <= 57)
            {
                return (a - 48).ToString();
            }
            switch (a)
            {
                case 106:
                    return "(N)*";
                case 107:
                    return "(N)+";
                case 109:
                    return "(N)-";
                case 110:
                    return "(N).";
                case 111:
                    return "(N)/";
                case 188:
                    return ",";
                case 187:
                    return "=";
                case 189:
                    return "-";
                case 190:
                    return ".";
                case 191:
                    return "/";
                case 192:
                    return "`";
                case 186:
                    return ";";
                case 222:
                    return "'";
                case 219:
                    return "[";
                case 221:
                    return "]";
                case 220:
                    return "\\";
                default:
                    return "Error";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) == 0)
            {
                foreach (long i in beatL)
                    beat.Add(i);
                foreach (long i in beatR)
                    beat.Add(i);
                beat.Sort();

                xScale = beat[beat.Count - 1] * 1f / (float)(BmpX - 1);
                yScale = beat.Count * 1f / (float)(BmpY - 1);

                drawPoints();

                double totaltime = beat[beat.Count - 1] / 100f;
                textBoxSec.Text = totaltime.ToString("f5");
                double abpm = beat.Count / (beat[beat.Count - 1] / 100f) * 60f / 4f;
                textBoxBPM.Text = abpm.ToString("f5");
                string blue = convert2Key(keyL);
                string red = (keyR == -1) ? "n" : convert2Key(keyR);
                textBoxBlue.Text = blue;
                textBoxRed.Text = (keyR == -1) ? "" : red;
                double tmp;
                tmp = rCal(beatL);
                textBoxBlueSta.Text = tmp.ToString("f5");
                if (tmp > 99.98)
                    textBoxBlueSta.Text += " Good!";
                else
                    if (tmp < 99.90)
                        textBoxBlueSta.Text += " Bad";
                    else
                        textBoxBlueSta.Text += " So-so";
                tmp = rCal(beatR);
                textBoxRedSta.Text = tmp.ToString("f5");
                if (tmp > 99.98)
                    textBoxRedSta.Text += " Good!";
                else
                    if (tmp < 99.90)
                        textBoxRedSta.Text += " Bad";
                    else
                        textBoxRedSta.Text += " So-so";
                tmp = rCal(beat);
                textBoxOverall.Text = tmp.ToString("f5");
                if (tmp > 99.98)
                    textBoxOverall.Text += " Good!";
                else
                    if (tmp < 99.90)
                        textBoxOverall.Text += " Bad";
                    else
                        textBoxOverall.Text += " So-so";
                drawSpeedLine();
            }
        }

        void drawPoints()
        {
            Graphics g = Graphics.FromImage(bmp);
            Pen l = new Pen(Color.Blue);
            Pen r = new Pen(Color.Red);
            for (int i = 0; i < beat.Count; i++)
            {
                if (beatL.IndexOf(beat[i]) >= 0)
                {
                    Point po = new Point(Convert.ToInt32(beat[i] / xScale), BmpY - 1 - Convert.ToInt32(i / yScale));
                    g.DrawRectangle(l, po.X, po.Y, 1, 1);
                }
                if (beatR.IndexOf(beat[i]) >= 0)
                {
                    Point po = new Point(Convert.ToInt32(beat[i] / xScale), BmpY - 1 - Convert.ToInt32(i / yScale));
                    g.DrawRectangle(r, po.X, po.Y, 1, 1);
                }
            }
            refresh();
        }

        void drawSpeedLine()
        {
            List<Point> p = new List<Point>();
            int oneSec = Convert.ToInt32(100 / xScale);
            double maxY = -1;
            double minY = 99999;
            for (int i = 0; i <= oneSec; i++)
            {
                int split = Convert.ToInt32(i * xScale);
                int sum = 0;
                for (int n = 0; n < beat.Count; n++)
                {
                    if (beat[n] <= split)
                        sum++;
                    else
                        break;
                }
                double speed = 500;
                if (split != 0)
                    speed = sum * 1f / (split / 100f) * 500;
                if (speed > maxY)
                    maxY = speed;
                if (speed < minY)
                    minY = speed;
                p.Add(new Point(i, Convert.ToInt32(speed)));
            }
            double maxBPS = -1;
            for (int i = oneSec + 1; i < BmpX; i++)
            {
                int split = Convert.ToInt32(i * xScale);
                int sum = 0;
                for (int n = 0; n < beat.Count; n++)
                {
                    if (beat[n] > split - 100 && beat[n] <= split)
                        sum++;
                    else
                        if (beat[n] > split)
                            break;
                }
                double speed = sum * 1f * 500;
                if (speed > maxY)
                    maxY = speed;
                if (speed < minY)
                    minY = speed;
                if (speed > maxBPS)
                    maxBPS = speed;
                p.Add(new Point(i, Convert.ToInt32(speed)));
            }
            double speedYScale = (maxY - minY) / 200;

            Graphics g = Graphics.FromImage(bmp);
            Pen myPen = new Pen(Color.Purple);
            foreach (Point i in p)
            {
                g.DrawRectangle(myPen, i.X, Convert.ToInt32(250 - i.Y / speedYScale), 0.5f, 0.5f);
            }
            refresh();

            if (Convert.ToDouble(textBoxSec.Text) > 1)
            {
                maxBPS /= 500;
                textBoxBPS.Text = maxBPS.ToString("f5");
            }
            else
            {
                textBoxBPS.Text = "Time's too short";
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            refresh();

            Graphics gg = this.CreateGraphics();
            Pen p = new Pen(Color.Black);
            gg.DrawLine(p, 650, 0, 650, 470);
            gg.DrawRectangle(p, 24, 64, BmpX + 1, BmpY + 1);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == keyL)
                keyLUp = true;
            if (e.KeyValue == keyR)
                keyRUp = true;
        }

        private void buttonSE_Click(object sender, EventArgs e)
        {
            OpenFileDialog dia = new OpenFileDialog();
            dia.Filter = "Wave|*.wav";
            if (dia.ShowDialog() == DialogResult.OK)
            {
                se = new FileInfo(dia.FileName);
                textBoxSE.Text = se.Name;
            }
        }
    }
}
