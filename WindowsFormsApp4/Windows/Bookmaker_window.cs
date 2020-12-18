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
    public partial class Bookmaker_window : Form, BookMaker
    {
        MatchInfo MI;
        Bet bet;
        public Bookmaker_window()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            makeBet("1", float.Parse(textBox1.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string[] getMatchInfo()
        {
            MI = new MatchInfo();
            string[] info = { MI.firstTeam, MI.secondTeam, MI.firstCof.ToString(), MI.secondCof.ToString() };
            return info;
        }
        public void makeBet(string name, float sum)
        {
            bet = new Bet();
            bet.winner = name;
            bet.money = sum;
            bet.coff = MI.firstCof;
        }
        public float checkBet(string name)
        {
            return bet.money;
        }
        public float createCofficient()
        {
            Random rand = new Random();
            float coff = rand.Next(0, 10);
            return coff;
        }
    }
}
