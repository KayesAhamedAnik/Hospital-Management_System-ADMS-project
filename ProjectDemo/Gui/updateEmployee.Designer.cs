
namespace ProjectDemo.Gui
{
    partial class updateEmployee
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.customID = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.customNameBorder = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.CustomPhoneBorder = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.CustomEphoneBorder = new System.Windows.Forms.Panel();
            this.txtemergencyContact = new System.Windows.Forms.TextBox();
            this.customWeightBorder = new System.Windows.Forms.Panel();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.customAgeBorder = new System.Windows.Forms.Panel();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.customDesignationBorder = new System.Windows.Forms.Panel();
            this.CmbDesignation = new System.Windows.Forms.ComboBox();
            this.customBloodBorder = new System.Windows.Forms.Panel();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.customAddressBorder = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.customSalaryBorder = new System.Windows.Forms.Panel();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.customJoinningdateBorder = new System.Windows.Forms.Panel();
            this.dtpJoinningDate = new System.Windows.Forms.DateTimePicker();
            this.customMediaclHistoryBorder = new System.Windows.Forms.Panel();
            this.txtMedicalHistory = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelAddnewEmp = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.customID.SuspendLayout();
            this.customNameBorder.SuspendLayout();
            this.CustomPhoneBorder.SuspendLayout();
            this.CustomEphoneBorder.SuspendLayout();
            this.customWeightBorder.SuspendLayout();
            this.customAgeBorder.SuspendLayout();
            this.customDesignationBorder.SuspendLayout();
            this.customBloodBorder.SuspendLayout();
            this.customAddressBorder.SuspendLayout();
            this.customSalaryBorder.SuspendLayout();
            this.customJoinningdateBorder.SuspendLayout();
            this.customMediaclHistoryBorder.SuspendLayout();
            this.panelAddnewEmp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(107, 119);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 19);
            this.lblName.TabIndex = 53;
            this.lblName.Text = "Name :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(80, 153);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(79, 19);
            this.lblPhone.TabIndex = 55;
            this.lblPhone.Text = "Phone No :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(66, 314);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(93, 19);
            this.lblEmail.TabIndex = 57;
            this.lblEmail.Text = "Blood Group:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(179, 469);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 38);
            this.btnUpdate.TabIndex = 59;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(133, 86);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 19);
            this.lblId.TabIndex = 61;
            this.lblId.Text = "Id :";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(106, 380);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(56, 19);
            this.lblSalary.TabIndex = 63;
            this.lblSalary.Text = "Salary :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 346);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 65;
            this.label2.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 19);
            this.label5.TabIndex = 67;
            this.label5.Text = "Emergency Phone No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 69;
            this.label3.Text = "Designation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 72;
            this.label4.Text = "Wight :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 19);
            this.label6.TabIndex = 74;
            this.label6.Text = "Age:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(356, 318);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 19);
            this.label7.TabIndex = 76;
            this.label7.Text = "Medical History :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 409);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 19);
            this.label8.TabIndex = 77;
            this.label8.Text = "Joinning Date:";
            // 
            // customID
            // 
            this.customID.Controls.Add(this.txtId);
            this.customID.Location = new System.Drawing.Point(177, 81);
            this.customID.Name = "customID";
            this.customID.Padding = new System.Windows.Forms.Padding(1);
            this.customID.Size = new System.Drawing.Size(156, 31);
            this.customID.TabIndex = 79;
            // 
            // txtId
            // 
            this.txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(1, 1);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(154, 27);
            this.txtId.TabIndex = 60;
            // 
            // customNameBorder
            // 
            this.customNameBorder.Controls.Add(this.txtName);
            this.customNameBorder.Location = new System.Drawing.Point(176, 114);
            this.customNameBorder.Name = "customNameBorder";
            this.customNameBorder.Padding = new System.Windows.Forms.Padding(1);
            this.customNameBorder.Size = new System.Drawing.Size(156, 31);
            this.customNameBorder.TabIndex = 80;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(1, 1);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 27);
            this.txtName.TabIndex = 52;
            // 
            // CustomPhoneBorder
            // 
            this.CustomPhoneBorder.Controls.Add(this.txtPhone);
            this.CustomPhoneBorder.Location = new System.Drawing.Point(176, 148);
            this.CustomPhoneBorder.Name = "CustomPhoneBorder";
            this.CustomPhoneBorder.Padding = new System.Windows.Forms.Padding(1);
            this.CustomPhoneBorder.Size = new System.Drawing.Size(156, 31);
            this.CustomPhoneBorder.TabIndex = 81;
            // 
            // txtPhone
            // 
            this.txtPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(1, 1);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(154, 27);
            this.txtPhone.TabIndex = 54;
            // 
            // CustomEphoneBorder
            // 
            this.CustomEphoneBorder.Controls.Add(this.txtemergencyContact);
            this.CustomEphoneBorder.Location = new System.Drawing.Point(176, 182);
            this.CustomEphoneBorder.Name = "CustomEphoneBorder";
            this.CustomEphoneBorder.Padding = new System.Windows.Forms.Padding(1);
            this.CustomEphoneBorder.Size = new System.Drawing.Size(156, 31);
            this.CustomEphoneBorder.TabIndex = 82;
            // 
            // txtemergencyContact
            // 
            this.txtemergencyContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtemergencyContact.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemergencyContact.Location = new System.Drawing.Point(1, 1);
            this.txtemergencyContact.Margin = new System.Windows.Forms.Padding(2);
            this.txtemergencyContact.Name = "txtemergencyContact";
            this.txtemergencyContact.Size = new System.Drawing.Size(154, 27);
            this.txtemergencyContact.TabIndex = 66;
            // 
            // customWeightBorder
            // 
            this.customWeightBorder.Controls.Add(this.txtWeight);
            this.customWeightBorder.Location = new System.Drawing.Point(176, 216);
            this.customWeightBorder.Name = "customWeightBorder";
            this.customWeightBorder.Padding = new System.Windows.Forms.Padding(1);
            this.customWeightBorder.Size = new System.Drawing.Size(156, 31);
            this.customWeightBorder.TabIndex = 83;
            // 
            // txtWeight
            // 
            this.txtWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWeight.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(1, 1);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(154, 27);
            this.txtWeight.TabIndex = 71;
            // 
            // customAgeBorder
            // 
            this.customAgeBorder.Controls.Add(this.txtAge);
            this.customAgeBorder.Location = new System.Drawing.Point(176, 247);
            this.customAgeBorder.Name = "customAgeBorder";
            this.customAgeBorder.Padding = new System.Windows.Forms.Padding(1);
            this.customAgeBorder.Size = new System.Drawing.Size(156, 31);
            this.customAgeBorder.TabIndex = 84;
            // 
            // txtAge
            // 
            this.txtAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAge.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(1, 1);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(154, 27);
            this.txtAge.TabIndex = 73;
            // 
            // customDesignationBorder
            // 
            this.customDesignationBorder.Controls.Add(this.CmbDesignation);
            this.customDesignationBorder.Location = new System.Drawing.Point(176, 280);
            this.customDesignationBorder.Name = "customDesignationBorder";
            this.customDesignationBorder.Padding = new System.Windows.Forms.Padding(1);
            this.customDesignationBorder.Size = new System.Drawing.Size(156, 31);
            this.customDesignationBorder.TabIndex = 85;
            // 
            // CmbDesignation
            // 
            this.CmbDesignation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbDesignation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDesignation.FormattingEnabled = true;
            this.CmbDesignation.Items.AddRange(new object[] {
            "Doctor",
            "Manager",
            "Ward Boy",
            "Nurse",
            "Receiptionist"});
            this.CmbDesignation.Location = new System.Drawing.Point(1, 1);
            this.CmbDesignation.Name = "CmbDesignation";
            this.CmbDesignation.Size = new System.Drawing.Size(154, 27);
            this.CmbDesignation.TabIndex = 68;
            // 
            // customBloodBorder
            // 
            this.customBloodBorder.Controls.Add(this.cmbBloodGroup);
            this.customBloodBorder.Location = new System.Drawing.Point(176, 309);
            this.customBloodBorder.Name = "customBloodBorder";
            this.customBloodBorder.Padding = new System.Windows.Forms.Padding(1);
            this.customBloodBorder.Size = new System.Drawing.Size(156, 31);
            this.customBloodBorder.TabIndex = 86;
            // 
            // cmbBloodGroup
            // 
            this.cmbBloodGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBloodGroup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBloodGroup.FormattingEnabled = true;
            this.cmbBloodGroup.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "B-",
            "O-",
            "AB-"});
            this.cmbBloodGroup.Location = new System.Drawing.Point(1, 1);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(154, 27);
            this.cmbBloodGroup.TabIndex = 70;
            // 
            // customAddressBorder
            // 
            this.customAddressBorder.Controls.Add(this.txtAddress);
            this.customAddressBorder.Location = new System.Drawing.Point(177, 341);
            this.customAddressBorder.Name = "customAddressBorder";
            this.customAddressBorder.Padding = new System.Windows.Forms.Padding(1);
            this.customAddressBorder.Size = new System.Drawing.Size(156, 31);
            this.customAddressBorder.TabIndex = 87;
            // 
            // txtAddress
            // 
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(1, 1);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(154, 27);
            this.txtAddress.TabIndex = 64;
            // 
            // customSalaryBorder
            // 
            this.customSalaryBorder.Controls.Add(this.txtSalary);
            this.customSalaryBorder.Location = new System.Drawing.Point(177, 374);
            this.customSalaryBorder.Name = "customSalaryBorder";
            this.customSalaryBorder.Padding = new System.Windows.Forms.Padding(1);
            this.customSalaryBorder.Size = new System.Drawing.Size(156, 31);
            this.customSalaryBorder.TabIndex = 88;
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.SystemColors.Window;
            this.txtSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSalary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(1, 1);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(154, 27);
            this.txtSalary.TabIndex = 62;
            // 
            // customJoinningdateBorder
            // 
            this.customJoinningdateBorder.Controls.Add(this.dtpJoinningDate);
            this.customJoinningdateBorder.Location = new System.Drawing.Point(177, 409);
            this.customJoinningdateBorder.Name = "customJoinningdateBorder";
            this.customJoinningdateBorder.Padding = new System.Windows.Forms.Padding(1);
            this.customJoinningdateBorder.Size = new System.Drawing.Size(156, 31);
            this.customJoinningdateBorder.TabIndex = 89;
            // 
            // dtpJoinningDate
            // 
            this.dtpJoinningDate.CustomFormat = "dd/mm/yyyy";
            this.dtpJoinningDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpJoinningDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJoinningDate.Location = new System.Drawing.Point(1, 1);
            this.dtpJoinningDate.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.dtpJoinningDate.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpJoinningDate.Name = "dtpJoinningDate";
            this.dtpJoinningDate.Size = new System.Drawing.Size(154, 27);
            this.dtpJoinningDate.TabIndex = 78;
            this.dtpJoinningDate.Value = new System.DateTime(2021, 11, 24, 0, 0, 0, 0);
            // 
            // customMediaclHistoryBorder
            // 
            this.customMediaclHistoryBorder.Controls.Add(this.txtMedicalHistory);
            this.customMediaclHistoryBorder.Location = new System.Drawing.Point(358, 341);
            this.customMediaclHistoryBorder.Name = "customMediaclHistoryBorder";
            this.customMediaclHistoryBorder.Padding = new System.Windows.Forms.Padding(1);
            this.customMediaclHistoryBorder.Size = new System.Drawing.Size(166, 101);
            this.customMediaclHistoryBorder.TabIndex = 90;
            // 
            // txtMedicalHistory
            // 
            this.txtMedicalHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMedicalHistory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicalHistory.Location = new System.Drawing.Point(1, 1);
            this.txtMedicalHistory.Margin = new System.Windows.Forms.Padding(2);
            this.txtMedicalHistory.Multiline = true;
            this.txtMedicalHistory.Name = "txtMedicalHistory";
            this.txtMedicalHistory.ReadOnly = true;
            this.txtMedicalHistory.Size = new System.Drawing.Size(164, 99);
            this.txtMedicalHistory.TabIndex = 76;
            this.txtMedicalHistory.Text = "None";
            this.txtMedicalHistory.Click += new System.EventHandler(this.txtMedicalHistory_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(301, 469);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 38);
            this.btnRefresh.TabIndex = 92;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panelAddnewEmp
            // 
            this.panelAddnewEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddnewEmp.Controls.Add(this.panel1);
            this.panelAddnewEmp.Controls.Add(this.btnCancel);
            this.panelAddnewEmp.Controls.Add(this.btnRefresh);
            this.panelAddnewEmp.Controls.Add(this.customMediaclHistoryBorder);
            this.panelAddnewEmp.Controls.Add(this.customJoinningdateBorder);
            this.panelAddnewEmp.Controls.Add(this.customSalaryBorder);
            this.panelAddnewEmp.Controls.Add(this.customAddressBorder);
            this.panelAddnewEmp.Controls.Add(this.customBloodBorder);
            this.panelAddnewEmp.Controls.Add(this.customDesignationBorder);
            this.panelAddnewEmp.Controls.Add(this.customAgeBorder);
            this.panelAddnewEmp.Controls.Add(this.customWeightBorder);
            this.panelAddnewEmp.Controls.Add(this.CustomEphoneBorder);
            this.panelAddnewEmp.Controls.Add(this.CustomPhoneBorder);
            this.panelAddnewEmp.Controls.Add(this.customNameBorder);
            this.panelAddnewEmp.Controls.Add(this.customID);
            this.panelAddnewEmp.Controls.Add(this.label8);
            this.panelAddnewEmp.Controls.Add(this.label7);
            this.panelAddnewEmp.Controls.Add(this.label6);
            this.panelAddnewEmp.Controls.Add(this.label4);
            this.panelAddnewEmp.Controls.Add(this.label3);
            this.panelAddnewEmp.Controls.Add(this.label5);
            this.panelAddnewEmp.Controls.Add(this.label2);
            this.panelAddnewEmp.Controls.Add(this.lblSalary);
            this.panelAddnewEmp.Controls.Add(this.lblId);
            this.panelAddnewEmp.Controls.Add(this.btnUpdate);
            this.panelAddnewEmp.Controls.Add(this.lblEmail);
            this.panelAddnewEmp.Controls.Add(this.lblPhone);
            this.panelAddnewEmp.Controls.Add(this.lblName);
            this.panelAddnewEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddnewEmp.Location = new System.Drawing.Point(0, 0);
            this.panelAddnewEmp.Name = "panelAddnewEmp";
            this.panelAddnewEmp.Size = new System.Drawing.Size(553, 575);
            this.panelAddnewEmp.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 48);
            this.panel1.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 99;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.btnCancel_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 19);
            this.label9.TabIndex = 98;
            this.label9.Text = "Update Employee Info";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(405, 469);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 38);
            this.btnCancel.TabIndex = 93;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // updateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 575);
            this.Controls.Add(this.panelAddnewEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updateEmployee";
            this.Text = "updateEmployee";
            this.Load += new System.EventHandler(this.updateEmployee_Load);
            this.customID.ResumeLayout(false);
            this.customID.PerformLayout();
            this.customNameBorder.ResumeLayout(false);
            this.customNameBorder.PerformLayout();
            this.CustomPhoneBorder.ResumeLayout(false);
            this.CustomPhoneBorder.PerformLayout();
            this.CustomEphoneBorder.ResumeLayout(false);
            this.CustomEphoneBorder.PerformLayout();
            this.customWeightBorder.ResumeLayout(false);
            this.customWeightBorder.PerformLayout();
            this.customAgeBorder.ResumeLayout(false);
            this.customAgeBorder.PerformLayout();
            this.customDesignationBorder.ResumeLayout(false);
            this.customBloodBorder.ResumeLayout(false);
            this.customAddressBorder.ResumeLayout(false);
            this.customAddressBorder.PerformLayout();
            this.customSalaryBorder.ResumeLayout(false);
            this.customSalaryBorder.PerformLayout();
            this.customJoinningdateBorder.ResumeLayout(false);
            this.customMediaclHistoryBorder.ResumeLayout(false);
            this.customMediaclHistoryBorder.PerformLayout();
            this.panelAddnewEmp.ResumeLayout(false);
            this.panelAddnewEmp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel customID;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel customNameBorder;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel CustomPhoneBorder;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Panel CustomEphoneBorder;
        private System.Windows.Forms.TextBox txtemergencyContact;
        private System.Windows.Forms.Panel customWeightBorder;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Panel customAgeBorder;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Panel customDesignationBorder;
        private System.Windows.Forms.ComboBox CmbDesignation;
        private System.Windows.Forms.Panel customBloodBorder;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.Panel customAddressBorder;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel customSalaryBorder;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Panel customJoinningdateBorder;
        private System.Windows.Forms.DateTimePicker dtpJoinningDate;
        private System.Windows.Forms.Panel customMediaclHistoryBorder;
        private System.Windows.Forms.TextBox txtMedicalHistory;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelAddnewEmp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
    }
}