using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace multithreading_Dawid_Ruth_58411
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }     
        private void Form1_Load(object sender, EventArgs e)
        {
            rd = new Random();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(t =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int width = rd.Next(0, this.Width);
                    int height = rd.Next(0, this.Height);
                    this.CreateGraphics().DrawEllipse(new Pen(Brushes.ForestGreen, 1), new Rectangle(width, height, 10, 10));
                    Thread.Sleep(100); 
                }          
            })
            { IsBackground = true };
            thread1.Start();

        }
        Random rd;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Thread thread2 = new Thread(t =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int width = rd.Next(0, this.Width);
                    int height = rd.Next(0, this.Height);
                    this.CreateGraphics().DrawEllipse(new Pen(Brushes.Orange, 1), new Rectangle(width, height, 10, 10));
                    Thread.Sleep(100);
                }
            })
            { IsBackground = true };
            thread2.Start();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Thread thread3 = new Thread(t =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int width = rd.Next(0, this.Width);
                    int height = rd.Next(0, this.Height);
                    this.CreateGraphics().DrawEllipse(new Pen(Brushes.Purple, 1), new Rectangle(width, height, 10, 10));
                    Thread.Sleep(100);
                }
            })
            { IsBackground = true };
            thread3.Start();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Thread thread4 = new Thread(t =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int width = rd.Next(0, this.Width);
                    int height = rd.Next(0, this.Height);
                    this.CreateGraphics().DrawEllipse(new Pen(Brushes.Black, 1), new Rectangle(width, height, 10, 10));
                    Thread.Sleep(100);
                }
            })
            { IsBackground = true };
            thread4.Start();

            Thread thread5 = new Thread(t =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int width = rd.Next(0, this.Width);
                    int height = rd.Next(0, this.Height);
                    this.CreateGraphics().DrawEllipse(new Pen(Brushes.Blue, 1), new Rectangle(width, height, 10, 10));
                    Thread.Sleep(100);
                }
            })
            { IsBackground = true };
            thread5.Start();
        }
    }

}
