using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulation_modelling_1_prj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResultsTable.Rows.Add("", "", "", "", "", "", "", "");
            ResultsTable.Rows.Add("", "", "", "", "", "", "", "");
            ResultsTable.Rows.Add("", "", "", "", "", "", "", "");

            ResultsTable.Rows[0].Cells[0].Value = "TimeStep";
            ResultsTable.Rows[1].Cells[0].Value = "Distance";
            ResultsTable.Rows[2].Cells[0].Value = "MaxHeight";
            ResultsTable.Rows[3].Cells[0].Value = "EndPoint Speed";
        }


        


        private void ValWeight_ValueChanged(object sender, EventArgs e)
        {

        }

        decimal t, x, y, v0, cosa, sina, S, m, k, vx, vy,dt;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int count = 0;
        decimal maxHeight;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        const decimal g = 9.81M;
        //const decimal dt = 1M;
        const decimal C = 0.15M;
        const decimal rho = 1.29M;




        private void LaunchBtn_Click(object sender, EventArgs e)
        {
            

            if (!timer1.Enabled)
            {
                count++;
                chart1.Series[0].Points.Clear();
                t = 0;
                x = 0;
                y = ValHeight.Value;
                maxHeight = ValHeight.Value;
                S = ValSize.Value;
                m = ValWeight.Value;
                dt = ValStep.Value;
                v0 = ValSpeed.Value;
                double a = (double)ValAngle.Value * Math.PI / 180;
                cosa = (decimal)Math.Cos(a);
                sina = (decimal)Math.Sin(a);
                k = 0.5M * C * rho * S / m;
                vx = v0 * cosa;
                vy = v0 * sina;
                chart1.Series[0].Points.AddXY(x, y);
                timer1.Start();

            }


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            t += dt;// I don't understand this line tbh, t is not used anywhere?

            decimal v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;

            x = x + vx * dt;
            y = y + vy * dt;
            if (y > maxHeight) maxHeight = y;

            
            speedtxt.Text = v.ToString() ;
            chart1.Series[0].Points.AddXY(x, y);
            if (y <= 0)
            {
                timer1.Stop();
                if (count < 7)
                {
                    
                    ResultsTable.Rows[0].Cells[count].Value = dt;
                    ResultsTable.Rows[1].Cells[count].Value = decimal.Round(x,3);
                    ResultsTable.Rows[2].Cells[count].Value = decimal.Round(maxHeight, 3);
                    ResultsTable.Rows[3].Cells[count].Value = decimal.Round(v, 3);
                }

            }
        }




    }
}
