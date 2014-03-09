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
        public oprosnik opros;

        void update()
        {
            treeView1.Nodes.Clear();

            int k=0;
            foreach (var a in opros.elements)
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
            this.opros = new oprosnik();
            foreach (oprosnikElem e in opros.elements)
            {
                this.opros.addNewElement(e.question, e.answers, e.IsOneVariant);
            }
            update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> s = new List<string>();
            s.Add("первый вариант");
            s.Add("второй вариант");
            questionAdd qA = new questionAdd(new oprosnikElem("Ваш вопрос", s, true));
            qA.ShowDialog();
            if (qA.DialogResult == DialogResult.OK)
            {
                opros.addNewElement(qA.result.question, qA.result.answers, qA.result.IsOneVariant);
            }
            update();
        }
    }
}
