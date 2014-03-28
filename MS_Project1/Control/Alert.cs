using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MS_Project1.Control
{
    /*----------------------------------------------------------------------------
     * Author: J. Nobles
     * Date: 3/13/2014
     * Alert form -Control class
     *///-------------------------------------------------------------------------
    class Alert
    {
        //Scanner scanner =new Scanner();
        //GetID returned From scanner
        String patientID;
        int errorNo;

        //Database db =new Database();
 
        public void checkMed(String MedID, String pID){
            String msg ="Stop/n Wrong Medication!";
            //if(MedID != db.getMedicationID(pID));
                //MessageBox.Show(msg);
        }
        public void checkClassification(char gender, char pregnant, char classification)
        {
            String msg = "This Patient cannont take this medication of this classifacation:"+classification +".";
            //if(gender =='F' && classification !='B')
                //MessageBox.Show(msg);
        }
        public void checkAllergies(String[] allergies, String[] medications)
        {
            String msg = "Stop!/n Allergy Warning";
            for (int i = 0; i < medications.Length; i++ )
            {
                for(int j =0; j <allergies.Length; j++)
                {
                    //if(medications[i] ==allergies[j])
                        //MessageBox.Show(msg +allergies[j]);
                }
            }
        }

        public String checkPatient(String pID)
        {
            String msg = "Stop/n Wrong Patiene!";
            //if(pID != db.getMedicationID(pID));
            return msg;
            //else
            return "";
        }
        public bool checkDosage(float scannedDose, String medID)
        {
            //get medAmount from DB
            int medStrength =0; //=//db.getMedicationStrength(medicationID);
            if (scannedDose == medStrength)
            {
                //Signal OK to give
                return true;
            }
            else
            {
                if (scannedDose < medStrength)
                {
                    //call load multi/fractional dose form
                    BoundaryForms.MultiFractional_Dose MFDForm = new BoundaryForms.MultiFractional_Dose();
                    MFDForm.Show();
                }
                else if (scannedDose > medStrength)
                {
                    //call load multi dose form
                    BoundaryForms.Multi_Dose MDForm = new BoundaryForms.Multi_Dose();
                    MDForm.Show();
                }
                return false;
            }
            
        }
    }
}
