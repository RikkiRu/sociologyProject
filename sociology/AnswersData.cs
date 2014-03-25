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

            dataGridView1.Rows.Clear();

            for (int i = 0; i < x.answers.Count; i++)
            {
                dataGridView1.Rows.Add(new DataGridViewRow());
                dataGridView1.Rows[i].Cells[0].Value = x.answers[i];

                float temp = 0;
                foreach (var it in res.testers)
                {
                    if (it.answers[nAnsw].SelectedAnswers[i] == true) temp++;
                }
                dataGridView1.Rows[i].Cells[1].Value = temp.ToString();
                if(res.testers.Count!=0) temp = temp * 100 / res.testers.Count;
                dataGridView1.Rows[i].Cells[2].Value = temp.ToString();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            info();
        }

        void clickLabel(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Label).Text);
        }
    }
}
