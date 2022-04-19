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
using ProjectDemo.Entity;

namespace ProjectDemo.Gui
{
    public partial class ucFinancials : UserControl
    {
        BillRepo bRepo = new BillRepo();
        public ucFinancials()
        {
            InitializeComponent();
            PopulateGridView();
        }
        private static ucFinancials _Instance;

        public static ucFinancials instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ucFinancials();
                return _Instance;
            }
        }
        private void PopulateGridView()
        {
            dgvFinancials.RowTemplate.Height = 120;
            this.dgvFinancials.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinancials.MultiSelect = false;
           // dgvEmployee.Dock = DockStyle.Fill;
           dgvFinancials.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFinancials.AutoGenerateColumns = false;
            this.dgvFinancials.DataSource = bRepo.GetAllBills();
            this.dgvFinancials.ClearSelection();
            this.dgvFinancials.Refresh();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGridView();
        }
    }
}
