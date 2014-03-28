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
    public partial class testerView : Form
    {
        tester res;
        List<oprosnikElem> oprosnik;

        public testerView(tester t, List<oprosnikElem> l)
        {
            InitializeComponent();
            res = t;
            oprosnik=l;

            foreach (var te in oprosnik)
            {
                treeView1.Nodes.Add(te.question);
            }
        }

        private void testerView_Load(object sender, EventArgs e)
        {
            foreach (var x in res.anketa)
            {
                richTextBox1.Text += x + Environment.NewLine;
            }

            for (int i = 0; i < oprosnik.Count; i++)
            {
                for(int j=0; j<oprosnik[i].answers.Count; j++)
                {
                    treeView1.Nodes[i].Nodes.Add(oprosnik[i].answers[j]);
                    if(res.answers[i].SelectedAnswers[j]==true) treeView1.Nodes[i].Nodes[j].BackColor = Color.Green;
                }
            }
        }
    }
}
