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
    public partial class anketaFill : Form
    {
        opros res;
        List<TextBox> tList = new List<TextBox>();

        public anketaFill(opros op)
        {
            InitializeComponent();
            res = op;
            dosome();
        }

        void dosome()
        {
            System.Drawing.Size size = new Size(227, 22);
            System.Drawing.Point locate = new Point(15, 30);
            int distance = 20;

            for (int i = 0; i < res.anketa.Count; i++)
            {
            Label ltemp = new Label();
            TextBox ttemp = new TextBox();

                ltemp.AutoEllipsis = true;
                ltemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                ltemp.Location = locate;
                ltemp.Size = size;
                ltemp.Text = res.anketa[i];
                ltemp.Click += new System.EventHandler(this.label_Click);

                ttemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                ttemp.Location = new Point(locate.X + distance + size.Width, locate.Y);
                ttemp.Size = size;

                locate.Y += 25;
                this.Controls.Add(ltemp);
                this.Controls.Add(ttemp);
                tList.Add(ttemp);
            }

            locate.X += 170;
            locate.Y += 10;
            Button b = new Button();
            b.Location = locate;
            b.Name = "button1";
            b.Size = new System.Drawing.Size(144, 27);
            b.TabIndex = 1;
            b.Text = "Пройти опрос";
            b.UseVisualStyleBackColor = true;
            b.Click += new EventHandler(OkGoNext);
            Controls.Add(b);
        }

        void OkGoNext(object sender, EventArgs e)
        {
            foreach (TextBox t in tList)
            {
                res.testers[0].anketa.Add(t.Text); //новый тестер всегда нулевой
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Label).Text);
        }
    }
}
