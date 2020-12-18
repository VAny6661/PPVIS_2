using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4.Windows
{
    public partial class JudgeWidget : Form, Widget
    {
        public JudgeWidget()
        {
            InitializeComponent();
        }

        public void backToMain()
        {
            this.Close();
        }

        public void checkEvents()
        {
           
        }

        public void update()
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            backToMain();
        }
        protected void onMatchDone() { }
        protected void OnStartMatch() {
            Judge_during_match_window jw = new Judge_during_match_window();
            this.Hide();
            jw.ShowDialog();
            this.Show();
        }
        protected void back() {
            this.Close();
        }
        protected void OnDone() { }

        protected void OnTimeEnd() { }
        protected void OnInjury() {
            Judge_response_window jw = new Judge_response_window();
            jw.Show();
            this.Close();
        }
        protected void OnViolation() {
            Judge_response_window jw = new Judge_response_window();
            jw.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OnStartMatch();
        }
    }
}
