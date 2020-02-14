using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Forms
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();            
        }

        private void loading_Tick(object sender, EventArgs e)
        {
            if (loadingBar.Value < loadingBar.Maximum)
            {
                loadingBar.Value++;
                Opacity++;
            }
            else
            {
                this.Hide();
                new frmLogin().Show();
                
                loading.Enabled = false;
            }



        }
    }
}
