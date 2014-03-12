using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MS_Project1.Boundary_Forms_
{
    /*----------------------------------------------------------------------------
     * Author: J. Nobles
     * Date: 3/5/2014
     * EMAR form -Boundary class
     *///-------------------------------------------------------------------------
    public partial class EMAR : Form
    {
        public EMAR()
        {
            InitializeComponent();
        }

        private void EMAR_Load(object sender, EventArgs e)
        {
            //load if correct patient id is scanned/typed
        }

        private void done_linklabel_Click(object sender, EventArgs e)
        {
            //Ask of user is sure they want to quit
            //MessageBox.Show("Are you sure you want to exit? All changes will be lost.");
            //load patient Look-up form (Home Screen)
        }

    }
}
