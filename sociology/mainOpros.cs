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
    public partial class mainOpros : Form
    {
        opros res;
        int page=0;

        public mainOpros(opros x)
        {
            InitializeComponent();
            res = x;
            changePage();

            foreach (var i in res.selectedOprosnik.elements) //заполним список ответов пустотой :\
            {
                res.testers[0].answers.Add(new answer(new List<bool>()));
            }
        }

        void changePage()
        {
            System.Drawing.Size size = new System.Drawing.Size(371, 24);
            System.Drawing.Point pos = new Point(3, 3);

            var x = res.selectedOprosnik.elements[page];
            richTextBox1quest.Text = x.question;
            panel1.Controls.Clear();
            foreach (string s in x.answers)
            {
                if (x.IsOneVariant) //radio
                {
                    RadioButton rb = new RadioButton();
                    rb.Location = pos;
                    rb.Size = size;
                    rb.Text = s;
                    this.panel1.Controls.Add(rb);
                }

                else //check
                {
                    CheckBox ch = new CheckBox();
                    ch.Location = pos;
                    ch.Size = size;
                    ch.Text = s;
                    this.panel1.Controls.Add(ch);
                }

                pos.Y += 30;
            }

            progressBar1.Value = (page+1) * 100 / res.selectedOprosnik.elements.Count();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //назад
            if (page > 0) page--;
            changePage();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            res.testers[0].answers[page].SelectedAnswers.Clear();
            foreach (object u in this.panel1.Controls)
            {
                if (u is RadioButton) res.testers[0].answers[page].SelectedAnswers.Add((u as RadioButton).Checked);
                if (u is CheckBox) res.testers[0].answers[page].SelectedAnswers.Add((u as CheckBox).Checked);
            }

            //вперед
            if (page < res.selectedOprosnik.elements.Count - 1)
            {
                page++;
 
                changePage();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
