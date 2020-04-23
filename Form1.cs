using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordClock
{
    public partial class Form1 : Form
    {


      
        public void Ima() {
            string clock = DateTime.Now.ToString("hh mm");
            string[] aclock = clock.Split(' ');
            int sat = Convert.ToInt32(aclock[0]);
            int min = Convert.ToInt32(aclock[1]);
            int rest = 0;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;

            if (min >= 0 && min < 5) { label2.Visible = true; ; label3.Visible = true; }
            else if (min >= 5 && min < 10) { label2.Visible = true; label3.Visible = true; label4.Visible = true; label10.Visible = true; }
            else if (min >= 10 && min < 15) { label2.Visible = true; label3.Visible = true; label7.Visible = true; label10.Visible = true; }
            else if (min >= 15 && min < 20) { label2.Visible = true; label3.Visible = true; label8.Visible = true; label10.Visible = true; }
            else if (min >= 20 && min < 25) { label2.Visible = true; label3.Visible = true; label6.Visible = true; label10.Visible = true; }
            else if (min >= 25 && min < 30) { label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = true; label10.Visible = true; }
            else if (min >= 30 && min < 35) { label2.Visible = true; label3.Visible = true; label11.Visible = true; }
            else if (min >= 35 && min < 40) { label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = true; label9.Visible = true; }
            else if (min >= 40 && min < 45) { label2.Visible = true; label3.Visible = true; label6.Visible = true; label9.Visible = true; }
            else if (min >= 45 && min < 50) { label2.Visible = true; label3.Visible = true; label8.Visible = true; }
            else if (min >= 50 && min < 55) { label2.Visible = true; label3.Visible = true; label7.Visible = true; label9.Visible = true; }
            else { label2.Visible = true; ; label3.Visible = true; label4.Visible = true; label9.Visible = true; }
            if (sat == 0) label23.Visible = true;
            else if (sat == 12)
            {
                if (label9.Visible) 
                    label13.Visible = true;
                else
                    label23.Visible = true;
            }
            else if (sat == 1)
            {
                if (label9.Visible) 
                    label15.Visible = true;  
                else  
                    label13.Visible = true;   

            }
            else if (sat == 2)
            {
                if (label9.Visible) label16.Visible = true;
                else
                    label15.Visible = true;
            }
            else if (sat == 3)
            {
                if (label9.Visible) label17.Visible = true;
                else
                    label16.Visible = true;
            }
            else if (sat == 4)
            {
                if (label9.Visible) label12.Visible = true;
                else
                    label17.Visible = true;
            }
            else if (sat == 5)
            {
                if (label9.Visible) label18.Visible = true;
                else
                    label12.Visible = true;
            }
            else if (sat == 6)
            {
                if (label9.Visible) label20.Visible = true;
                else
                    label18.Visible = true;
            }
            else if (sat == 7)
            {
                if (label9.Visible) label19.Visible = true;
                else
                    label20.Visible = true;
            }
            else if (sat == 8)
            {
                if (label9.Visible) label21.Visible = true;
                else
                    label19.Visible = true;
            }
            else if (sat == 9)
            {
                if (label9.Visible) label22.Visible = true;
                else
                    label21.Visible = true;
            }
            else if (sat == 10)
            {
                if (label9.Visible) label14.Visible = true;
                else
                    label22.Visible = true;
            }
            else if (sat == 11)
                if (label9.Visible) label23.Visible = true;
                 else 
                    label14.Visible = true;
            rest = min % 5;
            if (rest == 1) { label28.Visible = true; }
            if (rest == 2) { label28.Visible = true; label29.Visible = true; }
            if (rest == 3) { label28.Visible = true; label29.Visible = true; label30.Visible = true; }
            if (rest == 4) { label28.Visible = true; label29.Visible = true; label30.Visible = true; label31.Visible = true; }
            
        }
        public Form1()
        {

            InitializeComponent();
            





        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Ima();
        }


    }
}
