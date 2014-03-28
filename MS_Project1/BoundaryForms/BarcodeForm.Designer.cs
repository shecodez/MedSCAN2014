namespace MS_Project1.BoundaryForms
{
    partial class BarcodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodeForm));
            this.top_panel = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.bcDsgn_label = new System.Windows.Forms.Label();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.function_panel = new System.Windows.Forms.Panel();
            this.function_button = new System.Windows.Forms.Button();
            this.preview_panel = new System.Windows.Forms.Panel();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.selectedPatient_panel = new System.Windows.Forms.Panel();
            this.location_label = new System.Windows.Forms.Label();
            this.location_txtBox = new System.Windows.Forms.TextBox();
            this.btnGeneratePBC = new System.Windows.Forms.Button();
            this.preg_panel = new System.Windows.Forms.Panel();
            this.preg_radioButtonY = new System.Windows.Forms.RadioButton();
            this.preg_radioButtonN = new System.Windows.Forms.RadioButton();
            this.pregnant_label = new System.Windows.Forms.Label();
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.middleInitTextBox = new System.Windows.Forms.TextBox();
            this.sex_radioButtonF = new System.Windows.Forms.RadioButton();
            this.sex_radioButtonM = new System.Windows.Forms.RadioButton();
            this.dOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Physician_label = new System.Windows.Forms.Label();
            this.middle_label = new System.Windows.Forms.Label();
            this.DOB_label = new System.Windows.Forms.Label();
            this.physicianTextBox = new System.Windows.Forms.TextBox();
            this.gender_label = new System.Windows.Forms.Label();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.fname_label = new System.Windows.Forms.Label();
            this.lname_label = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.pID_label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.selectedMed_panel = new System.Windows.Forms.Panel();
            this.btnGenerateMBC = new System.Windows.Forms.Button();
            this.UOM_textBox = new System.Windows.Forms.TextBox();
            this.medicationIDTextBox = new System.Windows.Forms.TextBox();
            this.classificationTextBox = new System.Windows.Forms.TextBox();
            this.form_textBox = new System.Windows.Forms.TextBox();
            this.strength_label = new System.Windows.Forms.Label();
            this.tradeNameTextBox = new System.Windows.Forms.TextBox();
            this.genericNameTextBox = new System.Windows.Forms.TextBox();
            this.pseudoNameTextBox = new System.Windows.Forms.TextBox();
            this.unitAmountTextBox = new System.Windows.Forms.TextBox();
            this.strengthTextBox = new System.Windows.Forms.TextBox();
            this.UOM_label = new System.Windows.Forms.Label();
            this.unitAmount_label = new System.Windows.Forms.Label();
            this.form_label = new System.Windows.Forms.Label();
            this.pseudo_label = new System.Windows.Forms.Label();
            this.Generic_label = new System.Windows.Forms.Label();
            this.trade_label = new System.Windows.Forms.Label();
            this.classification_label = new System.Windows.Forms.Label();
            this.medID_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.top_panel.SuspendLayout();
            this.function_panel.SuspendLayout();
            this.preview_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.selectedPatient_panel.SuspendLayout();
            this.preg_panel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.selectedMed_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.top_panel.Controls.Add(this.btnSearch);
            this.top_panel.Controls.Add(this.bcDsgn_label);
            this.top_panel.Controls.Add(this.search_textBox);
            this.top_panel.Controls.Add(this.btnCancel);
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(783, 69);
            this.top_panel.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Location = new System.Drawing.Point(636, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(23, 24);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bcDsgn_label
            // 
            this.bcDsgn_label.AutoSize = true;
            this.bcDsgn_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcDsgn_label.Location = new System.Drawing.Point(3, 3);
            this.bcDsgn_label.Name = "bcDsgn_label";
            this.bcDsgn_label.Size = new System.Drawing.Size(299, 37);
            this.bcDsgn_label.TabIndex = 2;
            this.bcDsgn_label.Text = "Barcode Designer";
            // 
            // search_textBox
            // 
            this.search_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_textBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.search_textBox.Location = new System.Drawing.Point(449, 22);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(181, 25);
            this.search_textBox.TabIndex = 1;
            this.search_textBox.Text = "Search...";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(694, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 28);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // function_panel
            // 
            this.function_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.function_panel.Controls.Add(this.function_button);
            this.function_panel.Location = new System.Drawing.Point(433, 75);
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
            this.function_button.Text = "PRINT";
            this.function_button.UseVisualStyleBackColor = false;
            this.function_button.Click += new System.EventHandler(this.function_button_Click);
            // 
            // preview_panel
            // 
            this.preview_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.preview_panel.Controls.Add(this.previewPictureBox);
            this.preview_panel.Location = new System.Drawing.Point(433, 140);
            this.preview_panel.Name = "preview_panel";
            this.preview_panel.Size = new System.Drawing.Size(344, 290);
            this.preview_panel.TabIndex = 8;
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPictureBox.Location = new System.Drawing.Point(0, 0);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(344, 290);
            this.previewPictureBox.TabIndex = 0;
            this.previewPictureBox.TabStop = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(6, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(421, 420);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.selectedPatient_panel);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(413, 390);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patient";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // selectedPatient_panel
            // 
            this.selectedPatient_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectedPatient_panel.Controls.Add(this.location_label);
            this.selectedPatient_panel.Controls.Add(this.location_txtBox);
            this.selectedPatient_panel.Controls.Add(this.btnGeneratePBC);
            this.selectedPatient_panel.Controls.Add(this.preg_panel);
            this.selectedPatient_panel.Controls.Add(this.patientIDTextBox);
            this.selectedPatient_panel.Controls.Add(this.firstnameTextBox);
            this.selectedPatient_panel.Controls.Add(this.lastnameTextBox);
            this.selectedPatient_panel.Controls.Add(this.middleInitTextBox);
            this.selectedPatient_panel.Controls.Add(this.sex_radioButtonF);
            this.selectedPatient_panel.Controls.Add(this.sex_radioButtonM);
            this.selectedPatient_panel.Controls.Add(this.dOBDateTimePicker);
            this.selectedPatient_panel.Controls.Add(this.Physician_label);
            this.selectedPatient_panel.Controls.Add(this.middle_label);
            this.selectedPatient_panel.Controls.Add(this.DOB_label);
            this.selectedPatient_panel.Controls.Add(this.physicianTextBox);
            this.selectedPatient_panel.Controls.Add(this.gender_label);
            this.selectedPatient_panel.Controls.Add(this.statusCheckBox);
            this.selectedPatient_panel.Controls.Add(this.fname_label);
            this.selectedPatient_panel.Controls.Add(this.lname_label);
            this.selectedPatient_panel.Controls.Add(this.status_label);
            this.selectedPatient_panel.Controls.Add(this.pID_label);
            this.selectedPatient_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedPatient_panel.Location = new System.Drawing.Point(3, 3);
            this.selectedPatient_panel.Name = "selectedPatient_panel";
            this.selectedPatient_panel.Size = new System.Drawing.Size(407, 384);
            this.selectedPatient_panel.TabIndex = 3;
            // 
            // location_label
            // 
            this.location_label.AutoSize = true;
            this.location_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_label.Location = new System.Drawing.Point(9, 295);
            this.location_label.Name = "location_label";
            this.location_label.Size = new System.Drawing.Size(139, 17);
            this.location_label.TabIndex = 36;
            this.location_label.Text = "Hospital Location:";
            // 
            // location_txtBox
            // 
            this.location_txtBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_txtBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.location_txtBox.Location = new System.Drawing.Point(12, 314);
            this.location_txtBox.Name = "location_txtBox";
            this.location_txtBox.Size = new System.Drawing.Size(354, 25);
            this.location_txtBox.TabIndex = 35;
            this.location_txtBox.Text = "Georgia College University Hopsital";
            // 
            // btnGeneratePBC
            // 
            this.btnGeneratePBC.BackColor = System.Drawing.Color.Navy;
            this.btnGeneratePBC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePBC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGeneratePBC.Location = new System.Drawing.Point(10, 347);
            this.btnGeneratePBC.Name = "btnGeneratePBC";
            this.btnGeneratePBC.Size = new System.Drawing.Size(387, 31);
            this.btnGeneratePBC.TabIndex = 34;
            this.btnGeneratePBC.Text = "Generate Barcode";
            this.btnGeneratePBC.UseVisualStyleBackColor = false;
            this.btnGeneratePBC.Click += new System.EventHandler(this.btnGeneratePBC_Click);
            // 
            // preg_panel
            // 
            this.preg_panel.Controls.Add(this.preg_radioButtonY);
            this.preg_panel.Controls.Add(this.preg_radioButtonN);
            this.preg_panel.Controls.Add(this.pregnant_label);
            this.preg_panel.Location = new System.Drawing.Point(10, 257);
            this.preg_panel.Name = "preg_panel";
            this.preg_panel.Size = new System.Drawing.Size(178, 26);
            this.preg_panel.TabIndex = 26;
            // 
            // preg_radioButtonY
            // 
            this.preg_radioButtonY.AutoSize = true;
            this.preg_radioButtonY.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preg_radioButtonY.Location = new System.Drawing.Point(134, 2);
            this.preg_radioButtonY.Name = "preg_radioButtonY";
            this.preg_radioButtonY.Size = new System.Drawing.Size(35, 21);
            this.preg_radioButtonY.TabIndex = 36;
            this.preg_radioButtonY.Text = "Y";
            this.preg_radioButtonY.UseVisualStyleBackColor = true;
            // 
            // preg_radioButtonN
            // 
            this.preg_radioButtonN.AutoSize = true;
            this.preg_radioButtonN.Checked = true;
            this.preg_radioButtonN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preg_radioButtonN.Location = new System.Drawing.Point(91, 2);
            this.preg_radioButtonN.Name = "preg_radioButtonN";
            this.preg_radioButtonN.Size = new System.Drawing.Size(37, 21);
            this.preg_radioButtonN.TabIndex = 35;
            this.preg_radioButtonN.TabStop = true;
            this.preg_radioButtonN.Text = "N";
            this.preg_radioButtonN.UseVisualStyleBackColor = true;
            // 
            // pregnant_label
            // 
            this.pregnant_label.AutoSize = true;
            this.pregnant_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregnant_label.Location = new System.Drawing.Point(3, 5);
            this.pregnant_label.Name = "pregnant_label";
            this.pregnant_label.Size = new System.Drawing.Size(80, 17);
            this.pregnant_label.TabIndex = 34;
            this.pregnant_label.Text = "Pregnant:";
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDTextBox.Location = new System.Drawing.Point(10, 34);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(136, 25);
            this.patientIDTextBox.TabIndex = 9;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTextBox.Location = new System.Drawing.Point(104, 94);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(135, 25);
            this.firstnameTextBox.TabIndex = 11;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTextBox.Location = new System.Drawing.Point(104, 127);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(135, 25);
            this.lastnameTextBox.TabIndex = 13;
            // 
            // middleInitTextBox
            // 
            this.middleInitTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleInitTextBox.Location = new System.Drawing.Point(341, 127);
            this.middleInitTextBox.Name = "middleInitTextBox";
            this.middleInitTextBox.Size = new System.Drawing.Size(56, 25);
            this.middleInitTextBox.TabIndex = 15;
            // 
            // sex_radioButtonF
            // 
            this.sex_radioButtonF.AutoSize = true;
            this.sex_radioButtonF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sex_radioButtonF.Location = new System.Drawing.Point(144, 231);
            this.sex_radioButtonF.Name = "sex_radioButtonF";
            this.sex_radioButtonF.Size = new System.Drawing.Size(35, 21);
            this.sex_radioButtonF.TabIndex = 31;
            this.sex_radioButtonF.Text = "F";
            this.sex_radioButtonF.UseVisualStyleBackColor = true;
            // 
            // sex_radioButtonM
            // 
            this.sex_radioButtonM.AutoSize = true;
            this.sex_radioButtonM.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sex_radioButtonM.Location = new System.Drawing.Point(100, 231);
            this.sex_radioButtonM.Name = "sex_radioButtonM";
            this.sex_radioButtonM.Size = new System.Drawing.Size(38, 21);
            this.sex_radioButtonM.TabIndex = 30;
            this.sex_radioButtonM.Text = "M";
            this.sex_radioButtonM.UseVisualStyleBackColor = true;
            // 
            // dOBDateTimePicker
            // 
            this.dOBDateTimePicker.CustomFormat = "";
            this.dOBDateTimePicker.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dOBDateTimePicker.Location = new System.Drawing.Point(104, 161);
            this.dOBDateTimePicker.Name = "dOBDateTimePicker";
            this.dOBDateTimePicker.Size = new System.Drawing.Size(278, 25);
            this.dOBDateTimePicker.TabIndex = 21;
            // 
            // Physician_label
            // 
            this.Physician_label.AutoSize = true;
            this.Physician_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Physician_label.Location = new System.Drawing.Point(15, 198);
            this.Physician_label.Name = "Physician_label";
            this.Physician_label.Size = new System.Drawing.Size(83, 17);
            this.Physician_label.TabIndex = 11;
            this.Physician_label.Text = "Physician:";
            // 
            // middle_label
            // 
            this.middle_label.AutoSize = true;
            this.middle_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middle_label.Location = new System.Drawing.Point(247, 130);
            this.middle_label.Name = "middle_label";
            this.middle_label.Size = new System.Drawing.Size(92, 17);
            this.middle_label.TabIndex = 9;
            this.middle_label.Text = "Middle Init.:";
            // 
            // DOB_label
            // 
            this.DOB_label.AutoSize = true;
            this.DOB_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB_label.Location = new System.Drawing.Point(33, 164);
            this.DOB_label.Name = "DOB_label";
            this.DOB_label.Size = new System.Drawing.Size(62, 17);
            this.DOB_label.TabIndex = 8;
            this.DOB_label.Text = "D.O.B.:";
            // 
            // physicianTextBox
            // 
            this.physicianTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicianTextBox.Location = new System.Drawing.Point(104, 195);
            this.physicianTextBox.Name = "physicianTextBox";
            this.physicianTextBox.Size = new System.Drawing.Size(200, 25);
            this.physicianTextBox.TabIndex = 29;
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_label.Location = new System.Drawing.Point(27, 233);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(68, 17);
            this.gender_label.TabIndex = 5;
            this.gender_label.Text = "Gender:";
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCheckBox.Location = new System.Drawing.Point(177, 34);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(131, 24);
            this.statusCheckBox.TabIndex = 33;
            this.statusCheckBox.Text = "Active";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_label.Location = new System.Drawing.Point(13, 97);
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
            this.lname_label.Location = new System.Drawing.Point(15, 130);
            this.lname_label.Name = "lname_label";
            this.lname_label.Size = new System.Drawing.Size(84, 17);
            this.lname_label.TabIndex = 3;
            this.lname_label.Text = "Lastname:";
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.selectedMed_panel);
            this.tabPage2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(413, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Medication";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // selectedMed_panel
            // 
            this.selectedMed_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectedMed_panel.Controls.Add(this.btnGenerateMBC);
            this.selectedMed_panel.Controls.Add(this.UOM_textBox);
            this.selectedMed_panel.Controls.Add(this.medicationIDTextBox);
            this.selectedMed_panel.Controls.Add(this.classificationTextBox);
            this.selectedMed_panel.Controls.Add(this.form_textBox);
            this.selectedMed_panel.Controls.Add(this.strength_label);
            this.selectedMed_panel.Controls.Add(this.tradeNameTextBox);
            this.selectedMed_panel.Controls.Add(this.genericNameTextBox);
            this.selectedMed_panel.Controls.Add(this.pseudoNameTextBox);
            this.selectedMed_panel.Controls.Add(this.unitAmountTextBox);
            this.selectedMed_panel.Controls.Add(this.strengthTextBox);
            this.selectedMed_panel.Controls.Add(this.UOM_label);
            this.selectedMed_panel.Controls.Add(this.unitAmount_label);
            this.selectedMed_panel.Controls.Add(this.form_label);
            this.selectedMed_panel.Controls.Add(this.pseudo_label);
            this.selectedMed_panel.Controls.Add(this.Generic_label);
            this.selectedMed_panel.Controls.Add(this.trade_label);
            this.selectedMed_panel.Controls.Add(this.classification_label);
            this.selectedMed_panel.Controls.Add(this.medID_label);
            this.selectedMed_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedMed_panel.Location = new System.Drawing.Point(3, 3);
            this.selectedMed_panel.Name = "selectedMed_panel";
            this.selectedMed_panel.Size = new System.Drawing.Size(407, 384);
            this.selectedMed_panel.TabIndex = 3;
            // 
            // btnGenerateMBC
            // 
            this.btnGenerateMBC.BackColor = System.Drawing.Color.Green;
            this.btnGenerateMBC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateMBC.Location = new System.Drawing.Point(233, 345);
            this.btnGenerateMBC.Name = "btnGenerateMBC";
            this.btnGenerateMBC.Size = new System.Drawing.Size(164, 31);
            this.btnGenerateMBC.TabIndex = 35;
            this.btnGenerateMBC.Text = "Generate Barcode";
            this.btnGenerateMBC.UseVisualStyleBackColor = false;
            this.btnGenerateMBC.Click += new System.EventHandler(this.btnGenerateMBC_Click);
            // 
            // UOM_textBox
            // 
            this.UOM_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UOM_textBox.Location = new System.Drawing.Point(314, 184);
            this.UOM_textBox.Name = "UOM_textBox";
            this.UOM_textBox.Size = new System.Drawing.Size(86, 25);
            this.UOM_textBox.TabIndex = 28;
            // 
            // medicationIDTextBox
            // 
            this.medicationIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicationIDTextBox.Location = new System.Drawing.Point(9, 34);
            this.medicationIDTextBox.Name = "medicationIDTextBox";
            this.medicationIDTextBox.Size = new System.Drawing.Size(136, 24);
            this.medicationIDTextBox.TabIndex = 15;
            // 
            // classificationTextBox
            // 
            this.classificationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classificationTextBox.Location = new System.Drawing.Point(136, 93);
            this.classificationTextBox.Name = "classificationTextBox";
            this.classificationTextBox.Size = new System.Drawing.Size(63, 24);
            this.classificationTextBox.TabIndex = 17;
            // 
            // form_textBox
            // 
            this.form_textBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_textBox.Location = new System.Drawing.Point(314, 152);
            this.form_textBox.Name = "form_textBox";
            this.form_textBox.Size = new System.Drawing.Size(86, 25);
            this.form_textBox.TabIndex = 27;
            // 
            // strength_label
            // 
            this.strength_label.AutoSize = true;
            this.strength_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strength_label.Location = new System.Drawing.Point(232, 157);
            this.strength_label.Name = "strength_label";
            this.strength_label.Size = new System.Drawing.Size(76, 17);
            this.strength_label.TabIndex = 26;
            this.strength_label.Text = "Strength:";
            // 
            // tradeNameTextBox
            // 
            this.tradeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tradeNameTextBox.Location = new System.Drawing.Point(77, 124);
            this.tradeNameTextBox.Name = "tradeNameTextBox";
            this.tradeNameTextBox.Size = new System.Drawing.Size(122, 24);
            this.tradeNameTextBox.TabIndex = 19;
            // 
            // genericNameTextBox
            // 
            this.genericNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genericNameTextBox.Location = new System.Drawing.Point(77, 155);
            this.genericNameTextBox.Name = "genericNameTextBox";
            this.genericNameTextBox.Size = new System.Drawing.Size(122, 24);
            this.genericNameTextBox.TabIndex = 21;
            // 
            // pseudoNameTextBox
            // 
            this.pseudoNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pseudoNameTextBox.Location = new System.Drawing.Point(77, 186);
            this.pseudoNameTextBox.Name = "pseudoNameTextBox";
            this.pseudoNameTextBox.Size = new System.Drawing.Size(122, 24);
            this.pseudoNameTextBox.TabIndex = 23;
            // 
            // unitAmountTextBox
            // 
            this.unitAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitAmountTextBox.Location = new System.Drawing.Point(314, 90);
            this.unitAmountTextBox.Name = "unitAmountTextBox";
            this.unitAmountTextBox.Size = new System.Drawing.Size(86, 24);
            this.unitAmountTextBox.TabIndex = 25;
            // 
            // strengthTextBox
            // 
            this.strengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthTextBox.Location = new System.Drawing.Point(314, 121);
            this.strengthTextBox.Name = "strengthTextBox";
            this.strengthTextBox.Size = new System.Drawing.Size(86, 24);
            this.strengthTextBox.TabIndex = 29;
            // 
            // UOM_label
            // 
            this.UOM_label.AutoSize = true;
            this.UOM_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UOM_label.Location = new System.Drawing.Point(260, 186);
            this.UOM_label.Name = "UOM_label";
            this.UOM_label.Size = new System.Drawing.Size(48, 17);
            this.UOM_label.TabIndex = 11;
            this.UOM_label.Text = "UOM:";
            // 
            // unitAmount_label
            // 
            this.unitAmount_label.AutoSize = true;
            this.unitAmount_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitAmount_label.Location = new System.Drawing.Point(206, 99);
            this.unitAmount_label.Name = "unitAmount_label";
            this.unitAmount_label.Size = new System.Drawing.Size(102, 17);
            this.unitAmount_label.TabIndex = 10;
            this.unitAmount_label.Text = "Unit Amount:";
            // 
            // form_label
            // 
            this.form_label.AutoSize = true;
            this.form_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_label.Location = new System.Drawing.Point(257, 128);
            this.form_label.Name = "form_label";
            this.form_label.Size = new System.Drawing.Size(51, 17);
            this.form_label.TabIndex = 9;
            this.form_label.Text = "Form:";
            // 
            // pseudo_label
            // 
            this.pseudo_label.AutoSize = true;
            this.pseudo_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pseudo_label.Location = new System.Drawing.Point(4, 186);
            this.pseudo_label.Name = "pseudo_label";
            this.pseudo_label.Size = new System.Drawing.Size(67, 17);
            this.pseudo_label.TabIndex = 8;
            this.pseudo_label.Text = "Pseudo:";
            // 
            // Generic_label
            // 
            this.Generic_label.AutoSize = true;
            this.Generic_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generic_label.Location = new System.Drawing.Point(3, 157);
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
            this.trade_label.Location = new System.Drawing.Point(3, 128);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(433, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 59);
            this.panel1.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(16, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(312, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "SAVE BARCODE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BarcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.preview_panel);
            this.Controls.Add(this.function_panel);
            this.Controls.Add(this.top_panel);
            this.Name = "BarcodeForm";
            this.Text = "MedSCAN - ADMIN";
            this.Load += new System.EventHandler(this.BarcodeForm_Load);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.function_panel.ResumeLayout(false);
            this.preview_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.selectedPatient_panel.ResumeLayout(false);
            this.selectedPatient_panel.PerformLayout();
            this.preg_panel.ResumeLayout(false);
            this.preg_panel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.selectedMed_panel.ResumeLayout(false);
            this.selectedMed_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label bcDsgn_label;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel function_panel;
        private System.Windows.Forms.Button function_button;
        private System.Windows.Forms.Panel preview_panel;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel selectedPatient_panel;
        private System.Windows.Forms.Label location_label;
        private System.Windows.Forms.TextBox location_txtBox;
        private System.Windows.Forms.Button btnGeneratePBC;
        private System.Windows.Forms.Panel preg_panel;
        private System.Windows.Forms.RadioButton preg_radioButtonY;
        private System.Windows.Forms.RadioButton preg_radioButtonN;
        private System.Windows.Forms.Label pregnant_label;
        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox middleInitTextBox;
        private System.Windows.Forms.RadioButton sex_radioButtonF;
        private System.Windows.Forms.RadioButton sex_radioButtonM;
        private System.Windows.Forms.DateTimePicker dOBDateTimePicker;
        private System.Windows.Forms.Label Physician_label;
        private System.Windows.Forms.Label middle_label;
        private System.Windows.Forms.Label DOB_label;
        private System.Windows.Forms.TextBox physicianTextBox;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.Label lname_label;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label pID_label;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel selectedMed_panel;
        private System.Windows.Forms.Button btnGenerateMBC;
        private System.Windows.Forms.TextBox UOM_textBox;
        private System.Windows.Forms.TextBox medicationIDTextBox;
        private System.Windows.Forms.TextBox classificationTextBox;
        private System.Windows.Forms.TextBox form_textBox;
        private System.Windows.Forms.Label strength_label;
        private System.Windows.Forms.TextBox tradeNameTextBox;
        private System.Windows.Forms.TextBox genericNameTextBox;
        private System.Windows.Forms.TextBox pseudoNameTextBox;
        private System.Windows.Forms.TextBox unitAmountTextBox;
        private System.Windows.Forms.TextBox strengthTextBox;
        private System.Windows.Forms.Label UOM_label;
        private System.Windows.Forms.Label unitAmount_label;
        private System.Windows.Forms.Label form_label;
        private System.Windows.Forms.Label pseudo_label;
        private System.Windows.Forms.Label Generic_label;
        private System.Windows.Forms.Label trade_label;
        private System.Windows.Forms.Label classification_label;
        private System.Windows.Forms.Label medID_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}