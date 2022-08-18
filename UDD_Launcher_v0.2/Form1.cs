using System;
using System.Diagnostics;
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
            exitControl();
            Launch();
            exitLauncher();
        }

        public void Launch()
        {
            Process externalProcess = new Process();
            externalProcess.StartInfo.FileName = Application.StartupPath + @"\Game\Uzak_Diyar_Destanlari_2.exe";
            externalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            externalProcess.Start();
        }

        public async void exitLauncher()
        {
            await Task.Delay(90000);
            Application.Exit();
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

        public async void exitControl()
        {
            await Task.Delay(30000);
            btnExit.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
