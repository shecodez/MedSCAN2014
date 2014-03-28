using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedSCANLibrary;

namespace MS_Project1.Entity
{
    class Medication
    {
        string medID;
        string trade, generic, pseudo, classification;
        char pregRC;
        string unitAmt, form, str, uom;
        string notes;

        DBWrapper oDBWrapper;

        public string ID
        {
            get
            {
                return medID;
            }
            set
            {
                medID = value;
            }
        } 

        public string TN    //Trade
        {
            get
            {
                return trade;
            }
            set
            {
                trade = value;
            }
        }

        public string PN    //Pseudo
        {
            get
            {
                return pseudo;
            }
            set
            {
                pseudo = value;
            }
        }

        public string GN    //Generic
        {
            get
            {
                return generic;
            }
            set
            {
                generic = value;
            }
        }

        public string CLASS
        {
            get
            {
                return classification;
            }
            set
            {
                classification = value;
            }
        }

        public char PRC    //Pregancy Risk Category
        {
            get
            {
                return pregRC;
            }
            set
            {
                pregRC = value;
            }
        }

        public string UnitAMT
        {
            get
            {
                return unitAmt;
            }
            set
            {
                unitAmt = value;
            }
        }

        public string FORM
        {
            get
            {
                return form;
            }
            set
            {
                form = value;
            }
        }

        public string STR
        {
            get
            {
                return str;
            }
            set
            {
                str = value;
            }
        }

        public string UOM
        {
            get
            {
                return uom;
            }
            set
            {
                uom = value;
            }
        }

        public string Notes
        {
            get
            {
                return notes;
            }
            set
            {
                notes = value;
            }
        }
    }
}
