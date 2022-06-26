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
using System.Windows.Forms;

namespace MySQL_DataSearch.Forms
{
    public partial class frmMain : Form
    {
        private string filter = string.Empty;

        public frmMain()
        {
            InitializeComponent();

            //make header draggable
            bunifuFormDock1.SubscribeControlToDragEvents(pnlHeader);
            bunifuFormDock1.SubscribeControlToDragEvents(lblTitle);

         

        }



        void LoadData()
        {
            //clear the rows
            grid.Rows.Clear();

            //check for search
            var db = DataAccess.DBcontext.Db();
            Query q = db.Query("immoinformation");

            lblSummary.Text = "Trouvés: " + q.Get().Count();

            if (txtSearch.Text.Trim().Length > 0)
            {
                q = q.WhereContains("Nom", txtSearch.Text.Trim())
                     .OrWhereContains("Prenom", txtSearch.Text.Trim())
                     .OrWhereContains("Signalement", txtSearch.Text.Trim());
            }

            //check for filter
            bool active = true;
            if (bool.TryParse(this.filter,out active))
            {
                q = q.Where("Actif", active);
            }

            //load all employees in database

            IEnumerable<Employee> result = q.Get<Employee>();
            lblFiltred.Text = "Filtrés: " + q.Get().Count();
            foreach (var immoinformation in result)
            {
                grid.Rows.Add(new object[]{
                      imageList1.Images[0],
                      immoinformation.Id,
                      immoinformation.Nom,
                      immoinformation.Prenom,
                      immoinformation.Adresse,
                      immoinformation.Email,
                      immoinformation.Message,
                      immoinformation.Signalement,
                      immoinformation.Fichier
                    });
            }


        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {

            try
            {
                grid.FirstDisplayedScrollingRowIndex = grid.Rows[e.Value].Index;
            }
            catch (Exception)
            {

            }
        }

        private void grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                bunifuVScrollBar1.Maximum = grid.RowCount - 1;
            }
            catch (Exception)
            {

            }
        }

        private void grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                bunifuVScrollBar1.Maximum = grid.RowCount - 1;
            }
            catch (Exception)
            {

            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {

        }

        private void init_Tick(object sender, EventArgs e)
        {
            init.Stop();
            //load data
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            this.filter = "";
            LoadData();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            this.filter = "true";
            LoadData();
        }

        private void btnOnLeave_Click(object sender, EventArgs e)
        {
            this.filter = "false";
            LoadData();
        }

        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmInfo f2 = new frmInfo();
            f2.textBox1.Text = this.grid.CurrentRow.Cells[1].Value.ToString();
            f2.textBox2.Text = this.grid.CurrentRow.Cells[2].Value.ToString();
            f2.textBox3.Text = this.grid.CurrentRow.Cells[3].Value.ToString();
            f2.textBox4.Text = this.grid.CurrentRow.Cells[4].Value.ToString();
            f2.textBox5.Text = this.grid.CurrentRow.Cells[5].Value.ToString();
            f2.textBox6.Text = this.grid.CurrentRow.Cells[6].Value.ToString();
            f2.textBox7.Text = this.grid.CurrentRow.Cells[7].Value.ToString();
            f2.textBox8.Text = this.grid.CurrentRow.Cells[8].Value.ToString();
            f2.ShowDialog();

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
