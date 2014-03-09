using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sociology
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void button1newOprosnik_Click(object sender, EventArgs e)
        {
            editOprosnik ed = new editOprosnik();
            ed.ShowDialog();
        }
    }
}
