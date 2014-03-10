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

            }
        }

        private void openFileDialog2continue_FileOk(object sender, CancelEventArgs e)
        {
            okFileOprosOpen = true;
        }
    }
}
