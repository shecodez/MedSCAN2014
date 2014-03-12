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
     * Multi/Fractional Dose form -Boundary class
     */ //-------------------------------------------------------------------------
    public partial class MultiFractional_Dose : Form
    {
        public MultiFractional_Dose()
        {
            InitializeComponent();
        }

        private void MultiFractional_Dose_Load(object sender, EventArgs e)
        {
            //load if med amount on EMAR is > med dosage per unit  
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            //mark scaned meds as given in EMAR
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // return to emar
        }
    }
}
