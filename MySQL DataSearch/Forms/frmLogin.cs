using MySQL_DataSearch.DataAccess;
using SqlKata;
using SqlKata.Execution;
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

            var user = DataAccess.DBcontext.Db()
            .Query("users")
            .Where("email", txtEmail.Text)
            .Where("password", txtpass1.Text)
            .FirstOrDefault<Event.User>();
                
            if (user == null)
            {
                MessageBox.Show("Invalid login details");
            }
            else
            {
                var form = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
                if (form == null)
                {
                    form = new frmMain();
                }
                var Form2 = new frmMain();
                this.Visible = false;
                Form2.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

                this.Hide();
        }
    }
}
