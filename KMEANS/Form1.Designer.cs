namespace KMEANS
{
    partial class Form1
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
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCLUSTERS = new System.Windows.Forms.Button();
            this.txtCENTRO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbCOORDS = new System.Windows.Forms.RichTextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEDITCOORDS = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(500, 500);
            this.panel.TabIndex = 0;
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEDITCOORDS);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnCLUSTERS);
            this.groupBox1.Controls.Add(this.txtCENTRO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.tbCOORDS);
            this.groupBox1.Location = new System.Drawing.Point(533, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 500);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Coordinates";
            // 
            // btnCLUSTERS
            // 
            this.btnCLUSTERS.Location = new System.Drawing.Point(9, 409);
            this.btnCLUSTERS.Name = "btnCLUSTERS";
            this.btnCLUSTERS.Size = new System.Drawing.Size(167, 23);
            this.btnCLUSTERS.TabIndex = 3;
            this.btnCLUSTERS.Text = "View Clusters";
            this.btnCLUSTERS.UseVisualStyleBackColor = true;
            this.btnCLUSTERS.Click += new System.EventHandler(this.btnCLUSTERS_Click);
            // 
            // txtCENTRO
            // 
            this.txtCENTRO.Location = new System.Drawing.Point(132, 325);
            this.txtCENTRO.Name = "txtCENTRO";
            this.txtCENTRO.Size = new System.Drawing.Size(44, 22);
            this.txtCENTRO.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "No of centroids : ";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(9, 361);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(167, 42);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Draw Coordinates and Centroids";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbCOORDS
            // 
            this.tbCOORDS.Location = new System.Drawing.Point(6, 21);
            this.tbCOORDS.Name = "tbCOORDS";
            this.tbCOORDS.Size = new System.Drawing.Size(170, 298);
            this.tbCOORDS.TabIndex = 0;
            this.tbCOORDS.Text = "";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(9, 467);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(167, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEDITCOORDS
            // 
            this.btnEDITCOORDS.Location = new System.Drawing.Point(9, 438);
            this.btnEDITCOORDS.Name = "btnEDITCOORDS";
            this.btnEDITCOORDS.Size = new System.Drawing.Size(167, 23);
            this.btnEDITCOORDS.TabIndex = 5;
            this.btnEDITCOORDS.Text = "Edit Input Data";
            this.btnEDITCOORDS.UseVisualStyleBackColor = true;
            this.btnEDITCOORDS.Click += new System.EventHandler(this.btnEDITCOORDS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 545);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RichTextBox tbCOORDS;
        private System.Windows.Forms.TextBox txtCENTRO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCLUSTERS;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEDITCOORDS;
    }
}

