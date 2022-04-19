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
    public partial class ucPatientBill : UserControl
    {
        BillRepo bRepo = new BillRepo();
        PatientRepo pRepo = new PatientRepo();
        public ucPatientBill()
        {
            InitializeComponent();
            clbTests.Items.AddRange(bRepo.getTests());
            clbServices.Items.AddRange(bRepo.getServices());
            panel2.AutoScroll=true;
            cmbPatientId.DataSource = pRepo.getActivePatientIds();
           
        }
        private static ucPatientBill _Instance;

        public static ucPatientBill instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ucPatientBill();
                return _Instance;
            }
        }

        private void cmbPatientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtInvoice.Text = "";
            txtInvoice.AppendText("--------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine);
            txtInvoice.AppendText("Invoice" + Environment.NewLine);
            txtInvoice.AppendText(DateTime.Now+"       "+cmbPatientId.Text + Environment.NewLine);
            txtInvoice.AppendText("--------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine);
        }
        void Refresh()
        {
            txtInvoice.Text = "";
            txtInvoice.AppendText("--------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine);
            txtInvoice.AppendText("Invoice" + Environment.NewLine);
            txtInvoice.AppendText(DateTime.Now + "       " + cmbPatientId.Text + Environment.NewLine);
            txtInvoice.AppendText("--------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine);
            grandTotal = 0;
            txtAmount.Text = "";
            btnConfirm.Visible = false;
            btnAdd.Visible = true;
        }
        int grandTotal;
        private void btnAdd_Click(object sender, EventArgs e)
        { 
            if(txtAmount.Text!="")
            {
                Refresh();
            }
            int count = 0;
           
            string selectedServices = "";
            for (int i = 0; i < clbServices.Items.Count; i++)
            {
                int amount;
                if (clbServices.GetItemChecked(i))
                {
                    amount= int.Parse(clbServices.Items[i].ToString().Split('.').Last()); ///gets the amount
                    selectedServices = ++count+"."+ clbServices.Items[i].ToString();
                    grandTotal += amount;
                    txtInvoice.AppendText(selectedServices + Environment.NewLine);
                } 
                grandTotal += 0;
            }
            string selectedTests = "";
            for (int i = 0; i < clbTests.Items.Count; i++)
            {
                int amount;
                if (clbTests.GetItemChecked(i))
                {
                    amount = int.Parse(clbTests.Items[i].ToString().Split('.').Last());
                    selectedTests= ++count + clbTests.Items[i].ToString();
                    grandTotal += amount;
                    txtInvoice.AppendText(selectedTests + Environment.NewLine);
                }
                    
            }
            txtAmount.Text = grandTotal.ToString();
            btnConfirm.Visible = true;
            btnAdd.Visible = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm and Discharge?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string pid = cmbPatientId.Text.ToString().Substring(0, 6);
                string date = DateTime.Now.ToString("dd-MMM-yyyy");
                string result=pRepo.patient_Discharge(pid,grandTotal,txtInvoice.Text,date);
                MessageBox.Show(result);
                if(result.Contains("Discharged"))
                {
                    cmbPatientId.DataSource = pRepo.getActivePatientIds();
                }
                Refresh();
            }
            else
            {
                
            }
           
        }

    }
}
