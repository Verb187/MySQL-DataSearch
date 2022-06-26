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
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
            bunifuFormDock2.SubscribeControlToDragEvents(pnlHeader);
            bunifuFormDock2.SubscribeControlToDragEvents(lblTitle);
            
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
