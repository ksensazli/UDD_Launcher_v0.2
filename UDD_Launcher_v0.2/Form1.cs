using System;
using System.Diagnostics;
using System.Drawing;
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
            creatingBox();              //It is the method to show and hide the loadingBoxes according to the duration.
            createProgressBar();        //It is the method where the progressBar's value and the time it will be completed actively are set.
            exitControl();              //It is the method that controls the exitButton that will appear after a certain time.
            Launch();                   //It is the method that starts the Uzak Diyar Destanları 2:Launcher
            exitLauncher();             //It is the method to close the Launcher Application according to the duration.
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

        public void createProgressBar()
        {
            progressBar1.ForeColor = Color.Red;
            progressBar1.Value = 0;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
            }
        }

        public async void exitControl()
        {
            await Task.Delay(30000);
            btnExit.Visible = true;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnExit.BackColor = Color.Transparent;
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
            await Task.Delay(120000);
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
