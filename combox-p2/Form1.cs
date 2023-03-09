using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combox_p2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnome.TextLength == 0)
                MessageBox.Show("Por Favor diguite algo!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtnome.Focus();

            {
                cmblista.Items.Add(txtnome.Text);
                txtnome.Clear();
                txtnome.Focus();
            }
        }
    }
}
