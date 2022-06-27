using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_DataSearch.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(pnlHeader);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
            if (form == null)
            {
                form = new frmMain();
            }
            form.Show();
            frmLogin fLogin = new frmLogin();
            fLogin.Hide();
        }
    }
}
