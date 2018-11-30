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

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count != Form1.nemList.Count)
            {
                listBox1.Items.Add(Form1.nemList[Form1.nemList.Count - 1]);
                count = Form1.nemList.Count;
            }

        }
    }
}
