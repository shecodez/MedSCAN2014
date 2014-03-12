namespace MS_Project1.BoundaryForms
{
    partial class Admin_PatientsForm
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
            this.patient_label = new System.Windows.Forms.Label();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.selectedPatient_panel = new System.Windows.Forms.Panel();
            this.photo_pictureBox = new System.Windows.Forms.PictureBox();
            this.editMeds_btn = new System.Windows.Forms.Button();
            this.meds_richTextBox = new System.Windows.Forms.RichTextBox();
            this.preg_radioButtonN = new System.Windows.Forms.RadioButton();
            this.Preg_radioButtonY = new System.Windows.Forms.RadioButton();
            this.gender_radioButtonF = new System.Windows.Forms.RadioButton();
            this.Gender_radioButtonM = new System.Windows.Forms.RadioButton();
            this.MiddleInit_textBox = new System.Windows.Forms.TextBox();
            this.status_comboBox = new System.Windows.Forms.ComboBox();
            this.bloodType_comboBox = new System.Windows.Forms.ComboBox();
            this.salutation_comboBox = new System.Windows.Forms.ComboBox();
            this.dr_textBox = new System.Windows.Forms.TextBox();
            this.fname_textBox = new System.Windows.Forms.TextBox();
            this.lname_textBox = new System.Windows.Forms.TextBox();
            this.dob_textBox = new System.Windows.Forms.TextBox();
            this.pID_textBox = new System.Windows.Forms.TextBox();
            this.Physician_label = new System.Windows.Forms.Label();
            this.bloodType_label = new System.Windows.Forms.Label();
            this.middle_label = new System.Windows.Forms.Label();
            this.DOB_label = new System.Windows.Forms.Label();
            this.Allergies_label = new System.Windows.Forms.Label();
            this.pregnant_label = new System.Windows.Forms.Label();
            this.gender_label = new System.Windows.Forms.Label();
            this.fname_label = new System.Windows.Forms.Label();
            this.lname_label = new System.Windows.Forms.Label();
            this.salutation_label = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.pID_label = new System.Windows.Forms.Label();
            this.view_radioButton = new System.Windows.Forms.RadioButton();
            this.add_radioButton = new System.Windows.Forms.RadioButton();
            this.edit_radioButton = new System.Windows.Forms.RadioButton();
            this.remove_radioButton = new System.Windows.Forms.RadioButton();
            this.function_panel = new System.Windows.Forms.Panel();
            this.function_button = new System.Windows.Forms.Button();
            this.patientList_panel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StatusColum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.top_panel.SuspendLayout();
            this.selectedPatient_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo_pictureBox)).BeginInit();
            this.function_panel.SuspendLayout();
            this.patientList_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.top_panel.Controls.Add(this.patient_label);
            this.top_panel.Controls.Add(this.search_textBox);
            this.top_panel.Controls.Add(this.cancel_btn);
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(785, 69);
            this.top_panel.TabIndex = 0;
            // 
            // patient_label
            // 
            this.patient_label.AutoSize = true;
            this.patient_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_label.Location = new System.Drawing.Point(3, 3);
            this.patient_label.Name = "patient_label";
            this.patient_label.Size = new System.Drawing.Size(143, 37);
            this.patient_label.TabIndex = 2;
            this.patient_label.Text = "Patients";
            // 
            // search_textBox
            // 
            this.search_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_textBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.search_textBox.Location = new System.Drawing.Point(525, 22);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(151, 25);
            this.search_textBox.TabIndex = 1;
            this.search_textBox.Text = "Search";
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
            // selectedPatient_panel
            // 
            this.selectedPatient_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectedPatient_panel.Controls.Add(this.photo_pictureBox);
            this.selectedPatient_panel.Controls.Add(this.editMeds_btn);
            this.selectedPatient_panel.Controls.Add(this.meds_richTextBox);
            this.selectedPatient_panel.Controls.Add(this.preg_radioButtonN);
            this.selectedPatient_panel.Controls.Add(this.Preg_radioButtonY);
            this.selectedPatient_panel.Controls.Add(this.gender_radioButtonF);
            this.selectedPatient_panel.Controls.Add(this.Gender_radioButtonM);
            this.selectedPatient_panel.Controls.Add(this.MiddleInit_textBox);
            this.selectedPatient_panel.Controls.Add(this.status_comboBox);
            this.selectedPatient_panel.Controls.Add(this.bloodType_comboBox);
            this.selectedPatient_panel.Controls.Add(this.salutation_comboBox);
            this.selectedPatient_panel.Controls.Add(this.dr_textBox);
            this.selectedPatient_panel.Controls.Add(this.fname_textBox);
            this.selectedPatient_panel.Controls.Add(this.lname_textBox);
            this.selectedPatient_panel.Controls.Add(this.dob_textBox);
            this.selectedPatient_panel.Controls.Add(this.pID_textBox);
            this.selectedPatient_panel.Controls.Add(this.Physician_label);
            this.selectedPatient_panel.Controls.Add(this.bloodType_label);
            this.selectedPatient_panel.Controls.Add(this.middle_label);
            this.selectedPatient_panel.Controls.Add(this.DOB_label);
            this.selectedPatient_panel.Controls.Add(this.Allergies_label);
            this.selectedPatient_panel.Controls.Add(this.pregnant_label);
            this.selectedPatient_panel.Controls.Add(this.gender_label);
            this.selectedPatient_panel.Controls.Add(this.fname_label);
            this.selectedPatient_panel.Controls.Add(this.lname_label);
            this.selectedPatient_panel.Controls.Add(this.salutation_label);
            this.selectedPatient_panel.Controls.Add(this.status_label);
            this.selectedPatient_panel.Controls.Add(this.pID_label);
            this.selectedPatient_panel.Location = new System.Drawing.Point(3, 103);
            this.selectedPatient_panel.Name = "selectedPatient_panel";
            this.selectedPatient_panel.Size = new System.Drawing.Size(419, 387);
            this.selectedPatient_panel.TabIndex = 1;
            // 
            // photo_pictureBox
            // 
            this.photo_pictureBox.Location = new System.Drawing.Point(333, 9);
            this.photo_pictureBox.Name = "photo_pictureBox";
            this.photo_pictureBox.Size = new System.Drawing.Size(75, 75);
            this.photo_pictureBox.TabIndex = 27;
            this.photo_pictureBox.TabStop = false;
            this.photo_pictureBox.Click += new System.EventHandler(this.photo_pictureBox_Click);
            // 
            // editMeds_btn
            // 
            this.editMeds_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.editMeds_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMeds_btn.Location = new System.Drawing.Point(279, 258);
            this.editMeds_btn.Name = "editMeds_btn";
            this.editMeds_btn.Size = new System.Drawing.Size(129, 26);
            this.editMeds_btn.TabIndex = 26;
            this.editMeds_btn.Text = "EDIT MEDS";
            this.editMeds_btn.UseVisualStyleBackColor = false;
            this.editMeds_btn.Click += new System.EventHandler(this.editMeds_btn_Click);
            // 
            // meds_richTextBox
            // 
            this.meds_richTextBox.Location = new System.Drawing.Point(9, 291);
            this.meds_richTextBox.Name = "meds_richTextBox";
            this.meds_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.meds_richTextBox.Size = new System.Drawing.Size(399, 80);
            this.meds_richTextBox.TabIndex = 25;
            this.meds_richTextBox.Text = "";
            // 
            // preg_radioButtonN
            // 
            this.preg_radioButtonN.AutoSize = true;
            this.preg_radioButtonN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preg_radioButtonN.Location = new System.Drawing.Point(111, 222);
            this.preg_radioButtonN.Name = "preg_radioButtonN";
            this.preg_radioButtonN.Size = new System.Drawing.Size(37, 21);
            this.preg_radioButtonN.TabIndex = 24;
            this.preg_radioButtonN.TabStop = true;
            this.preg_radioButtonN.Text = "N";
            this.preg_radioButtonN.UseVisualStyleBackColor = true;
            // 
            // Preg_radioButtonY
            // 
            this.Preg_radioButtonY.AutoSize = true;
            this.Preg_radioButtonY.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preg_radioButtonY.Location = new System.Drawing.Point(155, 221);
            this.Preg_radioButtonY.Name = "Preg_radioButtonY";
            this.Preg_radioButtonY.Size = new System.Drawing.Size(35, 21);
            this.Preg_radioButtonY.TabIndex = 23;
            this.Preg_radioButtonY.TabStop = true;
            this.Preg_radioButtonY.Text = "Y";
            this.Preg_radioButtonY.UseVisualStyleBackColor = true;
            // 
            // gender_radioButtonF
            // 
            this.gender_radioButtonF.AutoSize = true;
            this.gender_radioButtonF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_radioButtonF.Location = new System.Drawing.Point(155, 195);
            this.gender_radioButtonF.Name = "gender_radioButtonF";
            this.gender_radioButtonF.Size = new System.Drawing.Size(35, 21);
            this.gender_radioButtonF.TabIndex = 22;
            this.gender_radioButtonF.TabStop = true;
            this.gender_radioButtonF.Text = "F";
            this.gender_radioButtonF.UseVisualStyleBackColor = true;
            // 
            // Gender_radioButtonM
            // 
            this.Gender_radioButtonM.AutoSize = true;
            this.Gender_radioButtonM.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_radioButtonM.Location = new System.Drawing.Point(111, 195);
            this.Gender_radioButtonM.Name = "Gender_radioButtonM";
            this.Gender_radioButtonM.Size = new System.Drawing.Size(38, 21);
            this.Gender_radioButtonM.TabIndex = 21;
            this.Gender_radioButtonM.TabStop = true;
            this.Gender_radioButtonM.Text = "M";
            this.Gender_radioButtonM.UseVisualStyleBackColor = true;
            // 
            // MiddleInit_textBox
            // 
            this.MiddleInit_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleInit_textBox.Location = new System.Drawing.Point(353, 149);
            this.MiddleInit_textBox.Name = "MiddleInit_textBox";
            this.MiddleInit_textBox.Size = new System.Drawing.Size(55, 25);
            this.MiddleInit_textBox.TabIndex = 20;
            // 
            // status_comboBox
            // 
            this.status_comboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_comboBox.FormattingEnabled = true;
            this.status_comboBox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.status_comboBox.Location = new System.Drawing.Point(177, 34);
            this.status_comboBox.Name = "status_comboBox";
            this.status_comboBox.Size = new System.Drawing.Size(131, 25);
            this.status_comboBox.TabIndex = 19;
            // 
            // bloodType_comboBox
            // 
            this.bloodType_comboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodType_comboBox.FormattingEnabled = true;
            this.bloodType_comboBox.Location = new System.Drawing.Point(353, 121);
            this.bloodType_comboBox.Name = "bloodType_comboBox";
            this.bloodType_comboBox.Size = new System.Drawing.Size(55, 25);
            this.bloodType_comboBox.TabIndex = 18;
            // 
            // salutation_comboBox
            // 
            this.salutation_comboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salutation_comboBox.FormattingEnabled = true;
            this.salutation_comboBox.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Ms.",
            "Miss."});
            this.salutation_comboBox.Location = new System.Drawing.Point(114, 90);
            this.salutation_comboBox.Name = "salutation_comboBox";
            this.salutation_comboBox.Size = new System.Drawing.Size(63, 25);
            this.salutation_comboBox.TabIndex = 17;
            // 
            // dr_textBox
            // 
            this.dr_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr_textBox.Location = new System.Drawing.Point(272, 90);
            this.dr_textBox.Name = "dr_textBox";
            this.dr_textBox.Size = new System.Drawing.Size(136, 25);
            this.dr_textBox.TabIndex = 16;
            // 
            // fname_textBox
            // 
            this.fname_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_textBox.Location = new System.Drawing.Point(111, 154);
            this.fname_textBox.Name = "fname_textBox";
            this.fname_textBox.Size = new System.Drawing.Size(136, 25);
            this.fname_textBox.TabIndex = 15;
            // 
            // lname_textBox
            // 
            this.lname_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_textBox.Location = new System.Drawing.Point(111, 122);
            this.lname_textBox.Name = "lname_textBox";
            this.lname_textBox.Size = new System.Drawing.Size(136, 25);
            this.lname_textBox.TabIndex = 14;
            // 
            // dob_textBox
            // 
            this.dob_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_textBox.Location = new System.Drawing.Point(291, 194);
            this.dob_textBox.Name = "dob_textBox";
            this.dob_textBox.Size = new System.Drawing.Size(117, 25);
            this.dob_textBox.TabIndex = 13;
            // 
            // pID_textBox
            // 
            this.pID_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pID_textBox.Location = new System.Drawing.Point(14, 35);
            this.pID_textBox.Name = "pID_textBox";
            this.pID_textBox.Size = new System.Drawing.Size(136, 25);
            this.pID_textBox.TabIndex = 12;
            // 
            // Physician_label
            // 
            this.Physician_label.AutoSize = true;
            this.Physician_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Physician_label.Location = new System.Drawing.Point(183, 93);
            this.Physician_label.Name = "Physician_label";
            this.Physician_label.Size = new System.Drawing.Size(83, 17);
            this.Physician_label.TabIndex = 11;
            this.Physician_label.Text = "Physician:";
            // 
            // bloodType_label
            // 
            this.bloodType_label.AutoSize = true;
            this.bloodType_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodType_label.Location = new System.Drawing.Point(253, 125);
            this.bloodType_label.Name = "bloodType_label";
            this.bloodType_label.Size = new System.Drawing.Size(94, 17);
            this.bloodType_label.TabIndex = 10;
            this.bloodType_label.Text = "Blood Type:";
            // 
            // middle_label
            // 
            this.middle_label.AutoSize = true;
            this.middle_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middle_label.Location = new System.Drawing.Point(255, 152);
            this.middle_label.Name = "middle_label";
            this.middle_label.Size = new System.Drawing.Size(92, 17);
            this.middle_label.TabIndex = 9;
            this.middle_label.Text = "Middle Init.:";
            // 
            // DOB_label
            // 
            this.DOB_label.AutoSize = true;
            this.DOB_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB_label.Location = new System.Drawing.Point(223, 197);
            this.DOB_label.Name = "DOB_label";
            this.DOB_label.Size = new System.Drawing.Size(62, 17);
            this.DOB_label.TabIndex = 8;
            this.DOB_label.Text = "D.O.B.:";
            // 
            // Allergies_label
            // 
            this.Allergies_label.AutoSize = true;
            this.Allergies_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Allergies_label.ForeColor = System.Drawing.Color.Red;
            this.Allergies_label.Location = new System.Drawing.Point(11, 267);
            this.Allergies_label.Name = "Allergies_label";
            this.Allergies_label.Size = new System.Drawing.Size(96, 17);
            this.Allergies_label.TabIndex = 7;
            this.Allergies_label.Text = "Allergies(s):";
            // 
            // pregnant_label
            // 
            this.pregnant_label.AutoSize = true;
            this.pregnant_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregnant_label.Location = new System.Drawing.Point(25, 225);
            this.pregnant_label.Name = "pregnant_label";
            this.pregnant_label.Size = new System.Drawing.Size(80, 17);
            this.pregnant_label.TabIndex = 6;
            this.pregnant_label.Text = "Pregnant:";
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_label.Location = new System.Drawing.Point(39, 197);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(68, 17);
            this.gender_label.TabIndex = 5;
            this.gender_label.Text = "Gender:";
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_label.Location = new System.Drawing.Point(21, 157);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(86, 17);
            this.fname_label.TabIndex = 4;
            this.fname_label.Text = "Firstname:";
            // 
            // lname_label
            // 
            this.lname_label.AutoSize = true;
            this.lname_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_label.ForeColor = System.Drawing.Color.Red;
            this.lname_label.Location = new System.Drawing.Point(21, 125);
            this.lname_label.Name = "lname_label";
            this.lname_label.Size = new System.Drawing.Size(84, 17);
            this.lname_label.TabIndex = 3;
            this.lname_label.Text = "Lastname:";
            // 
            // salutation_label
            // 
            this.salutation_label.AutoSize = true;
            this.salutation_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salutation_label.Location = new System.Drawing.Point(21, 98);
            this.salutation_label.Name = "salutation_label";
            this.salutation_label.Size = new System.Drawing.Size(86, 17);
            this.salutation_label.TabIndex = 2;
            this.salutation_label.Text = "Salutation:";
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.ForeColor = System.Drawing.Color.Red;
            this.status_label.Location = new System.Drawing.Point(174, 14);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(59, 17);
            this.status_label.TabIndex = 1;
            this.status_label.Text = "Status:";
            // 
            // pID_label
            // 
            this.pID_label.AutoSize = true;
            this.pID_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pID_label.ForeColor = System.Drawing.Color.Red;
            this.pID_label.Location = new System.Drawing.Point(11, 14);
            this.pID_label.Name = "pID_label";
            this.pID_label.Size = new System.Drawing.Size(84, 17);
            this.pID_label.TabIndex = 0;
            this.pID_label.Text = "Patient ID:";
            // 
            // view_radioButton
            // 
            this.view_radioButton.AutoSize = true;
            this.view_radioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_radioButton.Location = new System.Drawing.Point(27, 75);
            this.view_radioButton.Name = "view_radioButton";
            this.view_radioButton.Size = new System.Drawing.Size(68, 22);
            this.view_radioButton.TabIndex = 2;
            this.view_radioButton.TabStop = true;
            this.view_radioButton.Text = "VIEW";
            this.view_radioButton.UseVisualStyleBackColor = true;
            this.view_radioButton.CheckedChanged += new System.EventHandler(this.view_radioButton_CheckedChanged);
            // 
            // add_radioButton
            // 
            this.add_radioButton.AutoSize = true;
            this.add_radioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_radioButton.Location = new System.Drawing.Point(101, 75);
            this.add_radioButton.Name = "add_radioButton";
            this.add_radioButton.Size = new System.Drawing.Size(62, 22);
            this.add_radioButton.TabIndex = 3;
            this.add_radioButton.TabStop = true;
            this.add_radioButton.Text = "ADD";
            this.add_radioButton.UseVisualStyleBackColor = true;
            this.add_radioButton.CheckedChanged += new System.EventHandler(this.add_radioButton_CheckedChanged);
            // 
            // edit_radioButton
            // 
            this.edit_radioButton.AutoSize = true;
            this.edit_radioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_radioButton.Location = new System.Drawing.Point(169, 75);
            this.edit_radioButton.Name = "edit_radioButton";
            this.edit_radioButton.Size = new System.Drawing.Size(64, 22);
            this.edit_radioButton.TabIndex = 4;
            this.edit_radioButton.TabStop = true;
            this.edit_radioButton.Text = "EDIT";
            this.edit_radioButton.UseVisualStyleBackColor = true;
            this.edit_radioButton.CheckedChanged += new System.EventHandler(this.edit_radioButton_CheckedChanged);
            // 
            // remove_radioButton
            // 
            this.remove_radioButton.AutoSize = true;
            this.remove_radioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_radioButton.Location = new System.Drawing.Point(239, 75);
            this.remove_radioButton.Name = "remove_radioButton";
            this.remove_radioButton.Size = new System.Drawing.Size(97, 22);
            this.remove_radioButton.TabIndex = 5;
            this.remove_radioButton.TabStop = true;
            this.remove_radioButton.Text = "REMOVE";
            this.remove_radioButton.UseVisualStyleBackColor = true;
            this.remove_radioButton.CheckedChanged += new System.EventHandler(this.remove_radioButton_CheckedChanged);
            // 
            // function_panel
            // 
            this.function_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.function_panel.Controls.Add(this.function_button);
            this.function_panel.Location = new System.Drawing.Point(431, 75);
            this.function_panel.Name = "function_panel";
            this.function_panel.Size = new System.Drawing.Size(344, 59);
            this.function_panel.TabIndex = 6;
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
            this.patientList_panel.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StatusColum,
            this.name_column,
            this.pID_Column});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(344, 350);
            this.dataGridView1.TabIndex = 0;
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
            // pID_Column
            // 
            this.pID_Column.HeaderText = "ID#";
            this.pID_Column.Name = "pID_Column";
            this.pID_Column.ReadOnly = true;
            // 
            // Admin_PatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 502);
            this.Controls.Add(this.patientList_panel);
            this.Controls.Add(this.function_panel);
            this.Controls.Add(this.remove_radioButton);
            this.Controls.Add(this.edit_radioButton);
            this.Controls.Add(this.add_radioButton);
            this.Controls.Add(this.view_radioButton);
            this.Controls.Add(this.selectedPatient_panel);
            this.Controls.Add(this.top_panel);
            this.Name = "Admin_PatientsForm";
            this.Text = "MedSCAN -ADMIN";
            this.Load += new System.EventHandler(this.Admin_PatientForm_Load);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.selectedPatient_panel.ResumeLayout(false);
            this.selectedPatient_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo_pictureBox)).EndInit();
            this.function_panel.ResumeLayout(false);
            this.patientList_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label patient_label;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Panel selectedPatient_panel;
        private System.Windows.Forms.RadioButton view_radioButton;
        private System.Windows.Forms.Label pID_label;
        private System.Windows.Forms.RadioButton add_radioButton;
        private System.Windows.Forms.RadioButton edit_radioButton;
        private System.Windows.Forms.RadioButton remove_radioButton;
        private System.Windows.Forms.TextBox dob_textBox;
        private System.Windows.Forms.TextBox pID_textBox;
        private System.Windows.Forms.Label Physician_label;
        private System.Windows.Forms.Label bloodType_label;
        private System.Windows.Forms.Label middle_label;
        private System.Windows.Forms.Label DOB_label;
        private System.Windows.Forms.Label Allergies_label;
        private System.Windows.Forms.Label pregnant_label;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.Label lname_label;
        private System.Windows.Forms.Label salutation_label;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.RadioButton Gender_radioButtonM;
        private System.Windows.Forms.TextBox MiddleInit_textBox;
        private System.Windows.Forms.ComboBox status_comboBox;
        private System.Windows.Forms.ComboBox bloodType_comboBox;
        private System.Windows.Forms.ComboBox salutation_comboBox;
        private System.Windows.Forms.TextBox dr_textBox;
        private System.Windows.Forms.TextBox fname_textBox;
        private System.Windows.Forms.TextBox lname_textBox;
        private System.Windows.Forms.RichTextBox meds_richTextBox;
        private System.Windows.Forms.RadioButton preg_radioButtonN;
        private System.Windows.Forms.RadioButton Preg_radioButtonY;
        private System.Windows.Forms.RadioButton gender_radioButtonF;
        private System.Windows.Forms.PictureBox photo_pictureBox;
        private System.Windows.Forms.Button editMeds_btn;
        private System.Windows.Forms.Panel function_panel;
        private System.Windows.Forms.Button function_button;
        private System.Windows.Forms.Panel patientList_panel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StatusColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn pID_Column;
    }
}