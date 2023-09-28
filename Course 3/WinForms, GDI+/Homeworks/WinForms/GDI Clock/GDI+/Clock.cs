using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GDI_Clock
{
    public partial class FormClock : Form
    {
        Graphics g;
        Timer timer;
        Point center;
        Bitmap bmp;
        Font font;
        List<Point> masPointClock;
        int ss;
        int mm;
        int hh;

        public FormClock()
        {
            InitializeComponent();
        }

        private void FormClock_Load(object sender, EventArgs e)
        {
            masPointClock = new List<Point>();
            center = new Point(ClientSize.Width / 2, ClientSize.Height / 2);
            bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            font = new Font("Arial", 8f);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ss = DateTime.Now.Second;
            mm = DateTime.Now.Minute;
            hh = DateTime.Now.Hour;
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            // Smoothing(сглаживание)
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Border clock
            for (int i = 0; i < 60; i++)
            {
                Point temp = new Point();
                temp = ArrowCalc(center, i, 60);
                masPointClock.Add(temp);
              
                if(i == 15 || i == 30 || i == 45 || i == 0)
                    g.DrawLine(new Pen(Brushes.Black, 3), ArrowCalc(center, i, 75), ArrowCalc(center, i, 84));
                if (i % 5 == 0 && i != 15 || i % 5 == 0 && i != 30 || i % 5 == 0 && i != 45 || i % 5 == 0 && i != 0)
                    g.DrawLine(new Pen(Brushes.Black, 2), ArrowCalc(center, i, 75), ArrowCalc(center, i, 84));
                else
                    g.DrawLine(new Pen(Brushes.Black, 1), ArrowCalc(center, i, 79), ArrowCalc(center, i, 84));
            }

            

            // Numbers
            for (int i = 0; i < 60; i++)
            {
                if(i == 59)
                    g.DrawString(" 12", font, Brushes.Black, ArrowCalc(center, i, 101));
                if (i == 14)
                    g.DrawString("3", font, Brushes.Black, ArrowCalc(center, i, 90));
                if (i == 31)
                    g.DrawString("  6", font, Brushes.Black, ArrowCalc(center, i, 90));
                if (i == 46)
                    g.DrawString("9", font, Brushes.Black, ArrowCalc(center, i, 104));
            }
           

            // Center
            g.DrawLine(new Pen(Brushes.Black, 4), center, new Point(ClientSize.Width/2 + 1, ClientSize.Height/2 + 1));


            // Draw Cirle of Clock
            g.DrawEllipse(new Pen(Brushes.Black, 2), (ClientSize.Width/2) - 87 , (ClientSize.Height/2) - 87 , 174, 174);


            // Draw Arrows
            Pen ssec = new Pen(Brushes.Black, 1);
            ssec.SetLineCap(LineCap.NoAnchor, LineCap.ArrowAnchor, DashCap.Round);

            Pen mmin = new Pen(Brushes.Black, 2);
            mmin.SetLineCap(LineCap.NoAnchor, LineCap.ArrowAnchor, DashCap.Round);

            Pen hhour = new Pen(Brushes.Black, 4);
            hhour.SetLineCap(LineCap.NoAnchor, LineCap.ArrowAnchor, DashCap.Round);

            g.DrawLine(ssec, center, ArrowCalc(center, ss, 80));
            g.DrawLine(mmin, center, ArrowCalc(center, mm, 80));
            g.DrawLine(hhour, center, ArrowCalcHour(center, hh, 60));

            this.Text = $"{hh}:{mm}:{ss}";
            pictureBoxClock.Image = bmp;
            g.Dispose();
        }

        private Point ArrowCalc(Point cent, int val, int r)
        {
            int x = (int)(center.X + r * Math.Cos(-Math.PI / 2 + Math.PI * val / 30));
            int y = (int)(center.Y + r * Math.Sin(-Math.PI / 2 + Math.PI * val / 30));
            return new Point(x, y);
        }

        private Point ArrowCalcHour(Point cent, int val, int r)
        {
            int x = (int)(center.X + r * Math.Cos(-Math.PI / 2 + Math.PI * val / 6));
            int y = (int)(center.Y + r * Math.Sin(-Math.PI / 2 + Math.PI * val / 6));
            Point tt = new Point(x, y);
            for (int i = 0; i < masPointClock.Count; i++)
            {
                if (tt == masPointClock[i])
                {
                    int tempCalc = mm / 12;
                    return masPointClock[i + tempCalc];
                }
            }
            return new Point(x, y);
        }
    }
}
