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
    public partial class FormMainMenu : Form
    {
        bool okFileOprosnikOpen;
        bool okFileOprosSave;
        bool okFileOprosOpen;

        public FormMainMenu()
        {
            InitializeComponent(); 
        }

        private void button1newOprosnik_Click(object sender, EventArgs e)
        {
            editOprosnik ed = new editOprosnik(new oprosnik());
            ed.ShowDialog();
            if (ed.DialogResult == DialogResult.OK) MessageBox.Show("Сохранено");
        }

        private void button7exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            okFileOprosnikOpen = false;
            openFileDialog1.ShowDialog();
            if (okFileOprosnikOpen)
            {
                oprosnik temp = new oprosnik();
                temp.Load(openFileDialog1.FileName);
                editOprosnik ed = new editOprosnik(temp);
                ed.ShowDialog();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            okFileOprosnikOpen = true;
        }

        private void button2newOpros_Click(object sender, EventArgs e)
        {
            okFileOprosnikOpen = false;
            okFileOprosSave = false;

            openFileDialog1.ShowDialog();
            if (okFileOprosnikOpen)
            {
                oprosnik temp = new oprosnik();
                temp.Load(openFileDialog1.FileName);

                //создание опроса
                editOprosMini em = new editOprosMini(temp);
                em.ShowDialog();
                if (em.DialogResult == DialogResult.OK)
                {
                    anketa ank = new anketa(em.result);
                    if (em.result.IsAnonimus == false)
                    {
                        ank.ShowDialog();
                        if (ank.DialogResult != DialogResult.OK) return;
                    }

                    saveFileDialog1.ShowDialog();
                    if (okFileOprosSave)
                    {
                        ank.res.save(saveFileDialog1.FileName);
                        MessageBox.Show("Сохранено");
                    }
                }
                else return;
                //создали. сохреняем.
            }

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            okFileOprosSave = true;
        }

        private void button3continue_Click(object sender, EventArgs e)
        {
            okFileOprosOpen = false;
            openFileDialog2continue.ShowDialog();
            if (okFileOprosOpen)
            {
                opros res=new opros();
                FormBeginOpros fb = new FormBeginOpros(openFileDialog2continue.FileName, res);
                fb.ShowDialog();
                if (fb.DialogResult != DialogResult.OK) return;

                res.testers.Insert(0, new tester()); //0ой тестер
                if (res.IsAnonimus == false)
                {
                    anketaFill af = new anketaFill(res);
                    af.ShowDialog();
                    if (af.DialogResult != DialogResult.OK) return;
                }

                mainOpros mo = new mainOpros(res);
                mo.ShowDialog();

                if (mo.DialogResult != DialogResult.OK) return;
                res.save(openFileDialog2continue.FileName);
                MessageBox.Show("Опрос пройден. Результаты сохранены.");
            }
        }

        private void openFileDialog2continue_FileOk(object sender, CancelEventArgs e)
        {
            okFileOprosOpen = true;
        }

        private void button4load_Click(object sender, EventArgs e)
        {
            string t = openFileDialog2continue.Title;

            okFileOprosOpen = false;
            openFileDialog2continue.Title = "Выберите исходный опрос";
            openFileDialog2continue.ShowDialog();
            if (!okFileOprosOpen) return;

            string source = openFileDialog2continue.FileName;

            okFileOprosOpen = false;
            openFileDialog2continue.Title = "Выберите догружаемый опрос";
            openFileDialog2continue.ShowDialog();
            if (!okFileOprosOpen) return;

            string add = openFileDialog2continue.FileName;

            opros res = new opros();
            if (!res.load(source)) { MessageBox.Show("Выбраный файл не является опросом"); };
            if (!res.connectOpr(add))
            {
                MessageBox.Show("У опросников должны быть одинаковые анкеты"+Environment.NewLine+"Кроме того, они должны быть основаны на одном и том же опроснике");
                return;
            }

            openFileDialog2continue.Title = t;

            okFileOprosSave = false;
            saveFileDialog1.ShowDialog();
            if (!okFileOprosSave) return;
            res.save(saveFileDialog1.FileName);

            MessageBox.Show("Результат сохранён");
        }

        private void button5results_Click(object sender, EventArgs e)
        {
            okFileOprosOpen = false;
            openFileDialog2continue.ShowDialog();
            if (!okFileOprosOpen) return;

            resultsForm rF = new resultsForm(openFileDialog2continue.FileName);
            rF.ShowDialog();
        }
    }
}
