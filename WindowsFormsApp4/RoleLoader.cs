using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Windows;

namespace WindowsFormsApp4
{
    static class RoleLoader
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Judge j = new Judge();
            MatchAction ma = new MatchAction();
            Bookie b = new Bookie();
            Viewer v = new Viewer();
            Manager m = new Manager();
            Player p = new Player();



        }
            public static Widget CreateJudge()
            {
            JudgeWidget JW = new JudgeWidget();
                return JW;
            }
            public static Widget CreateManager()
            {
            ManagerWidget MW = new ManagerWidget();
                return MW;
            }
            public static Widget CreateViewer()
            {
                ViewerWidget VW = new ViewerWidget();
                return VW;
            }
        }
    }

