using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class SplashView : Form
    {
        public SplashView()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 2;
            if (progressBar.Value >= 100)
            {
                timer.Stop();
                this.Hide();
                var login = new LoginView();
                login.Show();
                this.Close();
            }
        }
    }
}
