namespace MS_Project1.BoundaryForms
{
    partial class Patient_Lookup
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Instructions_label = new System.Windows.Forms.Label();
            this.ScannerNotWorking_Label = new System.Windows.Forms.Label();
            this.PatientID_txtBox = new System.Windows.Forms.TextBox();
            this.continue_btn = new System.Windows.Forms.Button();
            this.ScannerStatus_Label = new System.Windows.Forms.Label();
            this.status_btn = new System.Windows.Forms.Button();
            this.top_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.admin_btn = new System.Windows.Forms.Button();
            this.top_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(3, 3);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(248, 37);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Patient Lookup";
            // 
            // Instructions_label
            // 
            this.Instructions_label.AutoSize = true;
            this.Instructions_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions_label.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Instructions_label.Location = new System.Drawing.Point(106, 136);
            this.Instructions_label.Name = "Instructions_label";
            this.Instructions_label.Size = new System.Drawing.Size(570, 22);
            this.Instructions_label.TabIndex = 3;
            this.Instructions_label.Text = "Scan the barcode located on the patient\'s wristband to begin.";
            // 
            // ScannerNotWorking_Label
            // 
            this.ScannerNotWorking_Label.AutoSize = true;
            this.ScannerNotWorking_Label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScannerNotWorking_Label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ScannerNotWorking_Label.Location = new System.Drawing.Point(316, 217);
            this.ScannerNotWorking_Label.Name = "ScannerNotWorking_Label";
            this.ScannerNotWorking_Label.Size = new System.Drawing.Size(151, 15);
            this.ScannerNotWorking_Label.TabIndex = 4;
            this.ScannerNotWorking_Label.Text = "Scanner Not Working?";
            this.ScannerNotWorking_Label.Click += new System.EventHandler(this.ScannerNotWorking_Label_Click);
            // 
            // PatientID_txtBox
            // 
            this.PatientID_txtBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientID_txtBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.PatientID_txtBox.Location = new System.Drawing.Point(214, 185);
            this.PatientID_txtBox.Name = "PatientID_txtBox";
            this.PatientID_txtBox.Size = new System.Drawing.Size(354, 29);
            this.PatientID_txtBox.TabIndex = 5;
            this.PatientID_txtBox.Text = "Scan/Enter Patient\'s ID Number...";
            // 
            // continue_btn
            // 
            this.continue_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.continue_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continue_btn.Location = new System.Drawing.Point(343, 264);
            this.continue_btn.Name = "continue_btn";
            this.continue_btn.Size = new System.Drawing.Size(97, 30);
            this.continue_btn.TabIndex = 6;
            this.continue_btn.Text = "Continue";
            this.continue_btn.UseVisualStyleBackColor = false;
            this.continue_btn.Click += new System.EventHandler(this.continue_btn_Click);
            // 
            // ScannerStatus_Label
            // 
            this.ScannerStatus_Label.AutoSize = true;
            this.ScannerStatus_Label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScannerStatus_Label.Location = new System.Drawing.Point(11, 351);
            this.ScannerStatus_Label.Name = "ScannerStatus_Label";
            this.ScannerStatus_Label.Size = new System.Drawing.Size(137, 18);
            this.ScannerStatus_Label.TabIndex = 7;
            this.ScannerStatus_Label.Text = "Scanner Status:";
            // 
            // status_btn
            // 
            this.status_btn.BackColor = System.Drawing.Color.Green;
            this.status_btn.Enabled = false;
            this.status_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.status_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.status_btn.Location = new System.Drawing.Point(154, 343);
            this.status_btn.Name = "status_btn";
            this.status_btn.Size = new System.Drawing.Size(75, 31);
            this.status_btn.TabIndex = 8;
            this.status_btn.UseVisualStyleBackColor = false;
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.top_panel.Controls.Add(this.TitleLabel);
            this.top_panel.Location = new System.Drawing.Point(1, 2);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(783, 80);
            this.top_panel.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.admin_btn);
            this.panel1.Controls.Add(this.Instructions_label);
            this.panel1.Controls.Add(this.ScannerStatus_Label);
            this.panel1.Controls.Add(this.continue_btn);
            this.panel1.Controls.Add(this.status_btn);
            this.panel1.Controls.Add(this.ScannerNotWorking_Label);
            this.panel1.Controls.Add(this.PatientID_txtBox);
            this.panel1.Location = new System.Drawing.Point(1, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 385);
            this.panel1.TabIndex = 24;
            // 
            // admin_btn
            // 
            this.admin_btn.BackColor = System.Drawing.Color.White;
            this.admin_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_btn.Location = new System.Drawing.Point(690, 346);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(81, 31);
            this.admin_btn.TabIndex = 20;
            this.admin_btn.Text = "ADMIN?";
            this.admin_btn.UseVisualStyleBackColor = false;
            this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click);
            // 
            // Patient_Lookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.top_panel);
            this.Name = "Patient_Lookup";
            this.Text = "MedSCAN - Patient Lookup";
            this.Load += new System.EventHandler(this.Patient_Lookup_Load);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label Instructions_label;
        private System.Windows.Forms.Label ScannerNotWorking_Label;
        private System.Windows.Forms.TextBox PatientID_txtBox;
        private System.Windows.Forms.Button continue_btn;
        private System.Windows.Forms.Label ScannerStatus_Label;
        private System.Windows.Forms.Button status_btn;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button admin_btn;
    }
}

