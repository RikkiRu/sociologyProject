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
    public partial class AnswersData : Form
    {
        opros res;
        public AnswersData(opros res)
        {
            InitializeComponent();
            this.res = res;

            foreach (var a in res.selectedOprosnik.elements)
            {
                treeView1.Nodes.Add(a.question);
                if (a.IsOneVariant) treeView1.Nodes[treeView1.Nodes.Count - 1].ForeColor = Color.Blue;
                else treeView1.Nodes[treeView1.Nodes.Count - 1].ForeColor = Color.Green;
                    //один ответ = синий
            }
        }

        public void info()
        {
            if (treeView1.SelectedNode == null) return;
            oprosnikElem x = new oprosnikElem(); 
            string find = treeView1.SelectedNode.Text;
            int nAnsw=0;
            for (int i=0; i<res.selectedOprosnik.elements.Count; i++)
            {
                if (res.selectedOprosnik.elements[i].question == find)
                {
                    x = res.selectedOprosnik.elements[i];
                    nAnsw=i;
                    break;
                }
            }

            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowCount = x.answers.Count+1;
      
            Label nl = new Label();
            nl.Text = "Ответ";
            tableLayoutPanel1.Controls.Add(nl, 0, 0);
            nl = new Label();
            nl.Text = "Выбрано";
            tableLayoutPanel1.Controls.Add(nl, 1, 0);
            nl = new Label();
            nl.Text = "%";
            tableLayoutPanel1.Controls.Add(nl, 2, 0);

            for (int i = 0; i < x.answers.Count; i++)
            {
                Label l = new Label();
                l.Text = x.answers[i];
                tableLayoutPanel1.Controls.Add(l, 0, i + 1);

                int temp = 0;
                foreach (var it in res.testers)
                {
                    if (it.answers[nAnsw].SelectedAnswers[i] == true) temp++;
                }
                l = new Label();
                l.Text = temp.ToString();
                tableLayoutPanel1.Controls.Add(l, 1, i + 1);
                if(res.testers.Count!=0) temp = temp * 100 / res.testers.Count;
                l = new Label();
                l.Text = temp.ToString();
                tableLayoutPanel1.Controls.Add(l, 2, i + 1);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            info();
        }
    }
}
