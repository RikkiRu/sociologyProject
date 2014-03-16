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
            }


        }

        private void label_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Label).Text);
        }
    }
}
