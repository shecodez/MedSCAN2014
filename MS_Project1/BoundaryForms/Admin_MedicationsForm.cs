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
    public partial class Admin_MedicationsForm : Form
    {
        public Admin_MedicationsForm()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            
            //Show message box and return user to HS
            //MessageBox.Show("Are you sure you want to cancel");
            
            Admin_Modify adminModForm = new Admin_Modify();
            adminModForm.Show();
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
             *///----------------------------------------------------------------
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
             *///----------------------------------------------------------------
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
              *///-----------------------------------------------------------------
        }
    }
}
