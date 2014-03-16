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
    public partial class FormBeginOpros : Form
    {
        public FormBeginOpros(string way, opros x)
        {
            InitializeComponent();
            x.load(way);
            label3ostalos.Text = (x.maxTesters - x.testers.Count).ToString();
            label3desc.Text = x.Description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
