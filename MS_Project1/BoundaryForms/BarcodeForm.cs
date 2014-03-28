using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace MS_Project1.BoundaryForms
{
    /*----------------------------------------------------------------------------
    * Author: J. Nobles
    * Date: 3/23/2014
    * Admin - Barcode Form class
    *///-------------------------------------------------------------------------
    public partial class BarcodeForm : Form
    {
        public BarcodeForm()
        {
            InitializeComponent();
        }

        private void BarcodeForm_Load(object sender, EventArgs e)
        {
            string pID;
        }

        public void FillForm()
        {
           /* patientIDTextBox.Text =;
            firstnameTextBox.Text =;
            lastnameTextBox.Text =;
            middleInitTextBox.Text =;
            physicianTextBox.Text =;
            dOBDateTimePicker.Text =; */
        }


        private void function_button_Click(object sender, EventArgs e)
        {
            if (this.printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.HasMorePages = false;
        }

        private String CreatePatientInfoText()
        {
            string pID, fn, ln, mi, dr, sex="", preg="", dob, age="99", hospital;

            pID = patientIDTextBox.Text;
            fn = firstnameTextBox.Text;
            ln = lastnameTextBox.Text;
            mi = middleInitTextBox.Text;
            dr = physicianTextBox.Text;
            dob = dOBDateTimePicker.Text;
            hospital =location_txtBox.Text;
            //age = calculateAge(dob);

            if (preg_radioButtonY.Checked == true)
                preg = "Pregnant";

            if (sex_radioButtonF.Checked == true)
                sex = "F";
            else if (sex_radioButtonM.Checked == true)
                sex = "M";

            String label = ln.ToUpper() + " " + ", " + fn + " " + mi + ". \n" +
                "<"+pID + ">\t" + dr +"\n"+
                dob + " " + age+"Y "+ sex + " " + preg +" \n"+
                hospital;
            return label;           
        }

        private Bitmap CreateBarcode(string data, string info)
        {
            String txt =data.Trim();
            // Create the bitmap
            Bitmap bmp = new Bitmap(1, 1);

            // Get reference to the 3 of 9 font used to generate the barcode.
            Font threeOfNine =new Font("Free 3 of 9", 39,
                                System.Drawing.FontStyle.Regular,
                                System.Drawing.GraphicsUnit.Point);
            Font font = new Font("Arial", 15,
                FontStyle.Regular, GraphicsUnit.Pixel);

            // Graphic obj
            Graphics graphics = Graphics.FromImage(bmp);

            // Get width and height of info + bc
            int width = (int)graphics.MeasureString(info, font).Width;
            int height = (int)graphics.MeasureString(info, font).Height;

            int height2 = (int)graphics.MeasureString(txt, threeOfNine).Height;

            bmp = new Bitmap(bmp, new Size(width, height+height2));

            // Refresh graphic obj w/ new bitmap
            graphics = Graphics.FromImage(bmp);
            graphics.Clear(Color.White);
            
            // Set rendering hint to singleBitPerPixel
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;

            // Draw the string onto the graphics obj
            graphics.DrawString(info, font, 
                new SolidBrush(Color.Black), 0, 0);
            graphics.DrawString(txt, threeOfNine,
                new SolidBrush(Color.Black), 0, height);

            // Finish & Cleanup
            graphics.Flush();
            threeOfNine.Dispose();
            graphics.Dispose();
            
            // return the finished barcode
            return bmp;
        }
     
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //load Admin patients Form
            Admin_PatientsForm adminPF = new Admin_PatientsForm();
            adminPF.Show();
        }

        private void btnGeneratePBC_Click(object sender, EventArgs e)
        {
            if (patientIDTextBox.Text != "")
            {
                Bitmap barcode = CreateBarcode("*" + patientIDTextBox.Text.ToString().Trim() + "*", CreatePatientInfoText());
                previewPictureBox.Image = barcode;
            }
            else
                MessageBox.Show("Please enter an ID number.");
        }

        private void btnGenerateMBC_Click(object sender, EventArgs e)
        {
            if (medicationIDTextBox.Text != "")
            {
                Bitmap barcode = CreateBarcode("*" + medicationIDTextBox.Text.ToString().Trim() + "*", CreatePatientInfoText());
                previewPictureBox.Image = barcode;
            }
            else
                MessageBox.Show("Please enter an ID number.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKey = search_textBox.Text;
            //If patient ID entered doesnt match any in the db
            //if(database.SEARCH == -1)
                //MessageBox.Show("Invalid ID.");
            //else
                //fill in the form with the info from the paient with the mathingID
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                previewPictureBox.Image.Save(sfd.FileName, format);
            }
        }
    }
}
