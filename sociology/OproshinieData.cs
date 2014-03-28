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
    public partial class OproshinieData : Form
    {
        opros res;
        int Count = 0;
        int Temp = 0;
        bool newSearch = true;
        List<int> finded = new List<int>();

        public OproshinieData(opros s)
        {
            InitializeComponent();
            res = s;
        }

        private void OproshinieData_Load(object sender, EventArgs e)
        {
            label1.Text = "Всего опрошенных: " + res.testers.Count.ToString();
            numericUpDown1.Maximum = res.testers.Count;
            foreach (var x in res.anketa)
            {
                listBox1.Items.Add(x);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = (int)numericUpDown1.Value - 1;

            if (x >= 0 && x < res.testers.Count)
            {
                testerView tv = new testerView(res.testers[x], res.selectedOprosnik.elements);
                tv.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неверный номер");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (newSearch)
            {
                finded.Clear();

                Temp = 0;
                Count = 0;

                if (listBox1.SelectedItem != null && textBox1.Text != "")
                {
                    int ank = listBox1.SelectedIndex;
                    for (int i = 0; i < res.testers.Count; i++)
                    {
                        if (res.testers[i].anketa[ank].Contains(textBox1.Text))
                        {
                            finded.Add(i);
                            Count++;
                        }
                    }
                }

                if (Count > 0)
                {
                    newSearch = false;
                }
            }

            if(!newSearch)
            {
                try
                {
                    testerView tv = new testerView(res.testers[finded[Temp]], res.selectedOprosnik.elements);
                    tv.ShowDialog();
                    seeTempCount();
                    Temp++;
                    if (Temp >= Count) Temp = 0;
                   
                }
                catch
                {

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        void seeTempCount()
        {
            label6.Text = "Был показан " + (Temp+1).ToString() + " из " + Count.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        void update()
        {
            Temp = 0;
            Count = 0;
            newSearch = true;
            label6.Text = "";
        }
    }
}
