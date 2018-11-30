using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev2
{
    public partial class NemForm : Form
    {
        int count;
        public NemForm()
        {
            InitializeComponent();
        }

        private void NemForm_Load(object sender, EventArgs e)
        {
            count = Form1.nemList.Count;
            for (int i = 0; i < Form1.nemList.Count; i++)
            {
                listBox1.Items.Add(Form1.nemList[i]);
            }
            chart1.DataSource = Form1.nemList;
            chart1.Series[0].Points.DataBindXY(Form1.timelist, Form1.nemList);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count != Form1.nemList.Count)
            {
                listBox1.Items.Add(Form1.nemList[Form1.nemList.Count - 1]);
                count = Form1.nemList.Count;
                chart1.Series[0].Points.DataBindXY(Form1.timelist, Form1.nemList);
                label1.Text = "Ortalama : " + Form1.nemList.Average();
                label2.Text = "Max : " + Form1.nemList.Max();
                label3.Text = "Min : " + Form1.nemList.Min();

            }

        }
    }
}
