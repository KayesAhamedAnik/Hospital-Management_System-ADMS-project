using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectDemo.Repo;

namespace ProjectDemo.Gui
{
    
    public partial class ucUsers : UserControl
    {
        private UserRepo Urepo { get; set; }
        public ucUsers()
        {
            InitializeComponent();
            this.Urepo = new UserRepo();
            PopulateGridView();
        }
        private static ucUsers _Instance;

        public static ucUsers instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ucUsers();
                return _Instance;
            }
        }
        private void PopulateGridView()
        {
            this.dgvUsers2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers2.MultiSelect = false;

            this.dgvUsers2.AutoGenerateColumns = false;
            this.dgvUsers2.DataSource = Urepo.GetAllUser().ToList();
             //dgvUsers2.AutoGenerateColumns = true;
            this.dgvUsers2.ClearSelection();
            this.dgvUsers2.Refresh();
           

        }

        private void dgvUsers2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if(dgvUsers2.Rows[e.RowIndex].Cells[2].Value.ToString()=="Enabled")
                {
                    string id=dgvUsers2.Rows[e.RowIndex].Cells["userid"].Value.ToString();
                    string role=dgvUsers2.Rows[e.RowIndex].Cells["role"].Value.ToString();
                    string pass = dgvUsers2.Rows[e.RowIndex].Cells["password"].Value.ToString();
                    Urepo.User_CRUD(id, pass, role, 0, "update");
                    PopulateGridView();
                }
                else if (dgvUsers2.Rows[e.RowIndex].Cells[2].Value.ToString() == "Disabled")
                {
                    string id = dgvUsers2.Rows[e.RowIndex].Cells["userid"].Value.ToString();
                    string role = dgvUsers2.Rows[e.RowIndex].Cells["role"].Value.ToString();
                    string pass = dgvUsers2.Rows[e.RowIndex].Cells["password"].Value.ToString();
                    Urepo.User_CRUD(id,pass,role,1,"update");
                    PopulateGridView();
                }
            }
        }

        private void ucUsers_Load(object sender, EventArgs e)
        {
            PopulateGridView();   
        }

        private void dgvUsers2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach(DataGridViewRow rows in dgvUsers2.Rows)
            {
                if(rows.Cells[2].Value.ToString()=="Enabled")
                {
                    rows.DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }

        //private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //   if(this.dgvUsers2.SelectedRows.Count==1)
        //    {
        //        string id = this.dgvUsers2.CurrentRow.Cells["userid"].Value.ToString();
        //        string role = this.dgvUsers2.CurrentRow.Cells["role"].Value.ToString();
        //        string status = this.dgvUsers2.CurrentRow.Cells["status"].Value.ToString();
        //        AddNewUsers anu = new AddNewUsers(id,role,status);
        //        //this.anu.Show();

        //    }
        //}

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvUsers2.SelectedRows.Count == 1)
            {


                if (dgvUsers2.CurrentRow.Cells["status"].Value.ToString() == "Enabled")
                {
                    string id = this.dgvUsers2.CurrentRow.Cells["userid"].Value.ToString();
                    string role = this.dgvUsers2.CurrentRow.Cells["role"].Value.ToString();
                    string status = this.dgvUsers2.CurrentRow.Cells["status"].Value.ToString();
                    Random rnd = new Random();
                    string pass = rnd.Next(100000, 999999).ToString();
                    
                   bool result= Urepo.User_CRUD(id, pass, role, 1, "update");
                    if (result)
                    {
                        MessageBox.Show("Updated Password: " + pass + "  For User: " + id);
                        PopulateGridView();
                    }
                    else
                    {
                        MessageBox.Show("Plese select a Row First");
                        PopulateGridView();
                    }


                }
                else if (dgvUsers2.CurrentRow.Cells["status"].Value.ToString() == "Disabled")
                {
                    string id = this.dgvUsers2.CurrentRow.Cells["userid"].Value.ToString();
                    string role = this.dgvUsers2.CurrentRow.Cells["role"].Value.ToString();
                    string status = this.dgvUsers2.CurrentRow.Cells["status"].Value.ToString();
                    Random rnd = new Random();
                    string pass = rnd.Next(100000, 999999).ToString();
                    bool result = Urepo.User_CRUD(id, pass, role, 0, "update");
                    if (result)
                    {
                        MessageBox.Show("Updated Password: " + pass + "  For User: " + id);
                        PopulateGridView();
                    }
                    else
                    {
                        MessageBox.Show("Plese select a Row First");
                        PopulateGridView();
                    }

                }
                else
                {
                    MessageBox.Show("Plese select a Row First");
                    PopulateGridView();
                }

            }
            else
            {
                MessageBox.Show("Plese select a Row First");
                PopulateGridView();
            }
        }
    }
}
