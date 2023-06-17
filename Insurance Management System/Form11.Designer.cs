namespace Insurance_Management_System
{
    partial class Form11
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvViewClaim = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClaimIDSearch = new System.Windows.Forms.TextBox();
            this.btnClaimIDsearch = new System.Windows.Forms.Button();
            this.txtAmountViewClaim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatusViewClaim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBackVClaim = new System.Windows.Forms.Button();
            this.btnDeleteClaim = new System.Windows.Forms.Button();
            this.btnUpdateClaim = new System.Windows.Forms.Button();
            this.btnviewAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewClaim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Claim";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnviewAll);
            this.groupBox1.Controls.Add(this.dgvViewClaim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtClaimIDSearch);
            this.groupBox1.Controls.Add(this.btnClaimIDsearch);
            this.groupBox1.Location = new System.Drawing.Point(18, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 303);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Claim";
            // 
            // dgvViewClaim
            // 
            this.dgvViewClaim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewClaim.Location = new System.Drawing.Point(18, 74);
            this.dgvViewClaim.Name = "dgvViewClaim";
            this.dgvViewClaim.RowHeadersWidth = 51;
            this.dgvViewClaim.RowTemplate.Height = 24;
            this.dgvViewClaim.Size = new System.Drawing.Size(721, 183);
            this.dgvViewClaim.TabIndex = 18;
            this.dgvViewClaim.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvViewClaim_CellMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Claim ID:";
            // 
            // txtClaimIDSearch
            // 
            this.txtClaimIDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaimIDSearch.Location = new System.Drawing.Point(112, 31);
            this.txtClaimIDSearch.Name = "txtClaimIDSearch";
            this.txtClaimIDSearch.Size = new System.Drawing.Size(225, 26);
            this.txtClaimIDSearch.TabIndex = 16;
            // 
            // btnClaimIDsearch
            // 
            this.btnClaimIDsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClaimIDsearch.Location = new System.Drawing.Point(369, 29);
            this.btnClaimIDsearch.Name = "btnClaimIDsearch";
            this.btnClaimIDsearch.Size = new System.Drawing.Size(109, 31);
            this.btnClaimIDsearch.TabIndex = 15;
            this.btnClaimIDsearch.Text = "Search";
            this.btnClaimIDsearch.UseVisualStyleBackColor = true;
            this.btnClaimIDsearch.Click += new System.EventHandler(this.btnClaimIDsearch_Click);
            // 
            // txtAmountViewClaim
            // 
            this.txtAmountViewClaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountViewClaim.Location = new System.Drawing.Point(533, 461);
            this.txtAmountViewClaim.Name = "txtAmountViewClaim";
            this.txtAmountViewClaim.Size = new System.Drawing.Size(224, 26);
            this.txtAmountViewClaim.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Amount";
            // 
            // txtStatusViewClaim
            // 
            this.txtStatusViewClaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusViewClaim.Location = new System.Drawing.Point(533, 417);
            this.txtStatusViewClaim.Name = "txtStatusViewClaim";
            this.txtStatusViewClaim.Size = new System.Drawing.Size(224, 26);
            this.txtStatusViewClaim.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "Status";
            // 
            // btnBackVClaim
            // 
            this.btnBackVClaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackVClaim.Location = new System.Drawing.Point(36, 518);
            this.btnBackVClaim.Name = "btnBackVClaim";
            this.btnBackVClaim.Size = new System.Drawing.Size(109, 37);
            this.btnBackVClaim.TabIndex = 90;
            this.btnBackVClaim.Text = "Back";
            this.btnBackVClaim.UseVisualStyleBackColor = true;
            this.btnBackVClaim.Click += new System.EventHandler(this.btnBackVP_Click);
            // 
            // btnDeleteClaim
            // 
            this.btnDeleteClaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClaim.Location = new System.Drawing.Point(648, 518);
            this.btnDeleteClaim.Name = "btnDeleteClaim";
            this.btnDeleteClaim.Size = new System.Drawing.Size(109, 37);
            this.btnDeleteClaim.TabIndex = 89;
            this.btnDeleteClaim.Text = "Delete";
            this.btnDeleteClaim.UseVisualStyleBackColor = true;
            this.btnDeleteClaim.Click += new System.EventHandler(this.btnDeleteClaim_Click);
            // 
            // btnUpdateClaim
            // 
            this.btnUpdateClaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClaim.Location = new System.Drawing.Point(533, 518);
            this.btnUpdateClaim.Name = "btnUpdateClaim";
            this.btnUpdateClaim.Size = new System.Drawing.Size(109, 37);
            this.btnUpdateClaim.TabIndex = 88;
            this.btnUpdateClaim.Text = "Update";
            this.btnUpdateClaim.UseVisualStyleBackColor = true;
            this.btnUpdateClaim.Click += new System.EventHandler(this.btnUpdateClaim_Click);
            // 
            // btnviewAll
            // 
            this.btnviewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewAll.Location = new System.Drawing.Point(630, 29);
            this.btnviewAll.Name = "btnviewAll";
            this.btnviewAll.Size = new System.Drawing.Size(109, 31);
            this.btnviewAll.TabIndex = 19;
            this.btnviewAll.Text = "View All";
            this.btnviewAll.UseVisualStyleBackColor = true;
            this.btnviewAll.Click += new System.EventHandler(this.btnviewAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(630, 263);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 29);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.btnBackVClaim);
            this.Controls.Add(this.btnDeleteClaim);
            this.Controls.Add(this.btnUpdateClaim);
            this.Controls.Add(this.txtAmountViewClaim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStatusViewClaim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form11";
            this.Text = "View Claim";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewClaim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvViewClaim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClaimIDSearch;
        private System.Windows.Forms.Button btnClaimIDsearch;
        private System.Windows.Forms.TextBox txtAmountViewClaim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatusViewClaim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBackVClaim;
        private System.Windows.Forms.Button btnDeleteClaim;
        private System.Windows.Forms.Button btnUpdateClaim;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnviewAll;
    }
}