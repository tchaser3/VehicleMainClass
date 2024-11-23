/* Title:           Vehicle Main Class
 * Date:            4-11-18
 * Author:          Terry Holmes
 * 
 * Description:     This class is the vehicle main class */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace VehicleMainDLL
{
    public class VehicleMainClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        VehicleMainDataSet aVehicleMainDataSet;
        VehicleMainDataSetTableAdapters.vehiclemainTableAdapter aVehicleMainTableAdpater;

        InsertVehicleMainEntryTableAdapters.QueriesTableAdapter aInsertVehicleMainTableAdapter;

        VehicleIDDataSet aVehicleIDDataSet;
        VehicleIDDataSetTableAdapters.vehicleidTableAdapter aVehicleIDTableAdapter;

        VehicleAssignmentDataSet aVehicleAssignmentDataSet;
        VehicleAssignmentDataSetTableAdapters.vehicleassignmentTableAdapter aVehicleAssignmentTableAdapter;

        FindActiveVehicleMainByVehicleNumberDataSet aFindActiveVehicleMainByVehicleNumberDataSet;
        FindActiveVehicleMainByVehicleNumberDataSetTableAdapters.FindActiveVehicleMainByVehicleNumberTableAdapter aFindActiveVehicleMainByVehicleNumberTableAdapter;

        FindActiveVehicleMainDataSet aFindActiveVehicleMainDataSet;
        FindActiveVehicleMainDataSetTableAdapters.FindActiveVehicleMainTableAdapter aFindActiveVehicleMainTableAdpater;

        UpdateVehicleMainEmployeeIDEntryTableAdapters.QueriesTableAdapter aUpdateVehicleMainEmployeeIDTableAdapter;

        UpdateVehicleMainAvailableEntryTableAdapters.QueriesTableAdapter aUpdateVehicleMainAvailableTableAdapter;

        FindVehicleMainByVehicleIDDataSet aFindVehicleMainByVehicleIDDataSet;
        FindVehicleMainByVehicleIDDataSetTableAdapters.FindVehicleMainByVehicleIDTableAdapter aFindVehicleMainByVehicleIDTableAdapter;

        FindVehicleMainByLicensePlateDataSet aFindVehicleMainByLicensePlateDataSet;
        FindVehicleMainByLicensePlateDataSetTableAdapters.FindVehicleMainByLicensePlateTableAdapter aFindVehicleMainByLicensePlateTableAdapter;

        UpdateVehicleMainEditEntryTableAdapters.QueriesTableAdapter aUpdateVehicleMainEditTableAdapter;

        UpdateMainOilChangeInformationEntryTableAdapters.QueriesTableAdapter aUpdateMainOilChangeInformationTableAdapter;

        UpdateVehicleMainActiveEntryTableAdapters.QueriesTableAdapter aUpdateVehicleMainActiveTableAdapter;

        FindVehicleMainForUnretirementDataSet aFindVehicleMainForUnretirementDataSet;
        FindVehicleMainForUnretirementDataSetTableAdapters.FindVehicleMainForUnretirementTableAdapter aFindVehicleMainForUnretirementTableAdapter;

        FindVehicleAssignedByEmployeeIDDataSet aFindVehicleAssignedByEmployeeIDDataSet;
        FindVehicleAssignedByEmployeeIDDataSetTableAdapters.FindVehicleAssignedByEmployeeIDTableAdapter aFindVehicleAssignedByEmployeeIDTableAdapter;

        FindActiveVehicleMainSortedDataSet aFindActiveVehicleMainSortedDataSet;
        FindActiveVehicleMainSortedDataSetTableAdapters.FindActiveVehicleMainSortedTableAdapter aFindActiveVehicleMainSortedTableAdapter;

        FindVehicleMainByDeactiveEmployeesDataSet aFindVehicleMainByDeactiveEmployeesDataSet;
        FindVehicleMainByDeactiveEmployeesDataSetTableAdapters.FindVehicleMainByDeactiveEmployeesTableAdapter aFindVehicleMainbyDeactiveEmployeesTableAdapter;

        FindAvailableVehiclesDataSet aFindAvailableVehiclesDataSet;
        FindAvailableVehiclesDataSetTableAdapters.FindAvailableVehiclesTableAdapter aFindAvailableVehiclesTableAdapter;

        FindVehicleMainForAssignedOfficeDataSet aFindVehicleMainForAssignedOfficeDataSet;
        FindVehicleMainForAssignedOfficeDataSetTableAdapters.FindVehicleMainForAssignedOfficeTableAdapter aFindVehicleMainForAssignedOfficeTableAdapter;

        FindActiveVehicleMainShortVehicleNumberDataSet aFindActiveVehicleMainShortVehicleNumberDataSet;
        FindActiveVehicleMainShortVehicleNumberDataSetTableAdapters.FindActiveVehicleMainShortVehicleNumberTableAdapter aFindActiveVehicleMainShortVehlcleNumberTableAdapter;

        FindVehicleMainByVINNumberDataSet aFindVehicleMainByVINNumberDataSet;
        FindVehicleMainByVINNumberDataSetTableAdapters.FindVehicleMainByVINNumberTableAdapter aFindVehicleMainByVINNumberTableAdapter;

        FindActiveVehicleMainByLocationDataSet aFindActiveVehicleMainByLocationDataSet;
        FindActiveVehicleMainByLocationDataSetTableAdapters.FindActiveVehicleMainByLocationTableAdapter aFindActiveVehicleMainByLocationTableAdapter;

        UpdateVehicleMainLocationEntryTableAdapters.QueriesTableAdapter aUpdateVehicleMainLocationTableAdapter;

        FindVehicleMainByVehicleNumberDataSet aFindVehicleMainByVehicleNumberDataSet;
        FindVehicleMainByVehicleNumberDataSetTableAdapters.FindVehicleMainByVehicleNumberTableAdapter aFindVehicleMainByVehicleNumberTableAdapter;

        FindVehicleMainToDeactivateDataSet aFindVehicleMainToDeactivateDataSet;
        FindVehicleMainToDeactivateDataSetTableAdapters.FindVehicleMainToDeactivateTableAdapter aFindVehicleMainToDeactivateTableAdapter;

        public FindVehicleMainToDeactivateDataSet FindVehicleMainToDeactivate()
        {
            try
            {
                aFindVehicleMainToDeactivateDataSet = new FindVehicleMainToDeactivateDataSet();
                aFindVehicleMainToDeactivateTableAdapter = new FindVehicleMainToDeactivateDataSetTableAdapters.FindVehicleMainToDeactivateTableAdapter();
                aFindVehicleMainToDeactivateTableAdapter.Fill(aFindVehicleMainToDeactivateDataSet.FindVehicleMainToDeactivate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Find Vehicle Main To Deactivate " + Ex.ToString());
            }

            return aFindVehicleMainToDeactivateDataSet;
        }
        public FindVehicleMainByVehicleNumberDataSet FindVehicleMainByVehicleNumber(string strVehicleNumber)
        {
            try
            {
                aFindVehicleMainByVehicleNumberDataSet = new FindVehicleMainByVehicleNumberDataSet();
                aFindVehicleMainByVehicleNumberTableAdapter = new FindVehicleMainByVehicleNumberDataSetTableAdapters.FindVehicleMainByVehicleNumberTableAdapter();
                aFindVehicleMainByVehicleNumberTableAdapter.Fill(aFindVehicleMainByVehicleNumberDataSet.FindVehicleMainByVehicleNumber, strVehicleNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Find Vehicle Main By Vehicle Number " + Ex.ToString());
            }

            return aFindVehicleMainByVehicleNumberDataSet;
        }
        public bool UpdateVehicleMainLocation(int intVehicleID, string strAssignedOffice)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateVehicleMainLocationTableAdapter = new UpdateVehicleMainLocationEntryTableAdapters.QueriesTableAdapter();
                aUpdateVehicleMainLocationTableAdapter.UpdateVehicleMainLocation(intVehicleID, strAssignedOffice);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Update Vehicle Main Location " + Ex.ToString());

                blnFatalError = true;
            }
            return blnFatalError;
        }
        public FindActiveVehicleMainByLocationDataSet FindActiveVehicleMainByLocation(string strAssignedOffice)
        {
            try
            {
                aFindActiveVehicleMainByLocationDataSet = new FindActiveVehicleMainByLocationDataSet();
                aFindActiveVehicleMainByLocationTableAdapter = new FindActiveVehicleMainByLocationDataSetTableAdapters.FindActiveVehicleMainByLocationTableAdapter();
                aFindActiveVehicleMainByLocationTableAdapter.Fill(aFindActiveVehicleMainByLocationDataSet.FindActiveVehicleMainByLocation, strAssignedOffice);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Find Active Vehicle Main By Location " + Ex.ToString());
            }

            return aFindActiveVehicleMainByLocationDataSet;
        }
        public FindVehicleMainByVINNumberDataSet FindVehicleMainByVINNumber(string strVINNumber)
        {
            try
            {
                aFindVehicleMainByVINNumberDataSet = new FindVehicleMainByVINNumberDataSet();
                aFindVehicleMainByVINNumberTableAdapter = new FindVehicleMainByVINNumberDataSetTableAdapters.FindVehicleMainByVINNumberTableAdapter();
                aFindVehicleMainByVINNumberTableAdapter.Fill(aFindVehicleMainByVINNumberDataSet.FindVehicleMainByVINNumber, strVINNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehlcle Main Class // Find Vehicle Main By VIN Number " + Ex.ToString());
            }

            return aFindVehicleMainByVINNumberDataSet;
        }
        public FindActiveVehicleMainShortVehicleNumberDataSet FindActiveVehicleMainShortVehicleNumber(string strVehicleNumber)
        {
            try
            {
                aFindActiveVehicleMainShortVehicleNumberDataSet = new FindActiveVehicleMainShortVehicleNumberDataSet();
                aFindActiveVehicleMainShortVehlcleNumberTableAdapter = new FindActiveVehicleMainShortVehicleNumberDataSetTableAdapters.FindActiveVehicleMainShortVehicleNumberTableAdapter();
                aFindActiveVehicleMainShortVehlcleNumberTableAdapter.Fill(aFindActiveVehicleMainShortVehicleNumberDataSet.FindActiveVehicleMainShortVehicleNumber, strVehicleNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Find Active Vehicle Main Short Vehicle Number " + Ex.ToString());
            }

            return aFindActiveVehicleMainShortVehicleNumberDataSet;
        }
        public FindVehicleMainForAssignedOfficeDataSet FindVehicleMainForAssignedOffice(string strAssignedOffice)
        {
            try
            {
                aFindVehicleMainForAssignedOfficeDataSet = new FindVehicleMainForAssignedOfficeDataSet();
                aFindVehicleMainForAssignedOfficeTableAdapter = new FindVehicleMainForAssignedOfficeDataSetTableAdapters.FindVehicleMainForAssignedOfficeTableAdapter();
                aFindVehicleMainForAssignedOfficeTableAdapter.Fill(aFindVehicleMainForAssignedOfficeDataSet.FindVehicleMainForAssignedOffice, strAssignedOffice);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Find Vehicle Main For Assigned Office " + Ex.ToString());
            }

            return aFindVehicleMainForAssignedOfficeDataSet;
        }
        public FindAvailableVehiclesDataSet FindAvailableVehicles()
        {
            try
            {
                aFindAvailableVehiclesDataSet = new FindAvailableVehiclesDataSet();
                aFindAvailableVehiclesTableAdapter = new FindAvailableVehiclesDataSetTableAdapters.FindAvailableVehiclesTableAdapter();
                aFindAvailableVehiclesTableAdapter.Fill(aFindAvailableVehiclesDataSet.FindAvailableVehicles);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Find Available Vehicles " + Ex.Message);
            }

            return aFindAvailableVehiclesDataSet;
        }
        public FindVehicleMainByDeactiveEmployeesDataSet FindVehicleMainByDeactiveEmployees()
        {
            try
            {
                aFindVehicleMainByDeactiveEmployeesDataSet = new FindVehicleMainByDeactiveEmployeesDataSet();
                aFindVehicleMainbyDeactiveEmployeesTableAdapter = new FindVehicleMainByDeactiveEmployeesDataSetTableAdapters.FindVehicleMainByDeactiveEmployeesTableAdapter();
                aFindVehicleMainbyDeactiveEmployeesTableAdapter.Fill(aFindVehicleMainByDeactiveEmployeesDataSet.FindVehicleMainByDeactiveEmployees);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Find Vehicle Main By Deactive Employees " + Ex.ToString());
            }

            return aFindVehicleMainByDeactiveEmployeesDataSet;
        }
        public FindActiveVehicleMainSortedDataSet FindActiveVehicleMainSorted()
        {
            try
            {
                aFindActiveVehicleMainSortedDataSet = new FindActiveVehicleMainSortedDataSet();
                aFindActiveVehicleMainSortedTableAdapter = new FindActiveVehicleMainSortedDataSetTableAdapters.FindActiveVehicleMainSortedTableAdapter();
                aFindActiveVehicleMainSortedTableAdapter.Fill(aFindActiveVehicleMainSortedDataSet.FindActiveVehicleMainSorted);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Video Main Class // Find Active Vehicle Main Sorted " + Ex.ToString());
            }

            return aFindActiveVehicleMainSortedDataSet;
        }
        public FindVehicleAssignedByEmployeeIDDataSet FindVehicleAssignedByEmployeeID(int intEmployeeID)
        {
            try
            {
                aFindVehicleAssignedByEmployeeIDDataSet = new FindVehicleAssignedByEmployeeIDDataSet();
                aFindVehicleAssignedByEmployeeIDTableAdapter = new FindVehicleAssignedByEmployeeIDDataSetTableAdapters.FindVehicleAssignedByEmployeeIDTableAdapter();
                aFindVehicleAssignedByEmployeeIDTableAdapter.Fill(aFindVehicleAssignedByEmployeeIDDataSet.FindVehicleAssignedByEmployeeID, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Find Vehicle Assigned By Employee ID " + Ex.ToString());
            }

            return aFindVehicleAssignedByEmployeeIDDataSet;
        }
        public FindVehicleMainForUnretirementDataSet FindVehicleMainForUnretirment(string strVehicleNumber)
        {
            try
            {
                aFindVehicleMainForUnretirementDataSet = new FindVehicleMainForUnretirementDataSet();
                aFindVehicleMainForUnretirementTableAdapter = new FindVehicleMainForUnretirementDataSetTableAdapters.FindVehicleMainForUnretirementTableAdapter();
                aFindVehicleMainForUnretirementTableAdapter.Fill(aFindVehicleMainForUnretirementDataSet.FindVehicleMainForUnretirement, strVehicleNumber);
            }
            catch(Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Find Vehicle Main For Unretirement " + Ex.ToString());
            }

            return aFindVehicleMainForUnretirementDataSet;
        }
        public bool UpdateVehicleMainActive(int intVehicleID, bool blnActive)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateVehicleMainActiveTableAdapter = new UpdateVehicleMainActiveEntryTableAdapters.QueriesTableAdapter();
                aUpdateVehicleMainActiveTableAdapter.UpdateVehicleMainActive(intVehicleID, blnActive);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Update Vehicle Main Active " + Ex.ToString());
            }

            return blnFatalError;
        }
        public bool UpdateMainOilChangeInformation(int intVehicleID, int intOilChangeOdometer, DateTime datTransactionDate)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateMainOilChangeInformationTableAdapter = new UpdateMainOilChangeInformationEntryTableAdapters.QueriesTableAdapter();
                aUpdateMainOilChangeInformationTableAdapter.UpdateMainOilChangeInformation(intVehicleID, intOilChangeOdometer, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Update Oil Change Information " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateVehicleMainEdit(int intVehicleID, string strLicensePlate, int intOilChangeOdometer, DateTime datOilChangeDate, string strVINNNumber, string strNotes, bool blnActive, string strAssignedOffice)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateVehicleMainEditTableAdapter = new UpdateVehicleMainEditEntryTableAdapters.QueriesTableAdapter();
                aUpdateVehicleMainEditTableAdapter.UpdateVehicleMainEdit(intVehicleID, strLicensePlate, intOilChangeOdometer, datOilChangeDate, strVINNNumber, strNotes, blnActive, strAssignedOffice);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Update Vehicle Main Edit " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindVehicleMainByLicensePlateDataSet FindVehicleMainByLicensePlate(string strLicensePlate)
        {
            try
            {
                aFindVehicleMainByLicensePlateDataSet = new FindVehicleMainByLicensePlateDataSet();
                aFindVehicleMainByLicensePlateTableAdapter = new FindVehicleMainByLicensePlateDataSetTableAdapters.FindVehicleMainByLicensePlateTableAdapter();
                aFindVehicleMainByLicensePlateTableAdapter.Fill(aFindVehicleMainByLicensePlateDataSet.FindVehicleMainByLicensePlate, strLicensePlate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Find Vehicle Main By License Plate " + Ex.ToString());
            }

            return aFindVehicleMainByLicensePlateDataSet;
        }
        public FindVehicleMainByVehicleIDDataSet FindVehicleMainByVehicleID(int intVehicleID)
        {
            try
            {
                aFindVehicleMainByVehicleIDDataSet = new FindVehicleMainByVehicleIDDataSet();
                aFindVehicleMainByVehicleIDTableAdapter = new FindVehicleMainByVehicleIDDataSetTableAdapters.FindVehicleMainByVehicleIDTableAdapter();
                aFindVehicleMainByVehicleIDTableAdapter.Fill(aFindVehicleMainByVehicleIDDataSet.FindVehicleMainByVehicleID, intVehicleID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Find Vehicle Main By Vehicle ID " + Ex.ToString());
            }

            return aFindVehicleMainByVehicleIDDataSet;
        }
        public bool UpdatevehicleMainAvailable(int intVehicleID, bool blnAvailable)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateVehicleMainAvailableTableAdapter = new UpdateVehicleMainAvailableEntryTableAdapters.QueriesTableAdapter();
                aUpdateVehicleMainAvailableTableAdapter.UpdateVehicleMainAvailable(intVehicleID, blnAvailable);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Update Vehicle Main Available " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateVehicleMainEmployeeID(int intVehicleID, int intEmployeeID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateVehicleMainEmployeeIDTableAdapter = new UpdateVehicleMainEmployeeIDEntryTableAdapters.QueriesTableAdapter();
                aUpdateVehicleMainEmployeeIDTableAdapter.UpdateVehicleMainEmployeeID(intVehicleID, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Update Vehicle Main Employee ID " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindActiveVehicleMainDataSet FindActiveVehicleMain()
        {
            try
            {
                aFindActiveVehicleMainDataSet = new FindActiveVehicleMainDataSet();
                aFindActiveVehicleMainTableAdpater = new FindActiveVehicleMainDataSetTableAdapters.FindActiveVehicleMainTableAdapter();
                aFindActiveVehicleMainTableAdpater.Fill(aFindActiveVehicleMainDataSet.FindActiveVehicleMain);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Find Active Vehicle Main " + Ex.ToString());
            }

            return aFindActiveVehicleMainDataSet;
        }
        public FindActiveVehicleMainByVehicleNumberDataSet FindActiveVehicleMainByVehicleNumber(string strVehicleNumber)
        {
            try
            {
                aFindActiveVehicleMainByVehicleNumberDataSet = new FindActiveVehicleMainByVehicleNumberDataSet();
                aFindActiveVehicleMainByVehicleNumberTableAdapter = new FindActiveVehicleMainByVehicleNumberDataSetTableAdapters.FindActiveVehicleMainByVehicleNumberTableAdapter();
                aFindActiveVehicleMainByVehicleNumberTableAdapter.Fill(aFindActiveVehicleMainByVehicleNumberDataSet.FindActiveVehicleMainByVehicleNumber, strVehicleNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Find Active Vehicle Main By Vehicle Number " + Ex.ToString());
            }

            return aFindActiveVehicleMainByVehicleNumberDataSet;
        }
        public VehicleAssignmentDataSet GetVehicleAssigmentInfo()
        {
            try
            {
                aVehicleAssignmentDataSet = new VehicleAssignmentDataSet();
                aVehicleAssignmentTableAdapter = new VehicleAssignmentDataSetTableAdapters.vehicleassignmentTableAdapter();
                aVehicleAssignmentTableAdapter.Fill(aVehicleAssignmentDataSet.vehicleassignment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "New Vehicle DLL // Get Vehicle Assignment Info " + Ex.ToString());
            }

            return aVehicleAssignmentDataSet;
        }
        public void UpdateVehicleAssignmentDB(VehicleAssignmentDataSet aVehicleAssignmentDataSet)
        {
            try
            {
                aVehicleAssignmentTableAdapter = new VehicleAssignmentDataSetTableAdapters.vehicleassignmentTableAdapter();
                aVehicleAssignmentTableAdapter.Update(aVehicleAssignmentDataSet.vehicleassignment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "New Vehicle DLL // Update Vehicle Assignment DB " + Ex.ToString());
            }
        }
        public int CreateVehicleID()
        {
            int intVehicleID = 0;

            try
            {
                aVehicleIDDataSet = new VehicleIDDataSet();
                aVehicleIDTableAdapter = new VehicleIDDataSetTableAdapters.vehicleidTableAdapter();
                aVehicleIDTableAdapter.Fill(aVehicleIDDataSet.vehicleid);

                intVehicleID = aVehicleIDDataSet.vehicleid[0].VehicleID;
                intVehicleID++;

                aVehicleIDDataSet.vehicleid[0].VehicleID = intVehicleID;
                aVehicleIDTableAdapter.Update(aVehicleIDDataSet.vehicleid);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "New Vehicle DLL // Create Vehicle ID " + Ex.ToString());
            }

            return intVehicleID;
        }
        public bool InsertVehicleMain(int intVehicleID, string strVehicleNumber, int intVehicleYear, string strVehicleMake, string strVehicleModel, string strLicensePlate, string strVINNumber, int intOilChangeOdometer, DateTime datOilChangeDate, int intEmployeeID, string strNotes, string strAssignedOffice)
        {
            bool blnFatalError = false;

            try
            {
                aInsertVehicleMainTableAdapter = new InsertVehicleMainEntryTableAdapters.QueriesTableAdapter();
                aInsertVehicleMainTableAdapter.InsertVehicleMain(intVehicleID, strVehicleNumber, intVehicleYear, strVehicleMake, strVehicleModel, strLicensePlate, strVINNumber, intOilChangeOdometer, datOilChangeDate, intEmployeeID, strNotes, strAssignedOffice);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Insert Vehicle Main " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public VehicleMainDataSet GetVehicleMainInfo()
        {
            try
            {
                aVehicleMainDataSet = new VehicleMainDataSet();
                aVehicleMainTableAdpater = new VehicleMainDataSetTableAdapters.vehiclemainTableAdapter();
                aVehicleMainTableAdpater.Fill(aVehicleMainDataSet.vehiclemain);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Get Vehicle Main Info " + Ex.ToString());
            }

            return aVehicleMainDataSet;
        }
        public void UpdateVehicleMainDB(VehicleMainDataSet aVehicleMainDataSet)
        {
            try
            {
                aVehicleMainTableAdpater = new VehicleMainDataSetTableAdapters.vehiclemainTableAdapter();
                aVehicleMainTableAdpater.Update(aVehicleMainDataSet.vehiclemain);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Main Class // Update Vehicle Main DB " + Ex.ToString());
            }
        }
    }
}
