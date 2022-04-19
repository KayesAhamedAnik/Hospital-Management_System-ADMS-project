
namespace ProjectDemo.Gui
{
    partial class updateDoctorInfo
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
            this.panelISDoctor = new System.Windows.Forms.Panel();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.customMediaclHistoryBorder = new System.Windows.Forms.Panel();
            this.txtspecialities = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnAMPMTo = new System.Windows.Forms.Button();
            this.btnAMPMFrom = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMMTo = new System.Windows.Forms.TextBox();
            this.txtHHTo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMMFrom = new System.Windows.Forms.TextBox();
            this.txtHHFrom = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbSchedule = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDoctorId = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelISDoctor.SuspendLayout();
            this.customMediaclHistoryBorder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelISDoctor
            // 
            this.panelISDoctor.BackColor = System.Drawing.SystemColors.Control;
            this.panelISDoctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelISDoctor.Controls.Add(this.panel1);
            this.panelISDoctor.Controls.Add(this.btnCancel);
            this.panelISDoctor.Controls.Add(this.cmbDept);
            this.panelISDoctor.Controls.Add(this.customMediaclHistoryBorder);
            this.panelISDoctor.Controls.Add(this.label7);
            this.panelISDoctor.Controls.Add(this.btnRefresh);
            this.panelISDoctor.Controls.Add(this.btnInsert);
            this.panelISDoctor.Controls.Add(this.btnAMPMTo);
            this.panelISDoctor.Controls.Add(this.btnAMPMFrom);
            this.panelISDoctor.Controls.Add(this.label16);
            this.panelISDoctor.Controls.Add(this.txtMMTo);
            this.panelISDoctor.Controls.Add(this.txtHHTo);
            this.panelISDoctor.Controls.Add(this.label14);
            this.panelISDoctor.Controls.Add(this.txtMMFrom);
            this.panelISDoctor.Controls.Add(this.txtHHFrom);
            this.panelISDoctor.Controls.Add(this.label13);
            this.panelISDoctor.Controls.Add(this.label12);
            this.panelISDoctor.Controls.Add(this.label11);
            this.panelISDoctor.Controls.Add(this.cbSchedule);
            this.panelISDoctor.Controls.Add(this.label10);
            this.panelISDoctor.Controls.Add(this.label9);
            this.panelISDoctor.Controls.Add(this.txtDoctorId);
            this.panelISDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelISDoctor.Location = new System.Drawing.Point(0, 0);
            this.panelISDoctor.Name = "panelISDoctor";
            this.panelISDoctor.Size = new System.Drawing.Size(563, 483);
            this.panelISDoctor.TabIndex = 92;
            // 
            // cmbDept
            // 
            this.cmbDept.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbDept.Location = new System.Drawing.Point(132, 136);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(142, 23);
            this.cmbDept.TabIndex = 100;
            // 
            // customMediaclHistoryBorder
            // 
            this.customMediaclHistoryBorder.Controls.Add(this.txtspecialities);
            this.customMediaclHistoryBorder.Location = new System.Drawing.Point(334, 279);
            this.customMediaclHistoryBorder.Name = "customMediaclHistoryBorder";
            this.customMediaclHistoryBorder.Padding = new System.Windows.Forms.Padding(1);
            this.customMediaclHistoryBorder.Size = new System.Drawing.Size(166, 101);
            this.customMediaclHistoryBorder.TabIndex = 98;
            // 
            // txtspecialities
            // 
            this.txtspecialities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtspecialities.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtspecialities.Location = new System.Drawing.Point(1, 1);
            this.txtspecialities.Margin = new System.Windows.Forms.Padding(2);
            this.txtspecialities.Multiline = true;
            this.txtspecialities.Name = "txtspecialities";
            this.txtspecialities.Size = new System.Drawing.Size(164, 99);
            this.txtspecialities.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(330, 242);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 19);
            this.label7.TabIndex = 97;
            this.label7.Text = "Specialities";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(212, 432);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 38);
            this.btnRefresh.TabIndex = 96;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnInsert.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(99, 432);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(95, 38);
            this.btnInsert.TabIndex = 95;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnAMPMTo
            // 
            this.btnAMPMTo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnAMPMTo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAMPMTo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAMPMTo.Location = new System.Drawing.Point(257, 356);
            this.btnAMPMTo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAMPMTo.Name = "btnAMPMTo";
            this.btnAMPMTo.Size = new System.Drawing.Size(45, 27);
            this.btnAMPMTo.TabIndex = 94;
            this.btnAMPMTo.Text = "PM";
            this.btnAMPMTo.UseVisualStyleBackColor = true;
            this.btnAMPMTo.Click += new System.EventHandler(this.btnAMPMTo_Click);
            // 
            // btnAMPMFrom
            // 
            this.btnAMPMFrom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnAMPMFrom.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAMPMFrom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAMPMFrom.Location = new System.Drawing.Point(257, 308);
            this.btnAMPMFrom.Margin = new System.Windows.Forms.Padding(2);
            this.btnAMPMFrom.Name = "btnAMPMFrom";
            this.btnAMPMFrom.Size = new System.Drawing.Size(45, 27);
            this.btnAMPMFrom.TabIndex = 93;
            this.btnAMPMFrom.Text = "PM";
            this.btnAMPMFrom.UseVisualStyleBackColor = true;
            this.btnAMPMFrom.Click += new System.EventHandler(this.btnAMPMFrom_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(180, 361);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 19);
            this.label16.TabIndex = 83;
            this.label16.Text = ":";
            // 
            // txtMMTo
            // 
            this.txtMMTo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMMTo.Location = new System.Drawing.Point(197, 358);
            this.txtMMTo.Margin = new System.Windows.Forms.Padding(2);
            this.txtMMTo.Name = "txtMMTo";
            this.txtMMTo.Size = new System.Drawing.Size(45, 27);
            this.txtMMTo.TabIndex = 82;
            this.txtMMTo.Text = "MM";
            this.txtMMTo.Click += new System.EventHandler(this.txtMMTo_Click);
            // 
            // txtHHTo
            // 
            this.txtHHTo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHHTo.Location = new System.Drawing.Point(131, 358);
            this.txtHHTo.Margin = new System.Windows.Forms.Padding(2);
            this.txtHHTo.Name = "txtHHTo";
            this.txtHHTo.Size = new System.Drawing.Size(45, 27);
            this.txtHHTo.TabIndex = 81;
            this.txtHHTo.Text = "HH";
            this.txtHHTo.Click += new System.EventHandler(this.txtHHTo_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(180, 311);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 19);
            this.label14.TabIndex = 79;
            this.label14.Text = ":";
            // 
            // txtMMFrom
            // 
            this.txtMMFrom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMMFrom.Location = new System.Drawing.Point(197, 308);
            this.txtMMFrom.Margin = new System.Windows.Forms.Padding(2);
            this.txtMMFrom.Name = "txtMMFrom";
            this.txtMMFrom.Size = new System.Drawing.Size(45, 27);
            this.txtMMFrom.TabIndex = 78;
            this.txtMMFrom.Text = "MM";
            this.txtMMFrom.Click += new System.EventHandler(this.txtMMFrom_Click);
            // 
            // txtHHFrom
            // 
            this.txtHHFrom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHHFrom.Location = new System.Drawing.Point(131, 308);
            this.txtHHFrom.Margin = new System.Windows.Forms.Padding(2);
            this.txtHHFrom.Name = "txtHHFrom";
            this.txtHHFrom.Size = new System.Drawing.Size(45, 27);
            this.txtHHFrom.TabIndex = 77;
            this.txtHHFrom.Text = "HH";
            this.txtHHFrom.Click += new System.EventHandler(this.txtHHFrom_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(95, 364);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 19);
            this.label13.TabIndex = 76;
            this.label13.Text = "To :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(78, 311);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 19);
            this.label12.TabIndex = 75;
            this.label12.Text = "From :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 185);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 19);
            this.label11.TabIndex = 72;
            this.label11.Text = "Schedule :";
            // 
            // cbSchedule
            // 
            this.cbSchedule.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSchedule.FormattingEnabled = true;
            this.cbSchedule.Items.AddRange(new object[] {
            "Sat",
            "Sun",
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri"});
            this.cbSchedule.Location = new System.Drawing.Point(132, 167);
            this.cbSchedule.Name = "cbSchedule";
            this.cbSchedule.Size = new System.Drawing.Size(142, 130);
            this.cbSchedule.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 138);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 19);
            this.label10.TabIndex = 70;
            this.label10.Text = "Depaartment:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 19);
            this.label9.TabIndex = 62;
            this.label9.Text = "Doctor Id :";
            // 
            // txtDoctorId
            // 
            this.txtDoctorId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorId.Location = new System.Drawing.Point(132, 83);
            this.txtDoctorId.Margin = new System.Windows.Forms.Padding(2);
            this.txtDoctorId.Name = "txtDoctorId";
            this.txtDoctorId.ReadOnly = true;
            this.txtDoctorId.Size = new System.Drawing.Size(142, 27);
            this.txtDoctorId.TabIndex = 61;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(325, 432);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 38);
            this.btnCancel.TabIndex = 101;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 48);
            this.panel1.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 98;
            this.label1.Text = "Update Doctor Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(526, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 99;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.btnCancel_Click);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // updateDoctorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(563, 483);
            this.Controls.Add(this.panelISDoctor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updateDoctorInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "updateDoctorInfo";
            this.Load += new System.EventHandler(this.updateDoctorInfo_Load);
            this.panelISDoctor.ResumeLayout(false);
            this.panelISDoctor.PerformLayout();
            this.customMediaclHistoryBorder.ResumeLayout(false);
            this.customMediaclHistoryBorder.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelISDoctor;
        private System.Windows.Forms.Button btnAMPMTo;
        private System.Windows.Forms.Button btnAMPMFrom;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMMTo;
        private System.Windows.Forms.TextBox txtHHTo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMMFrom;
        private System.Windows.Forms.TextBox txtHHFrom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox cbSchedule;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDoctorId;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel customMediaclHistoryBorder;
        private System.Windows.Forms.TextBox txtspecialities;
        private System.Windows.Forms.Label label7;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}