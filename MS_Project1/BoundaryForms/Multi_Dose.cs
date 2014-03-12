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
     * Date: 3/11/2014
     * Multi-Dose form -Boundary class
     *///-------------------------------------------------------------------------
    public partial class Multi_Dose : Form
    {
        public Multi_Dose()
        {
            InitializeComponent();
        }

        private void Multi_Dose_Load(object sender, EventArgs e)
        {
            //load if med amount on EMAR is > med dosage per unit  
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            //mark med as given in EMAR
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            //return to EMAR screen
        }

    }
}
