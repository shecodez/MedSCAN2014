MedSCAN2014
===========

Software Engineering Course final project

MedSCAN is Barcode Medication Administration (BCMA) software that will provide the nursing department students with a more realistic approach to managing and caring for patients in a hospital setting. BCMA software’s main goal is to verify the "5 rights of patient care": right patient, right drug, right dose, right route, and right time. 

The students will be able see the patient’s medication(s), and scan both the patient and medication barcode to make sure they have the correct patient/medication. 

The professor will be able to add, remove, edit, and view patients and medication information from the database. The professor will also be able to print unique barcodes for the different patients and medications.


For Windows 
==========================================================================================

Update Windows this will likely take awhile as there will probably be quite a few updates.

Install 	> Microsoft SQL Server 2008 SP2 Express Edition Service Pack 2 
 	<http://www.microsoft.com/en-us/download/details.aspx?id=20610>
 	(SQLEXPR_x64_ENU.exe)

Install 	> Microsoft® SQL Server® 2008 Express
<http://www.microsoft.com/en-us/download/details.aspx?id=1695>
 (SQLEXPR_x64_ENU.exe)
*See instructions for Setting up the SQL Server 2008 Express below

Install 	> Microsoft® SQL Server® 2008 Management Studio Express
 	<http://www.microsoft.com/en-us/download/details.aspx?id=7593>
 	(SQLManagementStudio_x64_ENU.exe)

Start Menu > All Programs > Microsoft SQL Server 2008 > Configuration Tools > 
SQL Server Configuration Manager : Make sure your SQL Server (SQLEXPRESS) is Running

Important Note: if MedSCAN's database files are not showing up and or you get an error when trying to access the database from the program check to make sure the SQL Server (SQLEXPRESS) server is running. If it is not Right click and start, if it is Right click and restart.


For Mac 
==========================================================================================

Here are the instruction on how to get MedSCAN working on a Mac OS X

*First make sure your Mac has at least 8 GBs of RAM but 16 GBs is preferable.

Install 	> VirtualBox for Mac OSX
 	<https://www.virtualbox.org/wiki/Downloads>
	(VirtualBox 5.0 for OS X hosts)

*Make sure you have a Copy of Windows 7 (64bit) for the VirtualBox to boot to.

Make a new VirtualBox Virtual machine,
Name it. (i.e Windows 7 x64)
Choose a memory size. (at least 3 to 4GB)
Create or use an existing virtual hard disk.
Hard disk file type: VDI ~Virtual Disk Image (default)
Start the virtual machine and insert the Window 7 boot disk or 
*If you have an ISO file instead boot to that by going to system settings> boot order > optical drive

Update Windows this will likely take awhile as there will probably be quite a few updates.

Install 	> Microsoft SQL Server 2008 SP2 Express Edition Service Pack 2 
 	<http://www.microsoft.com/en-us/download/details.aspx?id=20610>
 	(SQLEXPR_x64_ENU.exe)

Install 	> Microsoft® SQL Server® 2008 Express
<http://www.microsoft.com/en-us/download/details.aspx?id=1695>
 (SQLEXPR_x64_ENU.exe)
*See instructions for Setting up the SQL Server 2008 Express below

Install 	> Microsoft® SQL Server® 2008 Management Studio Express
 	<http://www.microsoft.com/en-us/download/details.aspx?id=7593>
 	(SQLManagementStudio_x64_ENU.exe)

Start Menu > All Programs > Microsoft SQL Server 2008 > Configuration Tools > 
SQL Server Configuration Manager : Make sure your SQL Server (SQLEXPRESS) is Running

Important Note: if MedSCAN's database files are not showing up and or you get an error when trying to access the database from the program check to make sure the SQL Server (SQLEXPRESS) server is running. If it is not Right click and start, if it is Right click and restart.


Now we have to enable the USB drives...
Install > Oracle VM VirtualBox Extension Pack <http://www.oracle.com/technetwork/server-storage/virtualbox/downloads/index.html#extpack>

*Make sure you get the version that matches your version of VirtualBox. (It should be version 5.0.0 if you installed VirtualBox recently) 

In VirtualBox go to settings > ports > switch to the USB tab > check Enable USB Controller > Select USB 2.0 (EHCI) Controller 

Add the USB devices you want the guest OS (Windows 7) to recognize when it's running. 
*If your copy of MedSCAN is on a USB drive add that drive to the list here.
*Also add your USB scanner if you see it in the list.

Start the virtual machine.

Once in windows go to the start menu > computer > and you should see your USB device under devices, if not just disconnect the device and reconnect it.

If you followed these instructions you should now be able to run MedSCAN on your Mac OS X.


Setting up Microsoft® SQL Server® 2008 Express
==========================================================================================

For this set up we will mostly go with the defaults.

Click the installation link on the left sidebar and click New Installation

Accept the license terms.

Make sure all the Setup Support Rules pass, but don’t worry about the Windows Firewall warning it more than likely won't be a problem.

Just go with the defaults and click next until you get to these steps:

Feature Selection: 
Click the Select All button and then click next 
Server Configuration: 
SQL Server Database Engine - Account Name: NT AUTHORITY\NETWORK SERVICE
SQL  Server Browser - leave it as it is and click next
Database Engine Configuration:
Make sure Windows authentication mode is selected
Under Specify SQL Server Administrators click the Add Current User button

Now for the rest just go with the defaults and click next

Once the installation is complete, close the SQL Server Installation Center and you should be good to go.
