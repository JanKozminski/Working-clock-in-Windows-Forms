using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiceClock
{
    public partial class NiceClock : Form
    {
        public NiceClock()
        {
            InitializeComponent();
            redButton.FlatStyle = FlatStyle.Flat;
            BlueButton.FlatStyle = FlatStyle.Flat;
            YellowButton.FlatStyle = FlatStyle.Flat;
            PurpleButton.FlatStyle = FlatStyle.Flat;
            OrangeButton.FlatStyle = FlatStyle.Flat;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClockTimer.Start();
        }

        private void ClockLabel_Click(object sender, EventArgs e)
        {

        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Red;
        }

       

        private void BlueButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Blue;
        }

        private void PurpleButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Purple;
        }

        private void YellowButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Yellow;
        }

        private void OrangeButton_Click(object sender, EventArgs e)
        {
            
             ClockLabel.ForeColor = Color.Orange;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClockLabel.Font = new Font("Impact", 92, FontStyle.Regular);
        }

        private void StyleButton2_Click(object sender, EventArgs e)
        {
            ClockLabel.Font = new Font("MV Boli", 92, FontStyle.Regular);
        }

        private void StyleButton3_Click(object sender, EventArgs e)
        {
            ClockLabel.Font = new Font("MS Gothic", 92, FontStyle.Regular);
        }
    }
}
