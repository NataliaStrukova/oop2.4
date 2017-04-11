using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace oop2._4
{
    public partial class FormStore : Form
    {
        Store store;
        public FormStore()
        {
            InitializeComponent();
            timer1.Interval = 100;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            store = new Store((int)numericUpDownCountCash.Value, pictureBoxStore.Width, pictureBoxStore.Height);
            new Thread(() => store.Run()).Start();
            timer1.Start();
            pictureBoxStore.Invalidate();
        }

        private void pictureBoxStore_Paint(object sender, PaintEventArgs e)
        {
            if (store != null)
                store.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBoxStore.Invalidate();
        }


        private void buttonStop_Click(object sender, EventArgs e)
        {
            store.Stop();
            timer1.Stop();
        }

        private void FormStore_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

    }
}
