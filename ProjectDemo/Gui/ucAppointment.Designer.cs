
namespace ProjectDemo.Gui
{
    partial class ucAppointment
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelAddnewEmp = new System.Windows.Forms.Panel();
            this.panelDocInfo = new System.Windows.Forms.Panel();
            this.dgvDoctor = new System.Windows.Forms.DataGridView();
            this.doctorid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.cmbDoctorName = new System.Windows.Forms.ComboBox();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.panelHeader.SuspendLayout();
            this.panelAddnewEmp.SuspendLayout();
            this.panelDocInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctors Appointment";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1169, 46);
            this.panelHeader.TabIndex = 4;
            // 
            // panelAddnewEmp
            // 
            this.panelAddnewEmp.Controls.Add(this.panelDocInfo);
            this.panelAddnewEmp.Controls.Add(this.dtpAppointmentDate);
            this.panelAddnewEmp.Controls.Add(this.cmbDoctorName);
            this.panelAddnewEmp.Controls.Add(this.lblDoctorName);
            this.panelAddnewEmp.Controls.Add(this.txtPatientName);
            this.panelAddnewEmp.Controls.Add(this.cmbDept);
            this.panelAddnewEmp.Controls.Add(this.btnRefresh);
            this.panelAddnewEmp.Controls.Add(this.label2);
            this.panelAddnewEmp.Controls.Add(this.btnRegister);
            this.panelAddnewEmp.Controls.Add(this.lblDoctor);
            this.panelAddnewEmp.Controls.Add(this.lblName);
            this.panelAddnewEmp.Location = new System.Drawing.Point(0, 143);
            this.panelAddnewEmp.Name = "panelAddnewEmp";
            this.panelAddnewEmp.Size = new System.Drawing.Size(1169, 501);
            this.panelAddnewEmp.TabIndex = 5;
            // 
            // panelDocInfo
            // 
            this.panelDocInfo.Controls.Add(this.dgvDoctor);
            this.panelDocInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDocInfo.Location = new System.Drawing.Point(436, 0);
            this.panelDocInfo.Name = "panelDocInfo";
            this.panelDocInfo.Size = new System.Drawing.Size(733, 501);
            this.panelDocInfo.TabIndex = 99;
            // 
            // dgvDoctor
            // 
            this.dgvDoctor.AllowUserToAddRows = false;
            this.dgvDoctor.AllowUserToDeleteRows = false;
            this.dgvDoctor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorid,
            this.ename,
            this.schedule,
            this.dept,
            this.details});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoctor.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoctor.Location = new System.Drawing.Point(0, 0);
            this.dgvDoctor.Name = "dgvDoctor";
            this.dgvDoctor.ReadOnly = true;
            this.dgvDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctor.Size = new System.Drawing.Size(733, 501);
            this.dgvDoctor.TabIndex = 0;
            // 
            // doctorid
            // 
            this.doctorid.DataPropertyName = "doctorid";
            this.doctorid.HeaderText = "Doctor Id";
            this.doctorid.Name = "doctorid";
            this.doctorid.ReadOnly = true;
            // 
            // ename
            // 
            this.ename.DataPropertyName = "ename";
            this.ename.HeaderText = "Name";
            this.ename.Name = "ename";
            this.ename.ReadOnly = true;
            // 
            // schedule
            // 
            this.schedule.DataPropertyName = "schedule";
            this.schedule.HeaderText = "Schedule";
            this.schedule.Name = "schedule";
            this.schedule.ReadOnly = true;
            // 
            // dept
            // 
            this.dept.DataPropertyName = "dept";
            this.dept.HeaderText = "Department";
            this.dept.Name = "dept";
            this.dept.ReadOnly = true;
            // 
            // details
            // 
            this.details.DataPropertyName = "details";
            this.details.HeaderText = "Specialities";
            this.details.Name = "details";
            this.details.ReadOnly = true;
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppointmentDate.Location = new System.Drawing.Point(184, 144);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(155, 27);
            this.dtpAppointmentDate.TabIndex = 98;
            // 
            // cmbDoctorName
            // 
            this.cmbDoctorName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoctorName.FormattingEnabled = true;
            this.cmbDoctorName.Location = new System.Drawing.Point(181, 101);
            this.cmbDoctorName.Name = "cmbDoctorName";
            this.cmbDoctorName.Size = new System.Drawing.Size(158, 27);
            this.cmbDoctorName.TabIndex = 97;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.Location = new System.Drawing.Point(48, 104);
            this.lblDoctorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(60, 19);
            this.lblDoctorName.TabIndex = 96;
            this.lblDoctorName.Text = "Doctor :";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(181, 14);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(158, 27);
            this.txtPatientName.TabIndex = 95;
            // 
            // cmbDept
            // 
            this.cmbDept.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Items.AddRange(new object[] {
            "Cardiology",
            "Dermatology",
            "Gynochology",
            "Medicine",
            "Nurology",
            "Pathology",
            "Pediatrician",
            "Psychology",
            "Radiology",
            "Surgeon"});
            this.cmbDept.Location = new System.Drawing.Point(181, 61);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(158, 27);
            this.cmbDept.TabIndex = 93;
            this.cmbDept.SelectedIndexChanged += new System.EventHandler(this.cmdDept_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(188, 271);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(154, 38);
            this.btnRefresh.TabIndex = 92;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 65;
            this.label2.Text = "Appointment Date:";
            // 
            // btnRegister
            // 
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnRegister.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(184, 208);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(158, 38);
            this.btnRegister.TabIndex = 59;
            this.btnRegister.Text = "Confirm Appointment";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.Location = new System.Drawing.Point(48, 64);
            this.lblDoctor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(90, 19);
            this.lblDoctor.TabIndex = 57;
            this.lblDoctor.Text = "Department:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(48, 17);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 19);
            this.lblName.TabIndex = 53;
            this.lblName.Text = "Patient Name :";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // ucAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelAddnewEmp);
            this.Name = "ucAppointment";
            this.Size = new System.Drawing.Size(1169, 644);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelAddnewEmp.ResumeLayout(false);
            this.panelAddnewEmp.PerformLayout();
            this.panelDocInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelAddnewEmp;
        private System.Windows.Forms.Panel panelDocInfo;
        private System.Windows.Forms.DataGridView dgvDoctor;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.ComboBox cmbDoctorName;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ename;
        private System.Windows.Forms.DataGridViewTextBoxColumn schedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}
