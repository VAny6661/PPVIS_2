using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Manager_window : Form
    {
        public void backToMain()
        {
            this.Close();
        }
        public void checkEvents()
        {
            return;
        }
        public void update()
        {
            return;
        }
        protected void OnTeam() { }
        protected void OnTransfer() { }
        protected void back() { backToMain(); }
        protected void OnTeamDone() { }

        protected void onTransferDone() { }
        protected void OnSwap() { }
        protected void OnSell() { }
        protected void OnMatch() { }
        protected void OnBuy() { }

        public Manager_window()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manager_transfer_window mtw = new manager_transfer_window();
            this.Hide();
            mtw.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            back();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manager_team_window mtw = new Manager_team_window();
            this.Hide();
            mtw.ShowDialog();
            this.Show();
        }
    }
}
