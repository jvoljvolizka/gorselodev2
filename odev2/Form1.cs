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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sıcaklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SicakForm newMDIChild = new SicakForm();
 
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void nemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NemForm newMDIChild = new NemForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
