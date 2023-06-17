namespace Insurance_Management_System
{
    partial class Form8
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvViewPolicy = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchIDVP = new System.Windows.Forms.TextBox();
            this.btnSearchIDVP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBackVP = new System.Windows.Forms.Button();
            this.btnDeleteVP = new System.Windows.Forms.Button();
            this.btnUpdateVP = new System.Windows.Forms.Button();
            this.txtAnnPremVP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMonthPreVP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtxHospitalCoverVP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIllnessCoverVP = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAccidentCoverVP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNaturalCoverVP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOpenedDateVP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpEndDateVP = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDateVP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatuMoneyVP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDurationVP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTypeVP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPolicyNoVP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewPolicy)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvViewPolicy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSearchIDVP);
            this.groupBox1.Controls.Add(this.btnSearchIDVP);
            this.groupBox1.Location = new System.Drawing.Point(18, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(971, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Policy";
            // 
            // dgvViewPolicy
            // 
            this.dgvViewPolicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewPolicy.Location = new System.Drawing.Point(22, 71);
            this.dgvViewPolicy.Name = "dgvViewPolicy";
            this.dgvViewPolicy.RowHeadersWidth = 51;
            this.dgvViewPolicy.RowTemplate.Height = 24;
            this.dgvViewPolicy.Size = new System.Drawing.Size(928, 141);
            this.dgvViewPolicy.TabIndex = 14;
            this.dgvViewPolicy.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvViewPolicy_CellMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Policy No:";
            // 
            // txtSearchIDVP
            // 
            this.txtSearchIDVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchIDVP.Location = new System.Drawing.Point(132, 28);
            this.txtSearchIDVP.Name = "txtSearchIDVP";
            this.txtSearchIDVP.Size = new System.Drawing.Size(225, 26);
            this.txtSearchIDVP.TabIndex = 12;
            // 
            // btnSearchIDVP
            // 
            this.btnSearchIDVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchIDVP.Location = new System.Drawing.Point(389, 26);
            this.btnSearchIDVP.Name = "btnSearchIDVP";
            this.btnSearchIDVP.Size = new System.Drawing.Size(109, 31);
            this.btnSearchIDVP.TabIndex = 11;
            this.btnSearchIDVP.Text = "Search";
            this.btnSearchIDVP.UseVisualStyleBackColor = true;
            this.btnSearchIDVP.Click += new System.EventHandler(this.btnSearchIDVP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBackVP);
            this.groupBox2.Controls.Add(this.btnDeleteVP);
            this.groupBox2.Controls.Add(this.btnUpdateVP);
            this.groupBox2.Controls.Add(this.txtAnnPremVP);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtMonthPreVP);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtxHospitalCoverVP);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtIllnessCoverVP);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtAccidentCoverVP);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNaturalCoverVP);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtOpenedDateVP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtpEndDateVP);
            this.groupBox2.Controls.Add(this.dtpStartDateVP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMatuMoneyVP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDurationVP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTypeVP);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPolicyNoVP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(18, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(971, 477);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Policy Details";
            // 
            // btnBackVP
            // 
            this.btnBackVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackVP.Location = new System.Drawing.Point(23, 419);
            this.btnBackVP.Name = "btnBackVP";
            this.btnBackVP.Size = new System.Drawing.Size(109, 37);
            this.btnBackVP.TabIndex = 87;
            this.btnBackVP.Text = "Back";
            this.btnBackVP.UseVisualStyleBackColor = true;
            this.btnBackVP.Click += new System.EventHandler(this.btnBackVP_Click);
            // 
            // btnDeleteVP
            // 
            this.btnDeleteVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteVP.Location = new System.Drawing.Point(819, 419);
            this.btnDeleteVP.Name = "btnDeleteVP";
            this.btnDeleteVP.Size = new System.Drawing.Size(109, 37);
            this.btnDeleteVP.TabIndex = 85;
            this.btnDeleteVP.Text = "Delete";
            this.btnDeleteVP.UseVisualStyleBackColor = true;
            this.btnDeleteVP.Click += new System.EventHandler(this.btnDeleteVP_Click);
            // 
            // btnUpdateVP
            // 
            this.btnUpdateVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateVP.Location = new System.Drawing.Point(704, 419);
            this.btnUpdateVP.Name = "btnUpdateVP";
            this.btnUpdateVP.Size = new System.Drawing.Size(109, 37);
            this.btnUpdateVP.TabIndex = 84;
            this.btnUpdateVP.Text = "Update";
            this.btnUpdateVP.UseVisualStyleBackColor = true;
            this.btnUpdateVP.Click += new System.EventHandler(this.btnUpdateVP_Click);
            // 
            // txtAnnPremVP
            // 
            this.txtAnnPremVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnnPremVP.Location = new System.Drawing.Point(723, 242);
            this.txtAnnPremVP.Name = "txtAnnPremVP";
            this.txtAnnPremVP.Size = new System.Drawing.Size(217, 26);
            this.txtAnnPremVP.TabIndex = 83;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(513, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 20);
            this.label13.TabIndex = 82;
            this.label13.Text = "Annual Premium";
            // 
            // txtMonthPreVP
            // 
            this.txtMonthPreVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthPreVP.Location = new System.Drawing.Point(723, 198);
            this.txtMonthPreVP.Name = "txtMonthPreVP";
            this.txtMonthPreVP.Size = new System.Drawing.Size(217, 26);
            this.txtMonthPreVP.TabIndex = 81;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(513, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 20);
            this.label11.TabIndex = 80;
            this.label11.Text = "Monthly Premium";
            // 
            // txtxHospitalCoverVP
            // 
            this.txtxHospitalCoverVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxHospitalCoverVP.Location = new System.Drawing.Point(723, 154);
            this.txtxHospitalCoverVP.Name = "txtxHospitalCoverVP";
            this.txtxHospitalCoverVP.Size = new System.Drawing.Size(217, 26);
            this.txtxHospitalCoverVP.TabIndex = 79;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(513, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 20);
            this.label12.TabIndex = 78;
            this.label12.Text = "Hospital Cover";
            // 
            // txtIllnessCoverVP
            // 
            this.txtIllnessCoverVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIllnessCoverVP.Location = new System.Drawing.Point(723, 111);
            this.txtIllnessCoverVP.Name = "txtIllnessCoverVP";
            this.txtIllnessCoverVP.Size = new System.Drawing.Size(217, 26);
            this.txtIllnessCoverVP.TabIndex = 77;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(513, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(186, 20);
            this.label15.TabIndex = 76;
            this.label15.Text = "Critical Illness Cover";
            // 
            // txtAccidentCoverVP
            // 
            this.txtAccidentCoverVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccidentCoverVP.Location = new System.Drawing.Point(723, 50);
            this.txtAccidentCoverVP.Name = "txtAccidentCoverVP";
            this.txtAccidentCoverVP.Size = new System.Drawing.Size(217, 26);
            this.txtAccidentCoverVP.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(515, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 40);
            this.label8.TabIndex = 74;
            this.label8.Text = "Accident Death \r\nCover";
            // 
            // txtNaturalCoverVP
            // 
            this.txtNaturalCoverVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaturalCoverVP.Location = new System.Drawing.Point(200, 357);
            this.txtNaturalCoverVP.Name = "txtNaturalCoverVP";
            this.txtNaturalCoverVP.Size = new System.Drawing.Size(217, 26);
            this.txtNaturalCoverVP.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 40);
            this.label9.TabIndex = 72;
            this.label9.Text = "Natural Death \r\nCover";
            // 
            // txtOpenedDateVP
            // 
            this.txtOpenedDateVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpenedDateVP.Location = new System.Drawing.Point(200, 310);
            this.txtOpenedDateVP.Name = "txtOpenedDateVP";
            this.txtOpenedDateVP.Size = new System.Drawing.Size(217, 26);
            this.txtOpenedDateVP.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 70;
            this.label10.Text = "Opened Age";
            // 
            // dtpEndDateVP
            // 
            this.dtpEndDateVP.CustomFormat = "yyyy-MM-dd";
            this.dtpEndDateVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDateVP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDateVP.Location = new System.Drawing.Point(200, 263);
            this.dtpEndDateVP.Name = "dtpEndDateVP";
            this.dtpEndDateVP.Size = new System.Drawing.Size(217, 26);
            this.dtpEndDateVP.TabIndex = 69;
            // 
            // dtpStartDateVP
            // 
            this.dtpStartDateVP.CustomFormat = "yyyy-MM-dd";
            this.dtpStartDateVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDateVP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDateVP.Location = new System.Drawing.Point(200, 219);
            this.dtpStartDateVP.Name = "dtpStartDateVP";
            this.dtpStartDateVP.Size = new System.Drawing.Size(217, 26);
            this.dtpStartDateVP.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 67;
            this.label4.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Start Date";
            // 
            // txtMatuMoneyVP
            // 
            this.txtMatuMoneyVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatuMoneyVP.Location = new System.Drawing.Point(200, 181);
            this.txtMatuMoneyVP.Name = "txtMatuMoneyVP";
            this.txtMatuMoneyVP.Size = new System.Drawing.Size(217, 26);
            this.txtMatuMoneyVP.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Maturity Money";
            // 
            // txtDurationVP
            // 
            this.txtDurationVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDurationVP.Location = new System.Drawing.Point(200, 137);
            this.txtDurationVP.Name = "txtDurationVP";
            this.txtDurationVP.Size = new System.Drawing.Size(217, 26);
            this.txtDurationVP.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Duration";
            // 
            // txtTypeVP
            // 
            this.txtTypeVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeVP.Location = new System.Drawing.Point(200, 93);
            this.txtTypeVP.Name = "txtTypeVP";
            this.txtTypeVP.Size = new System.Drawing.Size(217, 26);
            this.txtTypeVP.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Type";
            // 
            // txtPolicyNoVP
            // 
            this.txtPolicyNoVP.Enabled = false;
            this.txtPolicyNoVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPolicyNoVP.Location = new System.Drawing.Point(200, 50);
            this.txtPolicyNoVP.Name = "txtPolicyNoVP";
            this.txtPolicyNoVP.Size = new System.Drawing.Size(217, 26);
            this.txtPolicyNoVP.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "Policy No";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(415, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 29);
            this.label14.TabIndex = 0;
            this.label14.Text = "View Policy";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 55);
            this.panel1.TabIndex = 44;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1011, 803);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form8";
            this.Text = "View Policy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewPolicy)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvViewPolicy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchIDVP;
        private System.Windows.Forms.Button btnSearchIDVP;
        private System.Windows.Forms.DateTimePicker dtpEndDateVP;
        private System.Windows.Forms.DateTimePicker dtpStartDateVP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatuMoneyVP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDurationVP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTypeVP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPolicyNoVP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAccidentCoverVP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNaturalCoverVP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOpenedDateVP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAnnPremVP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMonthPreVP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtxHospitalCoverVP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIllnessCoverVP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnBackVP;
        private System.Windows.Forms.Button btnDeleteVP;
        private System.Windows.Forms.Button btnUpdateVP;
    }
}