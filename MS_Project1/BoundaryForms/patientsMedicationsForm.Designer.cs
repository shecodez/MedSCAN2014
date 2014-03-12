namespace MS_Project1.BoundaryForms
{
    partial class patientsMedicationsForm
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
            this.patientsMeds_label = new System.Windows.Forms.Label();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.function_panel = new System.Windows.Forms.Panel();
            this.function_button = new System.Windows.Forms.Button();
            this.patientList_panel = new System.Windows.Forms.Panel();
            this.patients_dataGridView = new System.Windows.Forms.DataGridView();
            this.StatusColum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_panel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.status_comboBox = new System.Windows.Forms.ComboBox();
            this.pID_textBox = new System.Windows.Forms.TextBox();
            this.status_label = new System.Windows.Forms.Label();
            this.pID_label = new System.Windows.Forms.Label();
            this.medications_panel = new System.Windows.Forms.Panel();
            this.medications_dataGridView = new System.Windows.Forms.DataGridView();
            this.removeColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeChecked_btn = new System.Windows.Forms.Button();
            this.top_panel.SuspendLayout();
            this.function_panel.SuspendLayout();
            this.patientList_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patients_dataGridView)).BeginInit();
            this.patient_panel.SuspendLayout();
            this.medications_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medications_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.top_panel.Controls.Add(this.patientsMeds_label);
            this.top_panel.Controls.Add(this.search_textBox);
            this.top_panel.Controls.Add(this.cancel_btn);
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(785, 69);
            this.top_panel.TabIndex = 2;
            // 
            // patientsMeds_label
            // 
            this.patientsMeds_label.AutoSize = true;
            this.patientsMeds_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsMeds_label.Location = new System.Drawing.Point(3, 3);
            this.patientsMeds_label.Name = "patientsMeds_label";
            this.patientsMeds_label.Size = new System.Drawing.Size(347, 37);
            this.patientsMeds_label.TabIndex = 2;
            this.patientsMeds_label.Text = "Patient\'s Medications";
            // 
            // search_textBox
            // 
            this.search_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_textBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.search_textBox.Location = new System.Drawing.Point(525, 22);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(151, 25);
            this.search_textBox.TabIndex = 1;
            this.search_textBox.Text = "Search Patients";
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
            // function_panel
            // 
            this.function_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.function_panel.Controls.Add(this.function_button);
            this.function_panel.Location = new System.Drawing.Point(483, 75);
            this.function_panel.Name = "function_panel";
            this.function_panel.Size = new System.Drawing.Size(292, 59);
            this.function_panel.TabIndex = 7;
            // 
            // function_button
            // 
            this.function_button.BackColor = System.Drawing.Color.Green;
            this.function_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.function_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.function_button.Location = new System.Drawing.Point(17, 13);
            this.function_button.Name = "function_button";
            this.function_button.Size = new System.Drawing.Size(259, 33);
            this.function_button.TabIndex = 0;
            this.function_button.Text = "SAVE";
            this.function_button.UseVisualStyleBackColor = false;
            this.function_button.Click += new System.EventHandler(this.function_button_Click);
            // 
            // patientList_panel
            // 
            this.patientList_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.patientList_panel.Controls.Add(this.patients_dataGridView);
            this.patientList_panel.Location = new System.Drawing.Point(483, 140);
            this.patientList_panel.Name = "patientList_panel";
            this.patientList_panel.Size = new System.Drawing.Size(292, 350);
            this.patientList_panel.TabIndex = 8;
            // 
            // patients_dataGridView
            // 
            this.patients_dataGridView.AllowUserToAddRows = false;
            this.patients_dataGridView.AllowUserToDeleteRows = false;
            this.patients_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patients_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StatusColum,
            this.name_column,
            this.pID_Column});
            this.patients_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patients_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.patients_dataGridView.Name = "patients_dataGridView";
            this.patients_dataGridView.ReadOnly = true;
            this.patients_dataGridView.Size = new System.Drawing.Size(292, 350);
            this.patients_dataGridView.TabIndex = 1;
            // 
            // StatusColum
            // 
            this.StatusColum.HeaderText = "[ ]";
            this.StatusColum.Name = "StatusColum";
            this.StatusColum.ReadOnly = true;
            this.StatusColum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusColum.Width = 25;
            // 
            // name_column
            // 
            this.name_column.HeaderText = "Name";
            this.name_column.Name = "name_column";
            this.name_column.ReadOnly = true;
            this.name_column.Width = 150;
            // 
            // pID_Column
            // 
            this.pID_Column.HeaderText = "ID#";
            this.pID_Column.Name = "pID_Column";
            this.pID_Column.ReadOnly = true;
            this.pID_Column.Width = 73;
            // 
            // patient_panel
            // 
            this.patient_panel.Controls.Add(this.textBox1);
            this.patient_panel.Controls.Add(this.status_comboBox);
            this.patient_panel.Controls.Add(this.pID_textBox);
            this.patient_panel.Controls.Add(this.status_label);
            this.patient_panel.Controls.Add(this.pID_label);
            this.patient_panel.Location = new System.Drawing.Point(0, 75);
            this.patient_panel.Name = "patient_panel";
            this.patient_panel.Size = new System.Drawing.Size(477, 59);
            this.patient_panel.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(296, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 25);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "Search Medications";
            // 
            // status_comboBox
            // 
            this.status_comboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_comboBox.FormattingEnabled = true;
            this.status_comboBox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.status_comboBox.Location = new System.Drawing.Point(169, 23);
            this.status_comboBox.Name = "status_comboBox";
            this.status_comboBox.Size = new System.Drawing.Size(111, 25);
            this.status_comboBox.TabIndex = 23;
            // 
            // pID_textBox
            // 
            this.pID_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pID_textBox.Location = new System.Drawing.Point(6, 24);
            this.pID_textBox.Name = "pID_textBox";
            this.pID_textBox.Size = new System.Drawing.Size(136, 25);
            this.pID_textBox.TabIndex = 22;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.ForeColor = System.Drawing.Color.Red;
            this.status_label.Location = new System.Drawing.Point(166, 3);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(59, 17);
            this.status_label.TabIndex = 21;
            this.status_label.Text = "Status:";
            // 
            // pID_label
            // 
            this.pID_label.AutoSize = true;
            this.pID_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pID_label.ForeColor = System.Drawing.Color.Red;
            this.pID_label.Location = new System.Drawing.Point(3, 3);
            this.pID_label.Name = "pID_label";
            this.pID_label.Size = new System.Drawing.Size(84, 17);
            this.pID_label.TabIndex = 20;
            this.pID_label.Text = "Patient ID:";
            // 
            // medications_panel
            // 
            this.medications_panel.Controls.Add(this.medications_dataGridView);
            this.medications_panel.Location = new System.Drawing.Point(0, 179);
            this.medications_panel.Name = "medications_panel";
            this.medications_panel.Size = new System.Drawing.Size(477, 311);
            this.medications_panel.TabIndex = 10;
            // 
            // medications_dataGridView
            // 
            this.medications_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medications_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.removeColumn,
            this.DrugName,
            this.Dose,
            this.Route,
            this.Frequency,
            this.Time,
            this.PRN});
            this.medications_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medications_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.medications_dataGridView.Name = "medications_dataGridView";
            this.medications_dataGridView.Size = new System.Drawing.Size(477, 311);
            this.medications_dataGridView.TabIndex = 0;
            // 
            // removeColumn
            // 
            this.removeColumn.HeaderText = "[ ]";
            this.removeColumn.Name = "removeColumn";
            this.removeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.removeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.removeColumn.Width = 25;
            // 
            // DrugName
            // 
            this.DrugName.HeaderText = "Drug Name";
            this.DrugName.Name = "DrugName";
            this.DrugName.Width = 150;
            // 
            // Dose
            // 
            this.Dose.HeaderText = "Dose";
            this.Dose.Name = "Dose";
            this.Dose.Width = 52;
            // 
            // Route
            // 
            this.Route.HeaderText = "Route";
            this.Route.Name = "Route";
            this.Route.Width = 60;
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Freq.";
            this.Frequency.Name = "Frequency";
            this.Frequency.Width = 52;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.Width = 50;
            // 
            // PRN
            // 
            this.PRN.HeaderText = "PRN?";
            this.PRN.Name = "PRN";
            this.PRN.Width = 45;
            // 
            // removeChecked_btn
            // 
            this.removeChecked_btn.BackColor = System.Drawing.Color.Red;
            this.removeChecked_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeChecked_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeChecked_btn.Location = new System.Drawing.Point(6, 141);
            this.removeChecked_btn.Name = "removeChecked_btn";
            this.removeChecked_btn.Size = new System.Drawing.Size(129, 32);
            this.removeChecked_btn.TabIndex = 11;
            this.removeChecked_btn.Text = "Remove Marked";
            this.removeChecked_btn.UseVisualStyleBackColor = false;
            this.removeChecked_btn.Click += new System.EventHandler(this.removeChecked_btn_Click);
            // 
            // patientsMedicationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 502);
            this.Controls.Add(this.removeChecked_btn);
            this.Controls.Add(this.medications_panel);
            this.Controls.Add(this.patient_panel);
            this.Controls.Add(this.patientList_panel);
            this.Controls.Add(this.function_panel);
            this.Controls.Add(this.top_panel);
            this.Name = "patientsMedicationsForm";
            this.Text = "MedSCAN - ADMIN";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.function_panel.ResumeLayout(false);
            this.patientList_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patients_dataGridView)).EndInit();
            this.patient_panel.ResumeLayout(false);
            this.patient_panel.PerformLayout();
            this.medications_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medications_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label patientsMeds_label;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Panel function_panel;
        private System.Windows.Forms.Button function_button;
        private System.Windows.Forms.Panel patientList_panel;
        private System.Windows.Forms.DataGridView patients_dataGridView;
        private System.Windows.Forms.Panel patient_panel;
        private System.Windows.Forms.Panel medications_panel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StatusColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn pID_Column;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox status_comboBox;
        private System.Windows.Forms.TextBox pID_textBox;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label pID_label;
        private System.Windows.Forms.DataGridView medications_dataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn removeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Route;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRN;
        private System.Windows.Forms.Button removeChecked_btn;
    }
}