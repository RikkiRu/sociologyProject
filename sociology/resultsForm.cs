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
    public partial class resultsForm : Form
    {
        opros res;

        public resultsForm(string way)
        {
            InitializeComponent();
            res = new opros();
            res.load(way);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //данные ответов

        }
    }
}
