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
            if (!res.load(way)) { MessageBox.Show("Выбраный файл не является опросом"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //данные ответов
            AnswersData ad = new AnswersData(res);
            ad.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OproshinieData od = new OproshinieData(res);
            od.ShowDialog();
        }
    }
}
