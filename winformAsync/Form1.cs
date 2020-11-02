using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void addbtn_Click(object sender, EventArgs e)
        {
            subtractbtn.Enabled = false;
            dividebtn.Enabled = false;
            multiplybtn.Enabled = false;
            await PerformTaskAsync(5);
            resultlb.Text = (Double.Parse(value1tbx.Text) + Double.Parse(value2tbx.Text)).ToString();
            subtractbtn.Enabled = true;
            dividebtn.Enabled = true;
            multiplybtn.Enabled = true;
        }

        private void PerformTask(int i)
        {
            progressBar.MarqueeAnimationSpeed = 1;
            Thread.Sleep(i * 1000);
            progressBar.MarqueeAnimationSpeed = 0;
        }

        private async Task PerformTaskAsync(int i)
        {
            progressBar.MarqueeAnimationSpeed = 1;
            await Task.Delay(i * 1000);
            progressBar.MarqueeAnimationSpeed = 0;
        }

        private async void subtractbtn_Click(object sender, EventArgs e)
        {
            await PerformTaskAsync(5);
            resultlb.Text = (Double.Parse(value1tbx.Text) - Double.Parse(value2tbx.Text)).ToString();
        }

        private void subtractbtn_mousehover(object sender, EventArgs e)
        {
            //MessageBox.Show("The mouse is hovering", "Test Hover", MessageBoxButtons.OK);
        }

        private async void dividebtn_Click(object sender, EventArgs e)
        {
            await PerformTaskAsync(5);
            resultlb.Text = (Double.Parse(value1tbx.Text) / Double.Parse(value2tbx.Text)).ToString();
        }

        private async void multiplybtn_Click(object sender, EventArgs e)
        {
            await PerformTaskAsync(5);
            resultlb.Text = (Double.Parse(value1tbx.Text) * Double.Parse(value2tbx.Text)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar.MarqueeAnimationSpeed = 0;
        }
    }
}
