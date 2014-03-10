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

                saveFileDialog1.ShowDialog();

                //if (okFileOprosSave)
                //{
                //    opros x = new opros(
                //}
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            okFileOprosSave = true;
        }
    }
}
