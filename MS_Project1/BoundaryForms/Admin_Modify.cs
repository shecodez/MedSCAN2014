using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MS_Project1.BoundaryForms
{
    public partial class Admin_Modify : Form
    {
        public Admin_Modify()
        {
            InitializeComponent();
        }

        private void Admin_Modify_Load(object sender, EventArgs e)
        {
            //load @ software start
        }

        private void medications_btn_Click(object sender, EventArgs e)
        {
            // Load Admin_MedicationsForm
            Admin_MedicationsForm adminMeds = new Admin_MedicationsForm();
            adminMeds.Show();
        }

        private void patients_btn_Click(object sender, EventArgs e)
        {
            // Load Admin_PatientsForm
            Admin_PatientsForm adminPatients = new Admin_PatientsForm();
            adminPatients.Show();
        }
    }
}
