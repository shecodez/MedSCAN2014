using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MS_Project1.Entity
{
    /*----------------------------------------------------------------------------
     * Author: J. Nobles
     * Date: 3/5/2014
     * Class for filling in Patient tab on EMAR form
     *///-------------------------------------------------------------------------
    class Profile //Profile : Patient  [Profile is derived from Patient]
    {
        //Patient patient =new Patient();
        //Scanner scanner =new Scanner();
       
        private String pID;
        private bool status; //active  || non-active
        private String lName, fName, mInit;
        private bool gender; //male =T || female =F
        private DateTime DOB;
        private bool[] flags; //Allergy, DNR, FallRisk, LatexAllergy, RestrictedExtremity, Other
        private String comments;
        private int count;
        private DateTime serverTime;
        private String photo; //image class??

        public new string getPID
        {
            get
            {
                return pID != null ? pID : "000000";
            }
        }


    }
}
