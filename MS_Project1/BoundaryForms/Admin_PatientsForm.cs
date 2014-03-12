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
    * Date: 3/6/2014
    * Admin -PatientForm Boundary class
    *///-------------------------------------------------------------------------
    public partial class Admin_PatientsForm : Form
    {
        public Admin_PatientsForm()
        {
            InitializeComponent();
        }

        private void Admin_PatientForm_Load(object sender, EventArgs e)
        {

        }

        private void view_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            /*-------------------------------------------------------------------
             * // Set all fields to read-only
             * // Change function and apperance of function_button
             * function_button.setLabelText("GENERATE BARCODE");
             * function_button.setColor("DarkViolet");
             * 
             * 
             * 
             * 
             * 
             * 
             *///---------------------------------------------------------------- 
        }

        private void add_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            /*-------------------------------------------------------------------
             * // Clear all fields and set edit-able
             * // Change function and apperance of function_button
             * function_button.setLabelText("ADD");
             * function_button.setColor("Blue");
             * 
             * 
             * 
             * 
             * 
             * 
             */
            //---------------------------------------------------------------- 

        }

        private void edit_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            /*-------------------------------------------------------------------
             * // Set edit-able
             * // Change function and apperance of function_button
             * function_button.setLabelText("SAVE");
             * function_button.setColor("Green");
             * 
             * 
             * 
             * 
             * 
             * 
             */
            //----------------------------------------------------------------

        }

        private void remove_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            /*-------------------------------------------------------------------
             * // Set all fields to read-only
             * // Change function and apperance of function_button
             * function_button.setLabelText("REMOVE");
             * function_button.setColor("Red");
             * 
             * 
             * 
             * 
             * 
             * 
             */
            //-----------------------------------------------------------------
        }

        private void editMeds_btn_Click(object sender, EventArgs e)
        {
            //Load patientsMedicationsForm
            patientsMedicationsForm patientMeds = new patientsMedicationsForm();
            patientMeds.Show();
        }

        private void function_button_Click(object sender, EventArgs e)
        {
            /*--------------------------------------------------------------------
             * 
             * if(view_radioButton.selected)
             * {
             *     // Load patientBarcodeForm
             * }
             * else if(add_radioButton.selected)
             * {
             *     // Add patient to database
             * }
             * else if(edit_radioButton.selected)
             * {
             *     // Save changes to patient in database
             * }
             * else if(remove_radioButton.selected)
             * {
             *     // Remove patient from database
             * }
             * 
             *///----------------------------------------------------------------
        
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            // Ask if user would like to save changes
            // Return to Patient_Lookup screen
            //MessageBox.Show("Would you like to save your changes?");
            Admin_Modify adminMod = new Admin_Modify();
            adminMod.Show();
        }

        private void photo_pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
        }
    }
}
