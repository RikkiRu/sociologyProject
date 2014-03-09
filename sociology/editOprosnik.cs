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
    public partial class editOprosnik : Form
    {
        public editOprosnik(oprosnik opros)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> s = new List<string>();
            s.Add("Такие дела");
            s.Add("Пока не роидла");
            questionAdd qA = new questionAdd(new oprosnikElem("Воот", s, true));
            qA.ShowDialog();
        }
    }
}
