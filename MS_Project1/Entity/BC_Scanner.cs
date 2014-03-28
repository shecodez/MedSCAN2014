using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.PointOfService;

namespace MS_Project1.Entity
{
    /*----------------------------------------------------------------------------
    * Author: J. Nobles
    * Date: 3/24/2014
    * Scanner Entity class
    *///-------------------------------------------------------------------------
    class BC_Scanner
    {
        PosExplorer explorer;
        Scanner scanner;

        String scannedStr ="";

        public string ScannedSTR
        {
            get { return scannedStr; }
        }

        /* private void Scanner(object sender, EventArgs e)
        {
            explorer = new PosExplorer(this);
            explorer.DeviceAddedEvent += new
                DeviceChangedEventHandler(explorer_DeviceAddedEvent);
        }*/

        /*  EXPLORER_DEVICEADDEDEVENT---------------------------------------------------
         *  determine whether the device is a barcode scanner, 
         *  create an instance of the scanner device, open the device, claim the device 
         *  create an event handler so we get informed about new scan events.
         */
        public void explorer_DeviceAddedEvent(object sender, DeviceChangedEventArgs e)
        {
            if (e.Device.Type == "Scanner")
            {
                scanner = (Scanner)explorer.CreateInstance(e.Device);
                scanner.Open();
                scanner.Claim(1000);
                scanner.DeviceEnabled = true;
                scanner.DataEvent += new DataEventHandler(scanner_DataEvent);
                scanner.DataEventEnabled = true;
                scanner.DecodeData = true;
            }
        }
        /*SCANNER_DATAEVENT
         * translate the bardocde data from a binary/byte format into a string
         */

        public void scanner_DataEvent(object sender, DataEventArgs e)
        {
            ASCIIEncoding encoding =new ASCIIEncoding();
            scanner.DataEventEnabled =true;
            scannedStr = encoding.GetString(scanner.ScanDataLabel);
        }
    }//class
}//nameSpace
