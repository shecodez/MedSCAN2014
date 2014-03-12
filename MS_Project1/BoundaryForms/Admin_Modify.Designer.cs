namespace MS_Project1.BoundaryForms
{
    partial class Admin_Modify
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
            this.Instructions_label = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.patients_btn = new System.Windows.Forms.Button();
            this.medications_btn = new System.Windows.Forms.Button();
            this.top_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.top_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Instructions_label
            // 
            this.Instructions_label.AutoSize = true;
            this.Instructions_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions_label.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Instructions_label.Location = new System.Drawing.Point(195, 120);
            this.Instructions_label.Name = "Instructions_label";
            this.Instructions_label.Size = new System.Drawing.Size(392, 22);
            this.Instructions_label.TabIndex = 13;
            this.Instructions_label.Text = "Select the option you would like to modify.";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(3, 3);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(120, 37);
            this.TitleLabel.TabIndex = 10;
            this.TitleLabel.Text = "Modify";
            // 
            // patients_btn
            // 
            this.patients_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.patients_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patients_btn.Location = new System.Drawing.Point(434, 184);
            this.patients_btn.Name = "patients_btn";
            this.patients_btn.Size = new System.Drawing.Size(163, 74);
            this.patients_btn.TabIndex = 20;
            this.patients_btn.Text = "Patients";
            this.patients_btn.UseVisualStyleBackColor = false;
            this.patients_btn.Click += new System.EventHandler(this.patients_btn_Click);
            // 
            // medications_btn
            // 
            this.medications_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.medications_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medications_btn.Location = new System.Drawing.Point(189, 184);
            this.medications_btn.Name = "medications_btn";
            this.medications_btn.Size = new System.Drawing.Size(163, 74);
            this.medications_btn.TabIndex = 21;
            this.medications_btn.Text = "Medications";
            this.medications_btn.UseVisualStyleBackColor = false;
            this.medications_btn.Click += new System.EventHandler(this.medications_btn_Click);
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.top_panel.Controls.Add(this.TitleLabel);
            this.top_panel.Location = new System.Drawing.Point(1, 2);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(783, 80);
            this.top_panel.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.Instructions_label);
            this.panel1.Controls.Add(this.patients_btn);
            this.panel1.Controls.Add(this.medications_btn);
            this.panel1.Location = new System.Drawing.Point(1, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 385);
            this.panel1.TabIndex = 23;
            // 
            // Admin_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.top_panel);
            this.Name = "Admin_Modify";
            this.Text = "Admin_Modify";
            this.Load += new System.EventHandler(this.Admin_Modify_Load);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Instructions_label;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button patients_btn;
        private System.Windows.Forms.Button medications_btn;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel panel1;
    }
}