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
            for (int i=0; i<res.selectedOprosnik.elements.Count; i++)
            {
                if (res.selectedOprosnik.elements[i].question == find)
                {
                    x = res.selectedOprosnik.elements[i];
                    break;
                }
            }

            tableLayoutPanel1.RowCount = x.answers.Count;

            int temp = 0;
            tableLayoutPanel1.Controls.Clear();
  
            foreach (var a in x.answers)
            {
                Label l = new Label();
                l.Text = a;
                tableLayoutPanel1.Controls.Add(l, 0, temp);
                temp++;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            info();
        }
    }
}
