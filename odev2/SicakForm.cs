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
        public Sıcaklık()
        {
            InitializeComponent();
            
        }

        private void Sıcaklık_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.sicakList.Count; i++)
            {
                listBox1.Items.Add(Form1.sicakList[i]);
            }
        }
    }
}
