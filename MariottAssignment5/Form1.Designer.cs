namespace MariottAssignment5
{
    partial class frmSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalary));
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblstart = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.numSalary = new System.Windows.Forms.NumericUpDown();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(197, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(219, 81);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(56, 29);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age";
            // 
            // lblstart
            // 
            this.lblstart.AutoSize = true;
            this.lblstart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstart.Location = new System.Drawing.Point(107, 133);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(168, 29);
            this.lblstart.TabIndex = 2;
            this.lblstart.Text = "Starting Salary";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(282, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 26);
            this.txtName.TabIndex = 3;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(282, 81);
            this.numAge.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(73, 26);
            this.numAge.TabIndex = 4;
            // 
            // numSalary
            // 
            this.numSalary.Location = new System.Drawing.Point(282, 133);
            this.numSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSalary.Name = "numSalary";
            this.numSalary.Size = new System.Drawing.Size(145, 26);
            this.numSalary.TabIndex = 5;
            // 
            // btnCompute
            // 
            this.btnCompute.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnCompute.FlatAppearance.BorderSize = 2;
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.Location = new System.Drawing.Point(263, 215);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(294, 58);
            this.btnCompute.TabIndex = 6;
            this.btnCompute.Text = "&Compute Earnings";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 20;
            this.lstOutput.Location = new System.Drawing.Point(129, 327);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(551, 64);
            this.lstOutput.TabIndex = 7;
            // 
            // frmSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.numSalary);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblstart);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalary";
            this.Text = "Salary Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblstart;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.NumericUpDown numSalary;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.ListBox lstOutput;
    }
}

