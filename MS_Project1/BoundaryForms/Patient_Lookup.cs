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
    /*----------------------------------------------------------------------------
     * Author: J. Nobles
     * Date: 3/5/2014
     * Patient Lookup form -Boundary class
     *///-------------------------------------------------------------------------
    public partial class Patient_Lookup : Form
    {
        public Patient_Lookup()
        {
            InitializeComponent();
        }

        private void Patient_Lookup_Load(object sender, EventArgs e)
        {
            //load @ software start
        }

        private void ScannerNotWorking_Label_Click(object sender, EventArgs e)
        {
            //Open scanner help tutorial window
        }

        private void continue_btn_Click(object sender, EventArgs e)
        {
            //search database for patient ID entered into pID_txtbox
            /*-------------------------------------------------------
             * String ID =patient_Lookup.get(PatientID_txtBox);
             * database db =new database();
             * 
             * if(db.search(ID) && dbID == ID)
             * {
             *      EMAR emar =new EMAR();
             *      emar.show();
             * }
             * else if(db.search(UD))
             * {
             *      //display "Wrong Patient" ERROR msg
             *      MessageBox.Show("Wrong Patient!");
             * }
             * else
             * {
             *      //display "Patient NOT Found" ERROR msg
             *      MessageBox.Show("Patient NOT Found.");
             * }
             * 
             *///-----------------------------------------------------

        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            //Show Admin Home Screen
            Admin_Modify adminModForm = new Admin_Modify();
            adminModForm.Show();
        }

    }
}
