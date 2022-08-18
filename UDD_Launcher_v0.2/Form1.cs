using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDD_Launcher_v0._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            creatingBox();
            Launch();
            exitLauncher();
        }

        public void Launch()
        {
            //Process externalProcess = new Process();
            //externalProcess.StartInfo.FileName = Application.StartupPath + @"\Game\Uzak_Diyar_Destanlari_2.exe";
            //externalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            //externalProcess.Start();
        }

        //PROGRESS BAR!
        //Loading yazısı düzenlenecek!

        public async void exitLauncher()
        {
            await Task.Delay(90000);
            Application.Exit();
            //Process[] processes = Process.GetProcesses();
            //foreach (var item in processes)
            //{
            //    if (item.MainWindowTitle == "Uzak Diyar Destanları 2: Kutsal Dönüş")
            //    {
            //        Console.WriteLine(item.MainWindowTitle);
            //        Application.Exit();
            //    }
            //}
        }

        public async void creatingBox()
        {
            while(true)
            {
                loadingBox.Visible = true;
                loadingBox1.Visible = false;
                loadingBox2.Visible = false;
                loadingBox3.Visible = false;
                await Task.Delay(500);
                loadingBox.Visible = false;
                loadingBox1.Visible = true;
                await Task.Delay(500);
                loadingBox1.Visible = false;
                loadingBox2.Visible = true;
                await Task.Delay(500);
                loadingBox2.Visible = false;
                loadingBox3.Visible = true;
                await Task.Delay(500);
                loadingBox3.Visible = false;
                loadingBox.Visible = true;

            }
        }
    }
}
