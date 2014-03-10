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
    public partial class editOprosMini : Form
    {
        public opros result;
        oprosnik x;

        public editOprosMini(oprosnik x)
        {
            InitializeComponent();
            this.x = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> s= new List<string>();
            try
            {
                result = new opros(Convert.ToInt32(textBox1.Text), richTextBox1.Text, x, checkBox1.Checked, s);
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Ошибка при создании опроса");
            }
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!=8) e.Handled = true;
        }
    }
}
