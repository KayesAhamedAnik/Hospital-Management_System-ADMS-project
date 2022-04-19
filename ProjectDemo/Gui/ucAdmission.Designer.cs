
namespace ProjectDemo.Gui
{
    partial class ucAdmission
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNewAdmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvAdmissions = new System.Windows.Forms.DataGridView();
            this.admissionid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wardno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissiondate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dischargedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assigneddoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmissions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnAddNewAdmit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 72);
            this.panel1.TabIndex = 2;
            // 
            // btnAddNewAdmit
            // 
            this.btnAddNewAdmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewAdmit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddNewAdmit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnAddNewAdmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewAdmit.Location = new System.Drawing.Point(862, 25);
            this.btnAddNewAdmit.Name = "btnAddNewAdmit";
            this.btnAddNewAdmit.Size = new System.Drawing.Size(163, 28);
            this.btnAddNewAdmit.TabIndex = 2;
            this.btnAddNewAdmit.Text = "New Admission";
            this.btnAddNewAdmit.UseVisualStyleBackColor = true;
            this.btnAddNewAdmit.Click += new System.EventHandler(this.btnAddNewAdmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admitted Patients";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(1031, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 28);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvAdmissions
            // 
            this.dgvAdmissions.AllowUserToAddRows = false;
            this.dgvAdmissions.AllowUserToDeleteRows = false;
            this.dgvAdmissions.AllowUserToResizeColumns = false;
            this.dgvAdmissions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAdmissions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdmissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmissions.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdmissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.admissionid,
            this.patientid,
            this.wardno,
            this.status,
            this.admissiondate,
            this.dischargedate,
            this.assigneddoctor,
            this.billid});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdmissions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdmissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdmissions.Location = new System.Drawing.Point(0, 72);
            this.dgvAdmissions.Name = "dgvAdmissions";
            this.dgvAdmissions.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmissions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAdmissions.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAdmissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmissions.Size = new System.Drawing.Size(1133, 592);
            this.dgvAdmissions.TabIndex = 3;
            // 
            // admissionid
            // 
            this.admissionid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.admissionid.DataPropertyName = "admissionid";
            this.admissionid.FillWeight = 78.23605F;
            this.admissionid.HeaderText = "Admission Id";
            this.admissionid.Name = "admissionid";
            this.admissionid.ReadOnly = true;
            this.admissionid.Width = 112;
            // 
            // patientid
            // 
            this.patientid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.patientid.DataPropertyName = "patientid";
            this.patientid.HeaderText = "Patient Id";
            this.patientid.Name = "patientid";
            this.patientid.ReadOnly = true;
            this.patientid.Width = 90;
            // 
            // wardno
            // 
            this.wardno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wardno.DataPropertyName = "wardno";
            this.wardno.FillWeight = 78.23605F;
            this.wardno.HeaderText = "Ward No";
            this.wardno.Name = "wardno";
            this.wardno.ReadOnly = true;
            this.wardno.Width = 87;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // admissiondate
            // 
            this.admissiondate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.admissiondate.DataPropertyName = "admissiondate";
            this.admissiondate.HeaderText = "Admission Date";
            this.admissiondate.Name = "admissiondate";
            this.admissiondate.ReadOnly = true;
            this.admissiondate.Width = 130;
            // 
            // dischargedate
            // 
            this.dischargedate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dischargedate.DataPropertyName = "dischargedate";
            this.dischargedate.HeaderText = "Discharge Date";
            this.dischargedate.Name = "dischargedate";
            this.dischargedate.ReadOnly = true;
            this.dischargedate.Width = 129;
            // 
            // assigneddoctor
            // 
            this.assigneddoctor.DataPropertyName = "assigneddoctor";
            this.assigneddoctor.HeaderText = "Assigned Doctor";
            this.assigneddoctor.Name = "assigneddoctor";
            this.assigneddoctor.ReadOnly = true;
            // 
            // billid
            // 
            this.billid.DataPropertyName = "billid";
            this.billid.HeaderText = "Bill Id";
            this.billid.Name = "billid";
            this.billid.ReadOnly = true;
            // 
            // ucAdmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dgvAdmissions);
            this.Controls.Add(this.panel1);
            this.Name = "ucAdmission";
            this.Size = new System.Drawing.Size(1133, 664);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmissions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddNewAdmit;
        private System.Windows.Forms.DataGridView dgvAdmissions;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionid;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientid;
        private System.Windows.Forms.DataGridViewTextBoxColumn wardno;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissiondate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dischargedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn assigneddoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn billid;
    }
}
