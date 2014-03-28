using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedSCANLibrary;

namespace MS_Project1.Entity
{
    /*----------------------------------------------------------------------------
    * Author: J. Nobles
    * Date: 3/26/2014
    * Patient Class Enitiy class
    *///-------------------------------------------------------------------------
    class Patient
    {
        private DBWrapper oDBWrapper;

        String pID;
        String fn, ln;
        Char mi, gender, preg;
        DateTime dob;
        //Allergies, Meds.Scheculed, Meds.PRN, Meds.IVFluids
        String physician, comments;
        bool status; //True -Active False -Inactive
        bool drn, fullCode, allergy, fallRisk, restrictedExtremity, latexAllergy; //IndicatorFlags
        String age; //Create calculateAge(date dob)

        public string ID
        {
            get
            {
                return pID;
            }
            set
            {
                pID = value;
            }
        }

        public string FN
        {
            get
            {
                return fn;
            }
            set
            {
                fn = value;
            }
        }

        public char MI
        {
            get
            {
                return mi;
            }
            set
            {
                mi = value;
            }
        }

        public char GENDER
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public char PREG
        {
            get
            {
                return preg;
            }
            set
            {
                preg = value;
            }
        }

        public DateTime DOB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }

        public string DR
        {
            get
            {
                return physician;
            }
            set
            {
                physician = value;
            }
        }

        public string CMTs
        {
            get
            {
                return comments;
            }
            set
            {
                comments = value;
            }
        }

        public bool STATUS
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public bool DRN
        {
            get
            {
                return drn;
            }
            set
            {
                drn = value;
            }
        }

        public bool FULLCODE
        {
            get
            {
                return fullCode;
            }
            set
            {
                fullCode = value;
            }
        }

        public bool ALLERGY
        {
            get
            {
                return allergy;
            }
            set
            {
                allergy = value;
            }
        }

        public bool FALLRISK
        {
            get
            {
                return fallRisk;
            }
            set
            {
                fallRisk = value;
            }
        }

        public bool RESTEXT
        {
            get
            {
                return restrictedExtremity;
            }
            set
            {
                restrictedExtremity = value;
            }
        }

        public bool LATEXALRG
        {
            get
            {
                return latexAllergy;
            }
            set
            {
                latexAllergy = value;
            }
        }

        public int calculateAge(DateTime dob)
        {
            int age =99;
            return age;
        }

        public override string ToString()
        {
            return ln.ToUpper() + " " + ", " + fn + " " + mi + ". \n" +
                "<" + pID + ">\t" + physician + "\n" +
                dob + " " + calculateAge(dob) + "Y " + gender + " " + preg;
        }
    }//Class
}//NS
