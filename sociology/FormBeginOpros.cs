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
        opros res;

        public FormBeginOpros(string way)
        {
            InitializeComponent();
            res = new opros();
            res.load(way);
        }
    }
}
