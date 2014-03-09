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
    public partial class questionAdd : Form
    {
        public oprosnikElem result;

        public questionAdd(oprosnikElem elem)
        {
            InitializeComponent();

            result = new oprosnikElem();
            result.answers = elem.answers;
            result.IsOneVariant = elem.IsOneVariant;
            result.question = elem.question;

            textBox1.Text = result.question;
            foreach (string temp in result.answers)
            {
                richTextBox1.Text += temp + Environment.NewLine;
            }
            checkBox1.Checked = result.IsOneVariant;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || richTextBox1.Text == "") { MessageBox.Show("Не все поля заполнены"); return; }
            else
            {
                DialogResult = DialogResult.OK;
                result.question = textBox1.Text;
                result.IsOneVariant = checkBox1.Checked;
                result.answers.Clear();
                foreach (string a in richTextBox1.Lines)
                {
                    if (a != "")
                    {
                        result.answers.Add(a);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
