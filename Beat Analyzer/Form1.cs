using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;
using System.IO;

namespace Beat_Analyzer
{
    public partial class Form1 : Form
    {
        /* The General Area Starts */
        List<long> beatL = new List<long>();
        List<long> beatR = new List<long>();
        List<long> beat = new List<long>();
        DateTime start;
        int keyL, keyR;

        FileInfo se = null;

        double xScale, yScale;
        bool keyLUp = true, keyRUp = true;

        static Bitmap bmp = new Bitmap(BmpX, BmpY);
        const int BmpX = 615, BmpY = 466;
        const int offsetX = 24, offsetY = 65;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;

            labelAcc.Hide();
            groupBoxTimeLineMode.Hide();
            chart1.Hide();

            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, 0, 0, BmpX - 1, BmpY - 1);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (radioButtonTimeLineMode.Checked && started)
            {
                if (se != null)
                    if (se.Exists)
                    {
                        playSound playSoundObject = new playSound(se.FullName);
                        Thread playSoundThread = new Thread(playSoundObject.play);
                        playSoundThread.Start();
                    }

                if (((e.KeyValue <= 'Z' && e.KeyValue >= 'A') || e.KeyValue == 188 || e.KeyValue == 190 || e.KeyValue == 191 || e.KeyValue == 186 || e.KeyValue == 222
                    || e.KeyValue == 219 || e.KeyValue == 221 || e.KeyValue == 220 || (e.KeyValue >= 96 && e.KeyValue <= 107)
                    || (e.KeyValue >= 109 && e.KeyValue <= 111) || e.KeyValue == 189 || e.KeyValue == 187 || e.KeyValue == 192
                    || (e.KeyValue >= 48 && e.KeyValue <= 57)))
                {
                    //labelAcc.Text = e.KeyValue.ToString();
                    //labelAcc.Update();

                    DateTime pressTime = DateTime.Now;
                    pressTime = pressTime.AddMilliseconds(calibration);

                    long ms = getMs(start, pressTime);
                    int near = 0;

                    for (int i = searchFrom; i < beatMap.Count; i++)
                    {
                        if (i > 0)
                            if (Math.Abs(ms - beatMap[i - 1]) < Math.Abs(ms - beatMap[i]))
                                break;

                        if ((Math.Abs(ms - beatMap[i]) < Math.Abs(ms - beatMap[near]) && (deviation[i] == -999)))
                            near = i;
                    }

                    if (near == 0 && searchFrom != 0)
                        return;

                    long delay = Math.Abs(beatMap[near] - ms);
                    if (delay <= miss)
                    {
                        deviation[near] = ms - beatMap[near];
                        searchFrom = near;
                    }
                    
                    if (delay <= just)
                    {
                        labelAcc.Text = "Just!";
                        labelAcc.Update();

                        mark[near] = 3;
                    }
                    else
                        if (delay <= great)
                        {
                            labelAcc.Text = "Great";
                            labelAcc.Update();

                            mark[near] = 2;
                        }
                        else
                            if (delay <= good)
                            {
                                labelAcc.Text = "Good";
                                labelAcc.Update();

                                mark[near] = 1;
                            }
                            else
                                if (delay <= miss)
                                {
                                    labelAcc.Text = "Miss";
                                    labelAcc.Update();

                                    mark[near] = 0;
                                }
                                else
                                {
                                    labelAcc.Text = "Ign";
                                    labelAcc.Update();
                                }
                                
                }
            }

