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
    public partial class Viewer_window : Form,  Widget
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
    protected void onBookmaker() { }
    protected void OnShop() { }
    protected void back() { }
    protected void OnMatchInfo() { }

    protected void OnDoneBookie() { }
    protected void OnDoneBuy() { }
    protected void OnBuy() { }
    protected void OnMakeBet() { }
    protected void OnCheckBet() { }
    public Viewer_window()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Bookmaker_window bm = new Bookmaker_window();
            this.Hide();
            bm.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            merch_shop_window msw = new merch_shop_window();
            this.Hide();
            msw.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            backToMain();
        }
    }
}
