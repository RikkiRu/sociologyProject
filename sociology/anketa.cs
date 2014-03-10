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
    public partial class anketa : Form
    {
        public opros res;
        public anketa(opros x)
        {
            InitializeComponent();
            res = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < richTextBox1.Lines.GetLength(0); i++)
            {
                res.anketa.Add(richTextBox1.Lines[i]);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
