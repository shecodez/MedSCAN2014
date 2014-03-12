namespace MS_Project1.BoundaryForms
{
    partial class Admin_MedicationsForm
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
            this.top_panel = new System.Windows.Forms.Panel();
            this.medications_label = new System.Windows.Forms.Label();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.selectedMed_panel = new System.Windows.Forms.Panel();
            this.UOM_textBox = new System.Windows.Forms.TextBox();
            this.form_textBox = new System.Windows.Forms.TextBox();
            this.strength_label = new System.Windows.Forms.Label();
            this.notes_richTextBox = new System.Windows.Forms.RichTextBox();
            this.unitAmount_textBox = new System.Windows.Forms.TextBox();
            this.salutation_comboBox = new System.Windows.Forms.ComboBox();
            this.strength_textBox = new System.Windows.Forms.TextBox();
            this.generic_textBox = new System.Windows.Forms.TextBox();
            this.trade_textBox = new System.Windows.Forms.TextBox();
            this.pseudo_textBox = new System.Windows.Forms.TextBox();
            this.medID_textBox = new System.Windows.Forms.TextBox();
            this.UOM_label = new System.Windows.Forms.Label();
            this.unitAmount_label = new System.Windows.Forms.Label();
            this.form_label = new System.Windows.Forms.Label();
            this.pseudo_label = new System.Windows.Forms.Label();
            this.notes_label = new System.Windows.Forms.Label();
            this.Generic_label = new System.Windows.Forms.Label();
            this.trade_label = new System.Windows.Forms.Label();
            this.classification_label = new System.Windows.Forms.Label();
            this.medID_label = new System.Windows.Forms.Label();
            this.function_panel = new System.Windows.Forms.Panel();
            this.function_button = new System.Windows.Forms.Button();
            this.patientList_panel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StatusColum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove_radioButton = new System.Windows.Forms.RadioButton();
            this.edit_radioButton = new System.Windows.Forms.RadioButton();
            this.add_radioButton = new System.Windows.Forms.RadioButton();
            this.view_radioButton = new System.Windows.Forms.RadioButton();
            this.top_panel.SuspendLayout();
            this.selectedMed_panel.SuspendLayout();
            this.function_panel.SuspendLayout();
            this.patientList_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.top_panel.Controls.Add(this.medications_label);
            this.top_panel.Controls.Add(this.search_textBox);
            this.top_panel.Controls.Add(this.cancel_btn);
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(785, 69);
            this.top_panel.TabIndex = 1;
            // 
            // medications_label
            // 
            this.medications_label.AutoSize = true;
            this.medications_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medications_label.Location = new System.Drawing.Point(3, 3);
            this.medications_label.Name = "medications_label";
            this.medications_label.Size = new System.Drawing.Size(205, 37);
            this.medications_label.TabIndex = 2;
            this.medications_label.Text = "Medications";
            // 
            // search_textBox
            // 
            this.search_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_textBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.search_textBox.Location = new System.Drawing.Point(470, 22);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(206, 25);
            this.search_textBox.TabIndex = 1;
            this.search_textBox.Text = "Search Medications";
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Firebrick;
            this.cancel_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancel_btn.Location = new System.Drawing.Point(694, 20);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(78, 28);
            this.cancel_btn.TabIndex = 0;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // selectedMed_panel
            // 
            this.selectedMed_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectedMed_panel.Controls.Add(this.UOM_textBox);
            this.selectedMed_panel.Controls.Add(this.form_textBox);
            this.selectedMed_panel.Controls.Add(this.strength_label);
            this.selectedMed_panel.Controls.Add(this.notes_richTextBox);
            this.selectedMed_panel.Controls.Add(this.unitAmount_textBox);
            this.selectedMed_panel.Controls.Add(this.salutation_comboBox);
            this.selectedMed_panel.Controls.Add(this.strength_textBox);
            this.selectedMed_panel.Controls.Add(this.generic_textBox);
            this.selectedMed_panel.Controls.Add(this.trade_textBox);
            this.selectedMed_panel.Controls.Add(this.pseudo_textBox);
            this.selectedMed_panel.Controls.Add(this.medID_textBox);
            this.selectedMed_panel.Controls.Add(this.UOM_label);
            this.selectedMed_panel.Controls.Add(this.unitAmount_label);
            this.selectedMed_panel.Controls.Add(this.form_label);
            this.selectedMed_panel.Controls.Add(this.pseudo_label);
            this.selectedMed_panel.Controls.Add(this.notes_label);
            this.selectedMed_panel.Controls.Add(this.Generic_label);
            this.selectedMed_panel.Controls.Add(this.trade_label);
            this.selectedMed_panel.Controls.Add(this.classification_label);
            this.selectedMed_panel.Controls.Add(this.medID_label);
            this.selectedMed_panel.Location = new System.Drawing.Point(3, 103);
            this.selectedMed_panel.Name = "selectedMed_panel";
            this.selectedMed_panel.Size = new System.Drawing.Size(419, 387);
            this.selectedMed_panel.TabIndex = 2;
            // 
            // UOM_textBox
            // 
            this.UOM_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UOM_textBox.Location = new System.Drawing.Point(322, 185);
            this.UOM_textBox.Name = "UOM_textBox";
            this.UOM_textBox.Size = new System.Drawing.Size(86, 25);
            this.UOM_textBox.TabIndex = 28;
            // 
            // form_textBox
            // 
            this.form_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_textBox.Location = new System.Drawing.Point(322, 122);
            this.form_textBox.Name = "form_textBox";
            this.form_textBox.Size = new System.Drawing.Size(86, 25);
            this.form_textBox.TabIndex = 27;
            // 
            // strength_label
            // 
            this.strength_label.AutoSize = true;
            this.strength_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strength_label.Location = new System.Drawing.Point(240, 161);
            this.strength_label.Name = "strength_label";
            this.strength_label.Size = new System.Drawing.Size(76, 17);
            this.strength_label.TabIndex = 26;
            this.strength_label.Text = "Strength:";
            // 
            // notes_richTextBox
            // 
            this.notes_richTextBox.Location = new System.Drawing.Point(9, 291);
            this.notes_richTextBox.Name = "notes_richTextBox";
            this.notes_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.notes_richTextBox.Size = new System.Drawing.Size(399, 80);
            this.notes_richTextBox.TabIndex = 25;
            this.notes_richTextBox.Text = "";
            // 
            // unitAmount_textBox
            // 
            this.unitAmount_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitAmount_textBox.Location = new System.Drawing.Point(322, 91);
            this.unitAmount_textBox.Name = "unitAmount_textBox";
            this.unitAmount_textBox.Size = new System.Drawing.Size(86, 25);
            this.unitAmount_textBox.TabIndex = 20;
            // 
            // salutation_comboBox
            // 
            this.salutation_comboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salutation_comboBox.FormattingEnabled = true;
            this.salutation_comboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.salutation_comboBox.Location = new System.Drawing.Point(136, 91);
            this.salutation_comboBox.Name = "salutation_comboBox";
            this.salutation_comboBox.Size = new System.Drawing.Size(63, 25);
            this.salutation_comboBox.TabIndex = 17;
            // 
            // strength_textBox
            // 
            this.strength_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strength_textBox.Location = new System.Drawing.Point(322, 153);
            this.strength_textBox.Name = "strength_textBox";
            this.strength_textBox.Size = new System.Drawing.Size(86, 25);
            this.strength_textBox.TabIndex = 16;
            // 
            // generic_textBox
            // 
            this.generic_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generic_textBox.Location = new System.Drawing.Point(77, 153);
            this.generic_textBox.Name = "generic_textBox";
            this.generic_textBox.Size = new System.Drawing.Size(122, 25);
            this.generic_textBox.TabIndex = 15;
            // 
            // trade_textBox
            // 
            this.trade_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trade_textBox.Location = new System.Drawing.Point(77, 122);
            this.trade_textBox.Name = "trade_textBox";
            this.trade_textBox.Size = new System.Drawing.Size(122, 25);
            this.trade_textBox.TabIndex = 14;
            // 
            // pseudo_textBox
            // 
            this.pseudo_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pseudo_textBox.Location = new System.Drawing.Point(77, 185);
            this.pseudo_textBox.Name = "pseudo_textBox";
            this.pseudo_textBox.Size = new System.Drawing.Size(122, 25);
            this.pseudo_textBox.TabIndex = 13;
            // 
            // medID_textBox
            // 
            this.medID_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medID_textBox.Location = new System.Drawing.Point(14, 35);
            this.medID_textBox.Name = "medID_textBox";
            this.medID_textBox.Size = new System.Drawing.Size(136, 25);
            this.medID_textBox.TabIndex = 12;
            // 
            // UOM_label
            // 
            this.UOM_label.AutoSize = true;
            this.UOM_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UOM_label.Location = new System.Drawing.Point(268, 188);
            this.UOM_label.Name = "UOM_label";
            this.UOM_label.Size = new System.Drawing.Size(48, 17);
            this.UOM_label.TabIndex = 11;
            this.UOM_label.Text = "UOM:";
            // 
            // unitAmount_label
            // 
            this.unitAmount_label.AutoSize = true;
            this.unitAmount_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitAmount_label.Location = new System.Drawing.Point(214, 99);
            this.unitAmount_label.Name = "unitAmount_label";
            this.unitAmount_label.Size = new System.Drawing.Size(102, 17);
            this.unitAmount_label.TabIndex = 10;
            this.unitAmount_label.Text = "Unit Amount:";
            // 
            // form_label
            // 
            this.form_label.AutoSize = true;
            this.form_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_label.Location = new System.Drawing.Point(265, 130);
            this.form_label.Name = "form_label";
            this.form_label.Size = new System.Drawing.Size(51, 17);
            this.form_label.TabIndex = 9;
            this.form_label.Text = "Form:";
            // 
            // pseudo_label
            // 
            this.pseudo_label.AutoSize = true;
            this.pseudo_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pseudo_label.Location = new System.Drawing.Point(4, 188);
            this.pseudo_label.Name = "pseudo_label";
            this.pseudo_label.Size = new System.Drawing.Size(67, 17);
            this.pseudo_label.TabIndex = 8;
            this.pseudo_label.Text = "Pseudo:";
            // 
            // notes_label
            // 
            this.notes_label.AutoSize = true;
            this.notes_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.notes_label.Location = new System.Drawing.Point(11, 267);
            this.notes_label.Name = "notes_label";
            this.notes_label.Size = new System.Drawing.Size(55, 17);
            this.notes_label.TabIndex = 7;
            this.notes_label.Text = "Notes:";
            // 
            // Generic_label
            // 
            this.Generic_label.AutoSize = true;
            this.Generic_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generic_label.Location = new System.Drawing.Point(3, 161);
            this.Generic_label.Name = "Generic_label";
            this.Generic_label.Size = new System.Drawing.Size(72, 17);
            this.Generic_label.TabIndex = 4;
            this.Generic_label.Text = "Generic:";
            // 
            // trade_label
            // 
            this.trade_label.AutoSize = true;
            this.trade_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trade_label.ForeColor = System.Drawing.Color.Red;
            this.trade_label.Location = new System.Drawing.Point(3, 130);
            this.trade_label.Name = "trade_label";
            this.trade_label.Size = new System.Drawing.Size(56, 17);
            this.trade_label.TabIndex = 3;
            this.trade_label.Text = "Trade:";
            // 
            // classification_label
            // 
            this.classification_label.AutoSize = true;
            this.classification_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classification_label.Location = new System.Drawing.Point(3, 99);
            this.classification_label.Name = "classification_label";
            this.classification_label.Size = new System.Drawing.Size(111, 17);
            this.classification_label.TabIndex = 2;
            this.classification_label.Text = "Classification:";
            // 
            // medID_label
            // 
            this.medID_label.AutoSize = true;
            this.medID_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medID_label.ForeColor = System.Drawing.Color.Red;
            this.medID_label.Location = new System.Drawing.Point(11, 14);
            this.medID_label.Name = "medID_label";
            this.medID_label.Size = new System.Drawing.Size(112, 17);
            this.medID_label.TabIndex = 0;
            this.medID_label.Text = "Medication ID:";
            // 
            // function_panel
            // 
            this.function_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.function_panel.Controls.Add(this.function_button);
            this.function_panel.Location = new System.Drawing.Point(431, 75);
            this.function_panel.Name = "function_panel";
            this.function_panel.Size = new System.Drawing.Size(344, 59);
            this.function_panel.TabIndex = 7;
            // 
            // function_button
            // 
            this.function_button.BackColor = System.Drawing.Color.DarkViolet;
            this.function_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.function_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.function_button.Location = new System.Drawing.Point(16, 13);
            this.function_button.Name = "function_button";
            this.function_button.Size = new System.Drawing.Size(312, 33);
            this.function_button.TabIndex = 0;
            this.function_button.Text = "GENERATE BARCODE";
            this.function_button.UseVisualStyleBackColor = false;
            this.function_button.Click += new System.EventHandler(this.function_button_Click);
            // 
            // patientList_panel
            // 
            this.patientList_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.patientList_panel.Controls.Add(this.dataGridView1);
            this.patientList_panel.Location = new System.Drawing.Point(431, 140);
            this.patientList_panel.Name = "patientList_panel";
            this.patientList_panel.Size = new System.Drawing.Size(344, 350);
            this.patientList_panel.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StatusColum,
            this.name_column,
            this.medID_Column});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(344, 350);
            this.dataGridView1.TabIndex = 9;
            // 
            // StatusColum
            // 
            this.StatusColum.HeaderText = "Status";
            this.StatusColum.Name = "StatusColum";
            this.StatusColum.ReadOnly = true;
            this.StatusColum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusColum.Width = 50;
            // 
            // name_column
            // 
            this.name_column.HeaderText = "Name";
            this.name_column.Name = "name_column";
            this.name_column.ReadOnly = true;
            this.name_column.Width = 150;
            // 
            // medID_Column
            // 
            this.medID_Column.HeaderText = "ID#";
            this.medID_Column.Name = "medID_Column";
            this.medID_Column.ReadOnly = true;
            // 
            // remove_radioButton
            // 
            this.remove_radioButton.AutoSize = true;
            this.remove_radioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_radioButton.Location = new System.Drawing.Point(239, 75);
            this.remove_radioButton.Name = "remove_radioButton";
            this.remove_radioButton.Size = new System.Drawing.Size(97, 22);
            this.remove_radioButton.TabIndex = 13;
            this.remove_radioButton.TabStop = true;
            this.remove_radioButton.Text = "REMOVE";
            this.remove_radioButton.UseVisualStyleBackColor = true;
            this.remove_radioButton.CheckedChanged += new System.EventHandler(this.remove_radioButton_CheckedChanged);
            // 
            // edit_radioButton
            // 
            this.edit_radioButton.AutoSize = true;
            this.edit_radioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_radioButton.Location = new System.Drawing.Point(169, 75);
            this.edit_radioButton.Name = "edit_radioButton";
            this.edit_radioButton.Size = new System.Drawing.Size(64, 22);
            this.edit_radioButton.TabIndex = 12;
            this.edit_radioButton.TabStop = true;
            this.edit_radioButton.Text = "EDIT";
            this.edit_radioButton.UseVisualStyleBackColor = true;
            this.edit_radioButton.CheckedChanged += new System.EventHandler(this.edit_radioButton_CheckedChanged);
            // 
            // add_radioButton
            // 
            this.add_radioButton.AutoSize = true;
            this.add_radioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_radioButton.Location = new System.Drawing.Point(101, 75);
            this.add_radioButton.Name = "add_radioButton";
            this.add_radioButton.Size = new System.Drawing.Size(62, 22);
            this.add_radioButton.TabIndex = 11;
            this.add_radioButton.TabStop = true;
            this.add_radioButton.Text = "ADD";
            this.add_radioButton.UseVisualStyleBackColor = true;
            this.add_radioButton.CheckedChanged += new System.EventHandler(this.add_radioButton_CheckedChanged);
            // 
            // view_radioButton
            // 
            this.view_radioButton.AutoSize = true;
            this.view_radioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_radioButton.Location = new System.Drawing.Point(27, 75);
            this.view_radioButton.Name = "view_radioButton";
            this.view_radioButton.Size = new System.Drawing.Size(68, 22);
            this.view_radioButton.TabIndex = 10;
            this.view_radioButton.TabStop = true;
            this.view_radioButton.Text = "VIEW";
            this.view_radioButton.UseVisualStyleBackColor = true;
            this.view_radioButton.CheckedChanged += new System.EventHandler(this.view_radioButton_CheckedChanged);
            // 
            // Admin_MedicationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 502);
            this.Controls.Add(this.remove_radioButton);
            this.Controls.Add(this.edit_radioButton);
            this.Controls.Add(this.add_radioButton);
            this.Controls.Add(this.view_radioButton);
            this.Controls.Add(this.patientList_panel);
            this.Controls.Add(this.function_panel);
            this.Controls.Add(this.selectedMed_panel);
            this.Controls.Add(this.top_panel);
            this.Name = "Admin_MedicationsForm";
            this.Text = "MedSCAN - ADMIN";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.selectedMed_panel.ResumeLayout(false);
            this.selectedMed_panel.PerformLayout();
            this.function_panel.ResumeLayout(false);
            this.patientList_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label medications_label;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Panel selectedMed_panel;
        private System.Windows.Forms.RichTextBox notes_richTextBox;
        private System.Windows.Forms.TextBox unitAmount_textBox;
        private System.Windows.Forms.TextBox strength_textBox;
        private System.Windows.Forms.TextBox generic_textBox;
        private System.Windows.Forms.TextBox trade_textBox;
        private System.Windows.Forms.TextBox pseudo_textBox;
        private System.Windows.Forms.TextBox medID_textBox;
        private System.Windows.Forms.Label UOM_label;
        private System.Windows.Forms.Label unitAmount_label;
        private System.Windows.Forms.Label form_label;
        private System.Windows.Forms.Label pseudo_label;
        private System.Windows.Forms.Label notes_label;
        private System.Windows.Forms.Label Generic_label;
        private System.Windows.Forms.Label trade_label;
        private System.Windows.Forms.Label classification_label;
        private System.Windows.Forms.Label medID_label;
        private System.Windows.Forms.Panel function_panel;
        private System.Windows.Forms.Button function_button;
        private System.Windows.Forms.Panel patientList_panel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton remove_radioButton;
        private System.Windows.Forms.RadioButton edit_radioButton;
        private System.Windows.Forms.RadioButton add_radioButton;
        private System.Windows.Forms.RadioButton view_radioButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StatusColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn medID_Column;
        private System.Windows.Forms.ComboBox salutation_comboBox;
        private System.Windows.Forms.Label strength_label;
        private System.Windows.Forms.TextBox UOM_textBox;
        private System.Windows.Forms.TextBox form_textBox;
    }
}