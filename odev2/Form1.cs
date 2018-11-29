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
        
        public static List<int> nemList = new List<int>();
        public static List<int> sicakList = new List<int>();
        
        Random rnd = new Random();
        bool basbool = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void sıcaklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sıcaklık newMDIChild = new Sıcaklık();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void nemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NemForm newMDIChild = new NemForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            if (basbool == true)
            {
                sicakList.Add(rnd.Next(10, 20));
                nemList.Add(rnd.Next(0, 100));
            }
        }

        private void başlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            basbool = true;
            timer1.Enabled = true;
        }

    }
}
