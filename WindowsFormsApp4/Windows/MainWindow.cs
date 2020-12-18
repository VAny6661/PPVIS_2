using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Windows;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Widget widget1;
        public Form1()
        {
          
            InitializeComponent();
        }

        public void Run()
        {
        }
        public void InjectJudge(Widget widget )
        {

        }
        public void injectManager(Widget widget )
        {
        }
        public void injectViewer(Widget widget)
        {
        }
        public void onExit()
        {
            Environment.Exit(0);
        }
        public void onJudge() {
            JudgeWidget widget = new JudgeWidget();
            InjectJudge(widget);
            this.Hide();
            widget.ShowDialog();
            this.Show();
        }
        public void onViewer() {
            Viewer_window widget = new Viewer_window();
            injectViewer(widget1);
            this.Hide();
            widget.ShowDialog();
            this.Show();
        }
        public void onManager() {
            Manager_window widget = new Manager_window();
            injectManager(widget1);
            this.Hide();
            widget.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            onJudge();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            onManager();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            onViewer();
        }
    }
}
