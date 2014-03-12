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
    public partial class patientsMedicationsForm : Form
    {
        public patientsMedicationsForm()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            //ask if user is sure they want to exit
            //MessageBox.Show("Are your sure you want to cancel?");
            Admin_Modify adminMod = new Admin_Modify();
            adminMod.Show();
        }

        private void removeChecked_btn_Click(object sender, EventArgs e)
        {
            //remove edits from the database
        }

        private void function_button_Click(object sender, EventArgs e)
        {
            //save edits to the database
        }
    }
}
