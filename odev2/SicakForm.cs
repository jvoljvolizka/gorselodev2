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
    public partial class Sıcaklık : Form
    {
        int count;
        public Sıcaklık()
        {
            InitializeComponent();
            
        }

        private void Sıcaklık_Load(object sender, EventArgs e)
        {
            count = Form1.sicakList.Count;
            for (int i = 0; i < Form1.sicakList.Count; i++)
            {
                listBox1.Items.Add(Form1.sicakList[i]);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count != Form1.sicakList.Count)
            {
                listBox1.Items.Add(Form1.sicakList[Form1.sicakList.Count - 1]);
                count = Form1.sicakList.Count;
            }

        }
    }
}
