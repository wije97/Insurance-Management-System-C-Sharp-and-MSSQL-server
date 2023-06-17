namespace Insurance_Management_System
{
    partial class Form4
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
            this.btnViewClaim = new System.Windows.Forms.Button();
            this.btnViewPolicy = new System.Windows.Forms.Button();
            this.btnNewClaim = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnNewPolicy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogoutAgent = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agent";
            // 
            // btnViewClaim
            // 
            this.btnViewClaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewClaim.Location = new System.Drawing.Point(71, 182);
            this.btnViewClaim.Name = "btnViewClaim";
            this.btnViewClaim.Size = new System.Drawing.Size(186, 69);
            this.btnViewClaim.TabIndex = 17;
            this.btnViewClaim.Text = "View Claim";
            this.btnViewClaim.UseVisualStyleBackColor = true;
            this.btnViewClaim.Click += new System.EventHandler(this.btnViewClaim_Click);
            // 
            // btnViewPolicy
            // 
            this.btnViewPolicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPolicy.Location = new System.Drawing.Point(71, 32);
            this.btnViewPolicy.Name = "btnViewPolicy";
            this.btnViewPolicy.Size = new System.Drawing.Size(186, 69);
            this.btnViewPolicy.TabIndex = 16;
            this.btnViewPolicy.Text = "View Policy";
            this.btnViewPolicy.UseVisualStyleBackColor = true;
            this.btnViewPolicy.Click += new System.EventHandler(this.btnViewPolicy_Click);
            // 
            // btnNewClaim
            // 
            this.btnNewClaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewClaim.Location = new System.Drawing.Point(73, 147);
            this.btnNewClaim.Name = "btnNewClaim";
            this.btnNewClaim.Size = new System.Drawing.Size(186, 69);
            this.btnNewClaim.TabIndex = 15;
            this.btnNewClaim.Text = "New Claim";
            this.btnNewClaim.UseVisualStyleBackColor = true;
            this.btnNewClaim.Click += new System.EventHandler(this.btnNewClaim_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(71, 107);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(186, 69);
            this.btnPayment.TabIndex = 14;
            this.btnPayment.Text = "View Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnNewPolicy
            // 
            this.btnNewPolicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPolicy.Location = new System.Drawing.Point(73, 72);
            this.btnNewPolicy.Name = "btnNewPolicy";
            this.btnNewPolicy.Size = new System.Drawing.Size(186, 69);
            this.btnNewPolicy.TabIndex = 13;
            this.btnNewPolicy.Text = "New Policy";
            this.btnNewPolicy.UseVisualStyleBackColor = true;
            this.btnNewPolicy.Click += new System.EventHandler(this.btnNewPolicy_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.btnLogoutAgent);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 58);
            this.panel1.TabIndex = 12;
            // 
            // btnLogoutAgent
            // 
            this.btnLogoutAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutAgent.Location = new System.Drawing.Point(679, 14);
            this.btnLogoutAgent.Name = "btnLogoutAgent";
            this.btnLogoutAgent.Size = new System.Drawing.Size(109, 31);
            this.btnLogoutAgent.TabIndex = 8;
            this.btnLogoutAgent.Text = "Log Out";
            this.btnLogoutAgent.UseVisualStyleBackColor = true;
            this.btnLogoutAgent.Click += new System.EventHandler(this.btnLogoutAgent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNewPolicy);
            this.groupBox1.Controls.Add(this.btnNewClaim);
            this.groupBox1.Location = new System.Drawing.Point(40, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 279);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Section";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPayment);
            this.groupBox2.Controls.Add(this.btnViewClaim);
            this.groupBox2.Controls.Add(this.btnViewPolicy);
            this.groupBox2.Location = new System.Drawing.Point(426, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 279);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Section";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Agent Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewClaim;
        private System.Windows.Forms.Button btnViewPolicy;
        private System.Windows.Forms.Button btnNewClaim;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnNewPolicy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogoutAgent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}