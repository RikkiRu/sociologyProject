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
        public oprosnik oprosnikX;

        void update()
        {
            treeView1.Nodes.Clear();

            int k=0;
            foreach (var a in oprosnikX.elements)
            {
                treeView1.Nodes.Add(a.question);
                if (a.IsOneVariant) treeView1.Nodes[k].ForeColor = Color.Blue;
                else treeView1.Nodes[k].ForeColor = Color.Green;

                    foreach (var b in a.answers)
                    {
                        treeView1.Nodes[k].Nodes.Add(b);
                    }
                k++;
            }
        }

        public editOprosnik(oprosnik opros)
        {
            InitializeComponent();
            this.oprosnikX = new oprosnik();
            foreach (oprosnikElem e in opros.elements)
            {
                this.oprosnikX.addNewElement(e.question, e.answers, e.IsOneVariant);
            }
            update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> s = new List<string>();
            s.Add("Ваши варианты ответов (одна строка - один ответ)");
            questionAdd qA = new questionAdd(new oprosnikElem("Ваш вопрос", s, true));
            qA.ShowDialog();
            if (qA.DialogResult == DialogResult.OK)
            {
                oprosnikX.addNewElement(qA.result.question, qA.result.answers, qA.result.IsOneVariant);
            }
            update();
        }

        int searchInTree()
        {
            string question = "";
            try
            {
                question = treeView1.SelectedNode.Text;
            }
            catch
            {
                MessageBox.Show("Выделите вопрос");
            }

            for (int i = 0; i < oprosnikX.elements.Count; i++)
            {
                if (oprosnikX.elements[i].question == question)
                {
                    return i;
                }
            }

            return -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
                int x = searchInTree();
                if (x < 0) return;
                oprosnikX.elements.RemoveAt(x);
                update();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = searchInTree();
            if (x < 0) return;

            questionAdd qA = new questionAdd(oprosnikX.elements[x]);
            qA.ShowDialog();
            if (qA.DialogResult == DialogResult.OK)
            {
                oprosnikX.elements.RemoveAt(x);
                oprosnikX.addNewElement(qA.result.question, qA.result.answers, qA.result.IsOneVariant);
            }
            update();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if(this.DialogResult==DialogResult.OK)
            this.Close();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            oprosnikX.Save(saveFileDialog1.FileName);
            this.DialogResult = DialogResult.OK;
        }
    }
}
