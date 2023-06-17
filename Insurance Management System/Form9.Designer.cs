namespace Insurance_Management_System
{
    partial class Form9
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
            this.btnBackVPAy = new System.Windows.Forms.Button();
            this.btnDeletePAy = new System.Windows.Forms.Button();
            this.btnUpdatePay = new System.Windows.Forms.Button();
            this.txtAmountPay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvViewPay = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPayIDSearch = new System.Windows.Forms.TextBox();
            this.btnPayIDsearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpPaymentDateView = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewPay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackVPAy
            // 
            this.btnBackVPAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackVPAy.Location = new System.Drawing.Point(36, 400);
            this.btnBackVPAy.Name = "btnBackVPAy";
            this.btnBackVPAy.Size = new System.Drawing.Size(109, 37);
            this.btnBackVPAy.TabIndex = 99;
            this.btnBackVPAy.Text = "Back";
            this.btnBackVPAy.UseVisualStyleBackColor = true;
            this.btnBackVPAy.Click += new System.EventHandler(this.btnBackVPAy_Click);
            // 
            // btnDeletePAy
            // 
            this.btnDeletePAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePAy.Location = new System.Drawing.Point(515, 400);
            this.btnDeletePAy.Name = "btnDeletePAy";
            this.btnDeletePAy.Size = new System.Drawing.Size(109, 37);
            this.btnDeletePAy.TabIndex = 98;
            this.btnDeletePAy.Text = "Delete";
            this.btnDeletePAy.UseVisualStyleBackColor = true;
            this.btnDeletePAy.Click += new System.EventHandler(this.btnDeletePAy_Click);
            // 
            // btnUpdatePay
            // 
            this.btnUpdatePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePay.Location = new System.Drawing.Point(400, 400);
            this.btnUpdatePay.Name = "btnUpdatePay";
            this.btnUpdatePay.Size = new System.Drawing.Size(109, 37);
            this.btnUpdatePay.TabIndex = 97;
            this.btnUpdatePay.Text = "Update";
            this.btnUpdatePay.UseVisualStyleBackColor = true;
            this.btnUpdatePay.Click += new System.EventHandler(this.btnUpdatePay_Click);
            // 
            // txtAmountPay
            // 
            this.txtAmountPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPay.Location = new System.Drawing.Point(400, 299);
            this.txtAmountPay.Name = "txtAmountPay";
            this.txtAmountPay.Size = new System.Drawing.Size(224, 26);
            this.txtAmountPay.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 95;
            this.label4.Text = "Amount";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvViewPay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPayIDSearch);
            this.groupBox1.Controls.Add(this.btnPayIDsearch);
            this.groupBox1.Location = new System.Drawing.Point(18, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 189);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Payment";
            // 
            // dgvViewPay
            // 
            this.dgvViewPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewPay.Location = new System.Drawing.Point(18, 74);
            this.dgvViewPay.Name = "dgvViewPay";
            this.dgvViewPay.RowHeadersWidth = 51;
            this.dgvViewPay.RowTemplate.Height = 24;
            this.dgvViewPay.Size = new System.Drawing.Size(738, 95);
            this.dgvViewPay.TabIndex = 18;
            this.dgvViewPay.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvViewPay_CellMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Payment ID:";
            // 
            // txtPayIDSearch
            // 
            this.txtPayIDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayIDSearch.Location = new System.Drawing.Point(141, 31);
            this.txtPayIDSearch.Name = "txtPayIDSearch";
            this.txtPayIDSearch.Size = new System.Drawing.Size(225, 26);
            this.txtPayIDSearch.TabIndex = 16;
            // 
            // btnPayIDsearch
            // 
            this.btnPayIDsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayIDsearch.Location = new System.Drawing.Point(398, 29);
            this.btnPayIDsearch.Name = "btnPayIDsearch";
            this.btnPayIDsearch.Size = new System.Drawing.Size(109, 31);
            this.btnPayIDsearch.TabIndex = 15;
            this.btnPayIDsearch.Text = "Search";
            this.btnPayIDsearch.UseVisualStyleBackColor = true;
            this.btnPayIDsearch.Click += new System.EventHandler(this.btnPayIDsearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "Date";
            // 
            // dtpPaymentDateView
            // 
            this.dtpPaymentDateView.CustomFormat = "yyyy-MM-dd";
            this.dtpPaymentDateView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDateView.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPaymentDateView.Location = new System.Drawing.Point(400, 346);
            this.dtpPaymentDateView.Name = "dtpPaymentDateView";
            this.dtpPaymentDateView.Size = new System.Drawing.Size(224, 26);
            this.dtpPaymentDateView.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Payment";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 91;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpPaymentDateView);
            this.Controls.Add(this.btnBackVPAy);
            this.Controls.Add(this.btnDeletePAy);
            this.Controls.Add(this.btnUpdatePay);
            this.Controls.Add(this.txtAmountPay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form9";
            this.Text = "View Payment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewPay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackVPAy;
        private System.Windows.Forms.Button btnDeletePAy;
        private System.Windows.Forms.Button btnUpdatePay;
        private System.Windows.Forms.TextBox txtAmountPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvViewPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPayIDSearch;
        private System.Windows.Forms.Button btnPayIDsearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpPaymentDateView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}