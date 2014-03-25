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
            if (!x.load(way)) { MessageBox.Show("Это не файл опроса"); };
            label3ostalos.Text = (x.maxTesters - x.testers.Count).ToString();
            if (x.maxTesters - x.testers.Count < 1)
            {
                label3ostalos.Text = "0";
                button1.Enabled = false;
                button1.Text = "Опрос завершён";
            }
            label3desc.Text = x.Description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
