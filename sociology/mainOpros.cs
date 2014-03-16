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

            progressBar1.Value = page * 100 / res.selectedOprosnik.elements.Count();
        }
    }
}