            if (radioButtonSpeedMode.Checked)
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
                        if (se != null)
                            if (se.Exists)
                            {
                                playSound playSoundObject = new playSound(se.FullName);
                                Thread playSoundThread = new Thread(playSoundObject.play);
                                playSoundThread.Start();
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
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            if (radioButtonSpeedMode.Checked)
            {
                string msg = "";
                msg += "Select an SE and input the beat sum first\n";
                msg += "Then just click start, then choose two keys on your keyboard and hit them as fast as you can\n";
                msg += "After you finish, the analyzer will give you the results automatically";
                MessageBox.Show(msg, "Help");
            }
            if (radioButtonTimeLineMode.Checked)
            {
                string msg = "";
                msg += "Beat Sum: The sum number of beats you want\n";
                msg += "Interval: The interval between two beats\n";
                msg += "Calibration: Edit the number as you like. It will be added to all your beats\n";
                msg += "Inner: The size of the note itself\n";
                msg += "Outer: The size of the biggest circle. Note that it means \"How larger is the biggest circle than the note itself\"\n";
                msg += "Approach Rate: The narrowing sppeed. The smaller, the faster\n";
                msg += "Difficulty Settings: Set the ranges of the judgements";
                MessageBox.Show(msg, "Help");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, 0, 0, BmpX, BmpY);
            refresh();

            if (radioButtonTimeLineMode.Checked)
            {
                if (started)
                {
                    button1.Enabled = true;
                    button1.Text = "(Re)Start";
                    started = false;
                    return;
                }

                if (!checkInput())
                    return;

                chart1.Hide();
                labelAcc.Show();
                searchFrom = 0;

                button1.Text = "Stop";
                button1.Enabled = false;

                // Start
                started = true;

                // Set the position of the inner circle
                circleX = (int)(BmpX / 2 - circleSize / 2);
                circleY = (int)(BmpY / 2 - circleSize / 2);

                // Generate the Beatmap
                beatMap.Clear();
                circleMap.Clear();
                mark.Clear();
                deviation.Clear();
                for (int i = 0; i < beatSum; i++)
                    beatMap.Add(i * interval + 3000);   // Give users 3s for preparing
                foreach (long i in beatMap)
                {
                    circleMap.Add(i - outerSize * approachRate);
                    mark.Add(0);
                    deviation.Add(-999);
                }
                renderWait = beatMap[0] - outerSize * approachRate;

                // Initialize the timer
                updateTimer.AutoReset = true;
                updateTimer.Elapsed += update;

                // Rendering
                initializeBackgroundRender();
                backgroundRender.RunWorkerAsync();
            }

            if (radioButtonSpeedMode.Checked)
            {
                textBox1.Text = maskedTextBox1.Text;
                beatL.Clear();
                beatR.Clear();
                beat.Clear();
                keyL = -1;
                keyR = -1;
            }
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

        private void radioButtonSpeedMode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSpeedMode.Checked)
            {
                groupBoxSpeedMode.Show();
                groupBoxTimeLineMode.Hide();
                labelAcc.Hide();
            }
        }

        private void radioButtonTimeLineMode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTimeLineMode.Checked)
            {
                groupBoxSpeedMode.Hide();
                groupBoxTimeLineMode.Show();
                updateTotalTime();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            refresh();

            Graphics gg = this.CreateGraphics();
            Pen p = new Pen(Color.Black);
            gg.DrawLine(p, 655, 0, 655, 580);
            gg.DrawRectangle(p, offsetX - 1, offsetY - 1, BmpX + 1, BmpY + 1);
        }

        void refresh()
        {
            this.CreateGraphics().DrawImage(bmp, offsetX, offsetY);
        }
        /* The General Area Ends */



        /* The Speed Mode Starts */
        long getInterval(DateTime st, DateTime ed)
        {
            TimeSpan t = ed - st;
            long re = t.Ticks / 100000;
            return Math.Abs(re);
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
        /* The Speed Mode Ends */



        /* The Time Line Mode Starts */
        volatile List<long> beatMap = new List<long>();
        volatile List<long> circleMap = new List<long>();
        volatile List<int> mark = new List<int>();
        volatile List<long> deviation = new List<long>();
        volatile int searchFrom = 0;

        bool started = false;

        int just, great, good, miss;

        volatile int beatSum;
        volatile int calibration;
        volatile int circleSize = 40;
        volatile int outerSize = 85;
        volatile int circleX = 200, circleY = 200;
        volatile int approachRate = 20;
        volatile int interval = 500;
        
        Pen circle = new Pen(Color.Black);
        Pen outer = new Pen(Color.Blue);
        Pen erase = new Pen(Color.White);

        public volatile List<Bitmap> cache = new List<Bitmap>();

        private Object lockthis = new Object();

        System.Timers.Timer updateTimer = new System.Timers.Timer(1);
        System.Timers.Timer drawTimer = new System.Timers.Timer(1);

        double renderWait = 0;
        double renderInterval = 0;

        long getMs(DateTime st, DateTime ed)
        {
            TimeSpan t = ed - st;
            long re = t.Ticks / 10000;
            return Math.Abs(re);
        }

        bool checkInput()
        {
            // Check the input values
            try
            {
                beatSum = Convert.ToInt32(textBoxBeatSum.Text);
                interval = Convert.ToInt32(textBoxInterval.Text);
                calibration = Convert.ToInt32(textBoxCalibration.Text);
                circleSize = Convert.ToInt32(textBoxCircleSize.Text);
                outerSize = Convert.ToInt32(textBoxOuter.Text);
                approachRate = Convert.ToInt32(textBoxApproachRate.Text);
                just = Convert.ToInt32(textBoxJust.Text);
                great = Convert.ToInt32(textBoxGreat.Text);
                good = Convert.ToInt32(textBoxGood.Text);
                miss = Convert.ToInt32(textBoxMiss.Text);
            }
            catch
            {
                MessageBox.Show("Illegal Input!", "Error");
                return false;
            }
            string inputError = "";
            if (beatSum < 10)
                inputError += "Beat sum should be an integer greater than or equal to 10\n";
            if (interval < 10)
                inputError += "Interval should be an integer greater than or equal to 10\n";
            if (circleSize < 5)
                inputError += "Circle size should be an integer greater than or equal to 5\n";
            if (circleSize + outerSize > 200)
                inputError += "Circle Size + Outer Size should be an integer less than or equal to 200\n";
            if (approachRate <= 0)
                inputError += "Approach rate should be an integer greater than 0\n";
            if (!(just < great && great < good && good < miss))
                inputError += "You must obey the rule of Just<Great<Good<Ignore";
            if (outerSize * approachRate > 2500)
                inputError += "Outer * Approach Rate should be less than or equal to 2500\n";
            if (inputError != "")
            {
                inputError = inputError.Substring(0, inputError.Length - 1);
                MessageBox.Show(inputError, "Error");
                return false;
            }
            return true;
        }

        void update(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!started)
            {
                updateTimer.Enabled = false;
                return;
            }

            // Update the stop watch
            try
            {
                textBoxStopWatch.Text = (getMs(start, DateTime.Now) / 1000f).ToString("0.000");
            }
            catch
            {

            }

            if (getMs(start, DateTime.Now) >= (beatSum - 1) * interval + 3000 + miss)
            {
                updateTimer.AutoReset = false;
                updateTimer.Enabled = false;
                started = false;
                button1.Enabled = true;
                button1.Text = "(Re)Start";
                return;
            }
        }

        void drawNoteMulti(object sender, System.Timers.ElapsedEventArgs e)
        {
            int p1, p2, p3;
            int nlt = outerSize * approachRate;
            int max = (int)Math.Truncate(nlt / (double)interval + 1);

            p1 = (int)Math.Truncate((max - 1) * interval / (double)approachRate - 1);
            p2 = p1 + (int)Math.Truncate(interval / (double)approachRate);
            p3 = cache.Count() - 1;

            Graphics m = this.CreateGraphics();
            renderInterval = ((beatSum - 1) * interval + nlt) / (double)(p1 + (p2 - p1) * (beatSum - max) + p3 - p2);
            renderInterval = renderInterval * 0.9996;

            //int n = 0;

            button1.Enabled = true;
            // Period 1
            for (int i = 0; i <= p1; i++)
            {
                while (getMs(start, DateTime.Now) < renderWait)
                    System.Threading.Thread.Sleep(1);
                if (!started)
                    return;
                renderWait += renderInterval;
                m.DrawImage(cache[i], offsetX, offsetY);
                //n++;
            }
            // Period 2
            int toDraw = max;
            while (toDraw != beatSum)
            {
                for (int i = p1 + 1; i <= p2; i++)
                {
                    while (getMs(start, DateTime.Now) < renderWait)
                        System.Threading.Thread.Sleep(1);
                    if (!started)
                        return;
                    renderWait += renderInterval;
                    m.DrawImage(cache[i], offsetX, offsetY);
                    //n++;
                }
                toDraw++;
            }
            //Period 3
            for (int i = p2 + 1; i <= p3; i++)
            {
                while (getMs(start, DateTime.Now) < renderWait)
                    System.Threading.Thread.Sleep(1);
                if (!started)
                    return;
                renderWait += renderInterval;
                m.DrawImage(cache[i], offsetX, offsetY);
                //n++;
            }
            //MessageBox.Show(getMs(start, DateTime.Now).ToString());
            //MessageBox.Show(renderInterval.ToString());
            //MessageBox.Show(n.ToString());
        }

        void drawNoteSingle(object sender, System.Timers.ElapsedEventArgs e)
        {
            Graphics m = this.CreateGraphics();
            double renderInterval = approachRate * 0.996;

            button1.Enabled = true;

            for (int i = 1; i <= beatSum; i++)
            {
                while (getMs(start, DateTime.Now) < circleMap[i - 1])
                    System.Threading.Thread.Sleep(1);
                for (int k = 0; k <= outerSize; k++)
                {
                    if (!started)
                        return;
                    while (getMs(start, DateTime.Now) < circleMap[i - 1] + k * renderInterval)
                        System.Threading.Thread.Sleep(1);
                    m.DrawImage(cache[k], offsetX, offsetY);
                }
            }

            MessageBox.Show(getMs(start, DateTime.Now).ToString());
        }

        void updateTotalTime()
        {
            try
            {
                double tt = (Convert.ToInt32(textBoxBeatSum.Text) * Convert.ToInt32(textBoxInterval.Text)) / 1000d;
                tt = Math.Round(tt, 3);
                textBoxTotalTime.Text = tt.ToString("0.000");
            }
            catch
            {

            }
        }

        private void textBoxBeatSum_TextChanged(object sender, EventArgs e)
        {
            updateTotalTime();
        }

        private void textBoxInterval_TextChanged(object sender, EventArgs e)
        {
            updateTotalTime();
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            if (!started)
            {
                chart1.Series["time"].Points.Clear();
                for (int i = 1; i <= beatSum; i++)
                    if (deviation[i - 1] != -999)
                        chart1.Series["time"].Points.AddXY(i, deviation[i - 1]);
                chart1.Series["time"].ChartType = SeriesChartType.Line;
                chart1.Show();
            }
        }

        /* Generate the cache */
        BackgroundWorker backgroundRender = new BackgroundWorker();

        void initializeBackgroundRender()
        {
            backgroundRender.DoWork += backgroundRender_DoWork;
            backgroundRender.RunWorkerCompleted += backgroundRender_RunWorkerCompleted;
        }

        void backgroundRender_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            textBoxStopWatch.Text = "Finished";
            cache = (List<Bitmap>)e.Result;

            
            // Initialize the start Time
            start = DateTime.Now.AddMilliseconds(1);

            //button1.Enabled = true;

            int nlt = outerSize * approachRate;
            if (nlt > interval)
            {
                drawTimer.AutoReset = false;
                drawTimer.Elapsed += drawNoteMulti;
            }
            else
            {
                drawTimer.AutoReset = false;
                drawTimer.Elapsed += drawNoteSingle;
            }

            updateTimer.Enabled = true;
            drawTimer.Enabled = true;
            
        }

        void backgroundRender_DoWork(object sender, DoWorkEventArgs e)
        {
            textBoxStopWatch.Text = "Initializing...";
            BackgroundWorker worker = sender as BackgroundWorker;
            e.Result = render(worker, e);
        }

        List<Bitmap> render(BackgroundWorker worker, DoWorkEventArgs e)
        {
            int nlt = outerSize * approachRate;
            long time = 3000 - nlt;
            int max = (int)Math.Truncate(nlt / (double)interval + 1);

            List<Bitmap> re = new List<Bitmap>();
            List<long> livingCircles = new List<long>();

            Pen inner = new Pen(Color.Black);
            Pen outer = new Pen(Color.Blue);
            Pen erase = new Pen(Color.White);

            // Multi-note Mode
            /*
             *  TimeSpan(ms)										#X Circle to Display		Circles Living
                3000-NLT											1							1
                3000-NLT+Interval						        	2							2
                ......
                3000-NLT+(MAX-1)*Interval				        	MAX							MAX=NLT / Interval
                // Cycling Starts
                // A MAX cirlce displayed → The smallest circle disappeared → The next circle display
                // This interval = Interval
                ......
                // Cycleing Ends
                3000-NLT+(beatSum-1)*Interval		            	The last MAX circle		    MAX
                ......												None
                3000+(beatSum-1)*Interval					        None						0
             * */
            if (nlt > interval)
            {
                // first circle
                Bitmap toRender = new Bitmap(BmpX, BmpY);
                Graphics rendering = Graphics.FromImage(toRender);
                rendering.FillRectangle(Brushes.White, 0, 0, BmpX - 1, BmpY - 1);
                rendering.DrawEllipse(inner, circleX, circleY, circleSize, circleSize);
                rendering.DrawEllipse(outer, circleX - outerSize, circleY - outerSize, circleSize + outerSize * 2, circleSize + outerSize * 2);
                livingCircles.Add(circleX - outerSize);
                re.Add(new Bitmap(toRender));


                // first period (circle number increasing) & second period (cycling period)
                for (long i = time + approachRate; i <= time + max * interval; i = i + approachRate)
                {
                    // narrow currently existing circles first
                    for (int k = livingCircles.Count() - 1; k >= 0; k--)
                    {
                        long distance = circleX - livingCircles[k];
                        rendering.DrawEllipse(erase, livingCircles[k], circleY - distance, distance * 2 + circleSize, distance * 2 + circleSize);
                        livingCircles[k]++;
                        if (livingCircles[k] == circleX)
                        {
                            livingCircles.RemoveAt(k);
                        }
                        else
                        {
                            distance = circleX - livingCircles[k];
                            rendering.DrawEllipse(outer, livingCircles[k], circleY - distance, distance * 2 + circleSize, distance * 2 + circleSize);
                        }
                    }

                    // whether we should draw a new circle or not
                    if (livingCircles[livingCircles.Count() - 1] - (circleX - outerSize) == interval / approachRate)
                    {
                        rendering.DrawEllipse(outer, circleX - outerSize, circleY - outerSize, circleSize + outerSize * 2, circleSize + outerSize * 2);
                        livingCircles.Add(circleX - outerSize);
                    }

                    // save the new bitmap
                    re.Add(new Bitmap(toRender));
                }

                // third period (circle number decreasing)
                while (livingCircles.Count() > 0)
                {
                    // narrow currently existing circles
                    for (int k = livingCircles.Count() - 1; k >= 0; k--)
                    {
                        long distance = circleX - livingCircles[k];
                        rendering.DrawEllipse(erase, livingCircles[k], circleY - distance, distance * 2 + circleSize, distance * 2 + circleSize);
                        livingCircles[k]++;
                        if (livingCircles[k] == circleX)
                        {
                            livingCircles.RemoveAt(k);
                        }
                        else
                        {
                            distance = circleX - livingCircles[k];
                            rendering.DrawEllipse(outer, livingCircles[k], circleY - distance, distance * 2 + circleSize, distance * 2 + circleSize);
                        }
                    }

                    re.Add(new Bitmap(toRender));
                }
                /*
                for (int i = 0; i < re.Count(); i++)
                {
                    re[i].Save("D:\\test\\" + i.ToString() + ".bmp");
                }
                */
                return re;
            }

            // Single note mode
            if (nlt <= interval)
            {
                // draw the first circle
                Bitmap toRender = new Bitmap(BmpX, BmpY);
                Graphics rendering = Graphics.FromImage(toRender);
                rendering.FillRectangle(Brushes.White, 0, 0, BmpX - 1, BmpY - 1);
                rendering.DrawEllipse(inner, circleX, circleY, circleSize, circleSize);
                rendering.DrawEllipse(outer, circleX - outerSize, circleY - outerSize, circleSize + outerSize * 2, circleSize + outerSize * 2);
                livingCircles.Add(circleX - outerSize);
                re.Add(new Bitmap(toRender));

                // narrow it
                while (livingCircles.Count() > 0)
                {
                    // narrow currently existing circles
                    for (int k = livingCircles.Count() - 1; k >= 0; k--)
                    {
                        long distance = circleX - livingCircles[k];
                        rendering.DrawEllipse(erase, livingCircles[k], circleY - distance, distance * 2 + circleSize, distance * 2 + circleSize);
                        livingCircles[k]++;
                        if (livingCircles[k] == circleX)
                        {
                            livingCircles.RemoveAt(k);
                        }
                        else
                        {
                            distance = circleX - livingCircles[k];
                            rendering.DrawEllipse(outer, livingCircles[k], circleY - distance, distance * 2 + circleSize, distance * 2 + circleSize);
                        }
                    }

                    re.Add(new Bitmap(toRender));
                }

                /*
                for (int i = 0; i < re.Count(); i++)
                {
                    re[i].Save("D:\\test\\" + i.ToString() + ".bmp");
                }
                */
                return re;
            }

            return null;
        }
        /* The Time Line Mode Ends */
    }
}
