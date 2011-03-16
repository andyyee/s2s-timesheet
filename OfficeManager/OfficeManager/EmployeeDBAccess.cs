using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using OfficeManager.DBAccess;
using System.Drawing;

namespace OfficeManager.DBAccess
{
    public class EmployeeDBAccess
    {
#region Properties
        private String _userID;
        private String _firstName;
        private String _lastName;
        private String _middleName;
        private String _password;
        private String _homePhoneNumber;
        private String _cellPhoneNumber;
        private String _workPhoneNumber;
        private String _extension;
        private String _address1;
        private String _address2;
        private String _city;
        private String _state;
        private int _zipCode;
        private DateTime _birthDate;
        private string _gender;
        private int _ssn;
        private DateTime _startDate;
        private DateTime _endDate;
        private String _endReason;
        private String _endComments;
        private String _endApprover;
        private String _maritalStatus;
        private String _email;
        private int _jobID;
        private String _ecContact1Name;
        private String _ecContact1Relationship;
        private String _ecContact1Home;
        private String _ecContact1Work;
        private String _ecContact1Cell;
        private String _ecContact2Name;
        private String _ecContact2Relationship;
        private String _ecContact2Home;
        private String _ecContact2Work;
        private String _ecContact2Cell;
        private Image _image;

        public String userID
        {
            get
            {
                return _userID;
            }
            set
            {
                if (_userID == value)
                    return;
                _userID = value;
            }
        }
        public String firstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (_firstName == value)
                    return;
                _firstName = value;
            }
        }
        public String lastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (_lastName == value)
                    return;
                _lastName = value;
            }
        }
        public String middleName
        {
            get
            {
                return _middleName;
            }
            set
            {
                if (_middleName == value)
                    return;
                _middleName = value;
            }
        }
        public String password
        {
            get
            {
                return _password;
            }
            set
            {
                if (_password == value)
                    return;
                _password = value;
            }
        }
        public String homePhoneNumber
        {
            get
            {
                return _homePhoneNumber;
            }
            set
            {
                if (_homePhoneNumber == value)
                    return;
                _homePhoneNumber = value;
            }
        }
        public String cellPhoneNumber
        {
            get
            {
                return _cellPhoneNumber;
            }
            set
            {
                if (_cellPhoneNumber == value)
                    return;
                _cellPhoneNumber = value;
            }
        }
        public String workPhoneNumber
        {
            get
            {
                return _workPhoneNumber;
            }
            set
            {
                if (_workPhoneNumber == value)
                    return;
                _workPhoneNumber = value;
            }
        }
        public String extension
        {
            get
            {
                return _extension;
            }
            set
            {
                if (_extension == value)
                    return;
                _extension = value;
            }
        }
        public String address1
        {
            get
            {
                return _address1;
            }
            set
            {
                if (_address1 == value)
                    return;
                _address1 = value;
            }
        }
        public String address2
        {
            get
            {
                return _address2;
            }
            set
            {
                if (_address2 == value)
                    return;
                _address2 = value;
            }
        }
        public String city
        {
            get
            {
                return _city;
            }
            set
            {
                if (_city == value)
                    return;
                _city = value;
            }
        }
        public String state
        {
            get
            {
                return _state;
            }
            set
            {
                if (_state == value)
                    return;
                _state = value;
            }
        }
        public int zipCode
        {
            get
            {
                return _zipCode;
            }
            set
            {
                if (_zipCode == value)
                    return;
                _zipCode = value;
            }
        }
        public DateTime birthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                if (_birthDate == value)
                    return;
                _birthDate = value;
            }
        }
        public string gender
        {
            get
            {
                return _gender;
            }
            set
            {
                if (_gender == value)
                    return;
                _gender = value;
            }
        }
        public int ssn
        {
            get
            {
                return _ssn;
            }
            set
            {
                if (_ssn == value)
                    return;
                _ssn = value;
            }
        }
        public DateTime startDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                if (_startDate == value)
                    return;
                _startDate = value;
            }
        }
        public DateTime endDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                if (_endDate == value)
                    return;
                _endDate = value;
            }
        }
        public String endReason
        {
            get
            {
                return _endReason;
            }
            set
            {
                if (_endReason == value)
                    return;
                _endReason = value;
            }
        }
        public String endComments
        {
            get
            {
                return _endComments;
            }
            set
            {
                if (_endComments == value)
                    return;
                _endComments = value;
            }
        }
        public String endApprover
        {
            get
            {
                return _endApprover;
            }
            set
            {
                if (_endApprover == value)
                    return;
                _endApprover = value;
            }
        }
        public String maritalStatus
        {
            get
            {
                return _maritalStatus;
            }
            set
            {
                if (_maritalStatus == value)
                    return;
                _maritalStatus = value;
            }
        }
        public String email
        {
            get
            {
                return _email;
            }
            set
            {
                if (_email == value)
                    return;
                _email = value;
            }
        }
        public int jobID
        {
            get
            {
                return _jobID;
            }
            set
            {
                if (_jobID == value)
                    return;
                _jobID = value;
            }
        }
        public String ecContact1Name
        {
            get
            {
                return _ecContact1Name;
            }
            set
            {
                if (_ecContact1Name == value)
                    return;
                _ecContact1Name = value;
            }
        }
        public String ecContact1Relationship
        {
            get
            {
                return _ecContact1Relationship;
            }
            set
            {
                if (_ecContact1Relationship == value)
                    return;
                _ecContact1Relationship = value;
            }
        }
        public String ecContact1Home
        {
            get
            {
                return _ecContact1Home;
            }
            set
            {
                if (_ecContact1Home == value)
                    return;
                _ecContact1Home = value;
            }
        }
        public String ecContact1Work
        {
            get
            {
                return _ecContact1Work;
            }
            set
            {
                if (_ecContact1Work == value)
                    return;
                _ecContact1Work = value;
            }
        }
        public String ecContact1Cell
        {
            get
            {
                return _ecContact1Cell;
            }
            set
            {
                if (_ecContact1Cell == value)
                    return;
                _ecContact1Cell = value;
            }
        }
        public String ecContact2Name
        {
            get
            {
                return _ecContact2Name;
            }
            set
            {
                if (_ecContact2Name == value)
                    return;
                _ecContact2Name = value;
            }
        }
        public String ecContact2Relationship
        {
            get
            {
                return _ecContact2Relationship;
            }
            set
            {
                if (_ecContact2Relationship == value)
                    return;
                _ecContact2Relationship = value;
            }
        }
        public String ecContact2Home
        {
            get
            {
                return _ecContact2Home;
            }
            set
            {
                if (_ecContact2Home == value)
                    return;
                _ecContact2Home = value;
            }
        }
        public String ecContact2Work
        {
            get
            {
                return _ecContact2Work;
            }
            set
            {
                if (_ecContact2Work == value)
                    return;
                _ecContact2Work = value;
            }
        }
        public String ecContact2Cell
        {
            get
            {
                return _ecContact2Cell;
            }
            set
            {
                if (_ecContact2Cell == value)
                    return;
                _ecContact2Cell = value;
            }
        }

        public Image image
        {
            get
            {
                return _image;
            }
            set
            {
                if (_image == value)
                    return;
                _image = value;
            }
        }
        


#endregion
        public static SqlCommand SQLCommandBlank = new SqlCommand(" ");

        public EmployeeDBAccess()
        {

        }

        //Use this constructor when you plan on saving an employee record to the database.
        public EmployeeDBAccess(Employee employee)
        {
            this.userID = employee.userID;
            this.firstName = employee.firstName;
            this.middleName = employee.middleName;
            this.lastName = employee.lastName;
            this.password = employee.password;
            this._homePhoneNumber = employee.homePhoneNumber;
            this._cellPhoneNumber = employee.cellPhoneNumber;
            this._workPhoneNumber = employee.workPhoneNumber;
            this._extension = employee.extension;
            this._address1 = employee.address1;
            this._address2 = employee.address2;
            this._city = employee.city;
            this._state = employee.state;
            this._zipCode = employee.zipCode;
            this._birthDate = employee.birthDate;
            this._gender = employee.gender;
            this._ssn = employee.ssn;
            this._startDate = employee.startDate;
            this._endDate = employee.endDate;
            this._endReason = employee.endReason;
            this._endComments = employee.endComments;
            this._endApprover = employee.endApprover;
            this._maritalStatus = employee.maritalStatus;
            this._email = employee.email;
            this._jobID = employee.jobID;
            this._ecContact1Name = employee.ecContact1Name;
            this.ecContact1Relationship = employee.ecContact1Relationship;
            this._ecContact1Home = employee.ecContact1Home;
            this._ecContact1Cell = employee.ecContact1Cell;
            this._ecContact1Work = employee.ecContact1Work;
            this._ecContact2Name =  employee.ecContact2Name;
            this.ecContact2Relationship = employee.ecContact2Relationship;
            this._ecContact2Home = employee.ecContact2Home;
            this._ecContact2Cell = employee.ecContact2Cell;
            this._ecContact2Work = employee.ecContact2Work;
            this._image = employee.image;

        }

        public static String GetEmployeeName(String userID)
        {
            SqlConnection cConnection = null;
            SqlDataAdapter cDataAdapter = null;
            DataSet cDataSet = null;
            
            try
            {
                String sSQL;

                cConnection = OfficeManager.DBAccess.SqlADO.GetConnection();

                sSQL = "SELECT first_name, last_name ";
                sSQL = sSQL + "FROM Employee ";
                sSQL = sSQL + "WHERE user_id = " + userID.ToString();

                cDataSet = OfficeManager.DBAccess.SqlADO.RunQuery(ref cConnection, ref cDataAdapter, sSQL, SQLCommandBlank, 
                    SQLCommandBlank, SQLCommandBlank);

                if (cDataSet.Tables[0].Rows.Count == 0)
                {
                    return String.Empty;
                }

                else
                {
                    String name= cDataSet.Tables[0].Rows[0]["first_name"].ToString() + " " +
                    cDataSet.Tables[0].Rows[0]["last_name"].ToString();

                    return name;
                } 

            }

            catch
            {
                throw new ApplicationException();
            }
        }

        public static String GetEmployeeFirstName(String userID)
        {
            SqlConnection cConnection = null;
            SqlDataAdapter cDataAdapter = null;
            DataSet cDataSet = null;

            try
            {
                String sSQL;

                cConnection = OfficeManager.DBAccess.SqlADO.GetConnection();

                sSQL = "SELECT first_name ";
                sSQL = sSQL + "FROM Employee ";
                sSQL = sSQL + "WHERE user_id = " + userID.ToString();

                cDataSet = OfficeManager.DBAccess.SqlADO.RunQuery(ref cConnection, ref cDataAdapter, sSQL, SQLCommandBlank,
                    SQLCommandBlank, SQLCommandBlank);

                if (cDataSet.Tables[0].Rows.Count == 0)
                {
                    return String.Empty;
                }

                else
                {
                    String firstName = cDataSet.Tables[0].Rows[0]["first_name"].ToString();

                    return firstName;
                }

            }

            catch
            {
                throw new ApplicationException();
            }
        }

        public static String GetEmployeeLastName(String userID)
        {
            SqlConnection cConnection = null;
            SqlDataAdapter cDataAdapter = null;
            DataSet cDataSet = null;

            try
            {
                String sSQL;

                cConnection = OfficeManager.DBAccess.SqlADO.GetConnection();

                sSQL = "SELECT last_name ";
                sSQL = sSQL + "FROM Employee ";
                sSQL = sSQL + "WHERE user_id = " + userID.ToString();

                cDataSet = OfficeManager.DBAccess.SqlADO.RunQuery(ref cConnection, ref cDataAdapter, sSQL, SQLCommandBlank,
                    SQLCommandBlank, SQLCommandBlank);

                if (cDataSet.Tables[0].Rows.Count == 0)
                {
                    return String.Empty;
                }

                else
                {
                    String lastName = cDataSet.Tables[0].Rows[0]["last_name"].ToString();

                    return lastName;
                }

            }

            catch
            {
                throw new ApplicationException();
            }
        }

        public static bool UserIDExists(String userID)
        {
            SqlConnection cConnection = null;
            SqlDataAdapter cDataAdapter = null;
            DataSet cDataSet = null;

            try
            {
                String sSQL;

                cConnection = OfficeManager.DBAccess.SqlADO.GetConnection();

                sSQL = "SELECT user_id ";
                sSQL = sSQL + "FROM Employee ";
                sSQL = sSQL + "WHERE user_id = '" + userID.ToString() + "' ";

                cDataSet = OfficeManager.DBAccess.SqlADO.RunQuery(ref cConnection, ref cDataAdapter, sSQL, SQLCommandBlank,
                    SQLCommandBlank, SQLCommandBlank);

                if (cDataSet.Tables[0].Rows.Count == 0)
                {
                    return false;
                }

                else
                {
                    return true;
                }

            }

            catch
            {
                throw new ApplicationException();
            }
        }

        public static String GetPassword(String userID)
        {
            SqlConnection cConnection = null;
            SqlDataAdapter cDataAdapter = null;
            DataSet cDataSet = null;

            try
            {
                String sSQL;

                cConnection = OfficeManager.DBAccess.SqlADO.GetConnection();

                sSQL = "SELECT password ";
                sSQL = sSQL + "FROM Employee ";
                sSQL = sSQL + "WHERE user_id = " + userID.ToString();

                cDataSet = OfficeManager.DBAccess.SqlADO.RunQuery(ref cConnection, ref cDataAdapter, sSQL, SQLCommandBlank,
                    SQLCommandBlank, SQLCommandBlank);

                if (cDataSet.Tables[0].Rows.Count == 0)
                {
                    return String.Empty;
                }

                else
                {
                    String password = cDataSet.Tables[0].Rows[0]["password"].ToString();

                    return password;
                }

            }

            catch
            {
                throw new ApplicationException();
            }
        }

        public static void SetPassword(String userID, String password)
        {
            SqlConnection cConnection = null;
            SqlDataAdapter cDataAdapter = null;
            DataSet cDataSet = null;

            try
            {
                String sSQL;

                cConnection = OfficeManager.DBAccess.SqlADO.GetConnection();

                sSQL = "UPDATE Employee ";
                sSQL = sSQL + "SET password = '" + password + "' ";
                sSQL = sSQL + "WHERE user_id = " + userID.ToString();

                cDataSet = OfficeManager.DBAccess.SqlADO.RunQuery(ref cConnection, ref cDataAdapter, sSQL, null,
                   null, null);

            }

            catch
            {
                throw new ApplicationException();
            }
        }


        public void SaveRecord()
        {
            SqlConnection cConnection = null;
            SqlDataAdapter cDataAdapter = null;
            DataSet cDataSet = null;
            DataRow oRow = null;

            try
            {
                String sSQL;

                cConnection = OfficeManager.DBAccess.SqlADO.GetConnection();

                sSQL = "SELECT * ";
                sSQL = sSQL + "FROM Employee ";
                sSQL = sSQL + "WHERE user_id = " + userID.ToString();

                cDataSet = OfficeManager.DBAccess.SqlADO.RunQuery(ref cConnection, ref cDataAdapter, sSQL, null,
                    null, null);

                if (cDataSet.Tables[0].Rows.Count == 0)
                {
                    oRow = cDataSet.Tables[0].NewRow();

                    cDataSet.Tables[0].Rows.Add(oRow);
                }

                else
                {
                    oRow = cDataSet.Tables[0].Rows[0];
                }

                oRow["user_id"] = this._userID;
                oRow["first_name"] = this._firstName;
                oRow["middle_name"] = this._middleName;
                oRow["last_name"] = this._lastName;
                oRow["password"] = this._password;
                oRow["home_phone_number"] = this._homePhoneNumber;
                oRow["cell_phone_number"] = this._cellPhoneNumber;
                oRow["work_phone_number"] = this._workPhoneNumber;
                oRow["extension"] = this._extension;
                oRow["address1"] = this._address1;
                oRow["address2"] = this._address2;
                oRow["city"] = this._city;
                oRow["state"] = this._state;
                oRow["zip_code"] = this._zipCode;
                oRow["birth_date"] = this._birthDate;
                oRow["gender"] = this._gender;
                oRow["ssn"] = this._ssn;
                oRow["start_date"] = this._startDate;
                oRow["end_date"] = this._endDate;
                oRow["end_reason"] = this._endReason;
                oRow["end_comments"] = this._endComments;
                oRow["end_approver"] = this._endApprover;
                oRow["marital_status"] = this._maritalStatus;
                oRow["email_work"] = this._email;
                oRow["job_id"] = this._jobID;
                oRow["contact1_name"] = this._ecContact1Name;
                oRow["contact1_relationship"] = this.ecContact1Relationship;
                oRow["contact1_home"] = this._ecContact1Home;
                oRow["contact1_cell"] = this._ecContact1Cell;
                oRow["contact1_work"] = this._ecContact1Work;
                oRow["contact2_name"] = this._ecContact2Name;
                oRow["contact2_relationship"] = this.ecContact2Relationship;
                oRow["contact2_home"] = this._ecContact2Home;
                oRow["contact2_cell"] = this._ecContact2Cell;
                oRow["contact2_work"] = this._ecContact2Work;
                oRow["image"] = this._image;


                cDataAdapter.Update(cDataSet);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new ApplicationException();
            }
        }

        //Returns an employee object with a userID equal to String.Empty if there is no record for the given userID.
        //Returns an employee object with each field filled if there is a record for the given userID.
        public Employee GetRecord(String userID)
        {
            SqlConnection cConnection = null;
            SqlDataAdapter cDataAdapter = null;
            DataSet cDataSet = null;
            DataRow oRow = null;
            Employee employee = new Employee();

            try
            {
                String sSQL;

                cConnection = OfficeManager.DBAccess.SqlADO.GetConnection();

                sSQL = "SELECT * ";
                sSQL = sSQL + "FROM Employee ";
                sSQL = sSQL + "WHERE user_id = " + userID.ToString();

                cDataSet = OfficeManager.DBAccess.SqlADO.RunQuery(ref cConnection, ref cDataAdapter, sSQL, SQLCommandBlank,
                    SQLCommandBlank, SQLCommandBlank);

                //If there is no record associated with the given user ID.
                if (cDataSet.Tables[0].Rows.Count == 0)
                {
                    employee.userID = String.Empty;
                    return employee;
                }

                else
                {
                    oRow = cDataSet.Tables[0].Rows[0];

                    employee.firstName = oRow["first_name"].ToString();
                    employee.middleName = oRow["middle_name"].ToString();
                    employee.lastName = oRow["last_name"].ToString();
                    employee.password = oRow["password"].ToString();
                    employee.homePhoneNumber = oRow["home_phone_number"].ToString();
                    employee.cellPhoneNumber = oRow["cell_phone_number"].ToString();
                    employee.workPhoneNumber = oRow["work_phone_number"].ToString();
                    employee.extension = oRow["extension"].ToString();
                    employee.address1 = oRow["address1"].ToString();
                    employee.address2 = oRow["address2"].ToString();
                    employee.city = oRow["city"].ToString();
                    employee.state = oRow["state"].ToString();
                    employee.zipCode = System.Convert.ToInt32(oRow["zip_code"]);
                    employee.birthDate = System.Convert.ToDateTime(oRow["birth_date"]);
                    employee.gender = oRow["gender"].ToString();
                    employee.ssn = System.Convert.ToInt32(oRow["ssn"]);
                    employee.startDate = System.Convert.ToDateTime(oRow["start_date"]);
                    employee.endDate = System.Convert.ToDateTime(oRow["end_date"]);
                    employee.endReason = oRow["end_reason"].ToString();
                    employee.endComments = oRow["end_comments"].ToString();
                    employee.endApprover = oRow["end_approver"].ToString();
                    employee.maritalStatus = oRow["marital_status"].ToString();
                    employee.email = oRow["email_work"].ToString();
                    employee.jobID = System.Convert.ToInt32(oRow["job_id"]);
                    employee.ecContact1Name = oRow["contact1_name"].ToString();
                    employee.ecContact1Relationship = oRow["contact1_relationship"].ToString();
                    employee.ecContact1Home = oRow["contact1_home"].ToString();
                    employee.ecContact1Cell = oRow["contact1_cell"].ToString();
                    employee.ecContact1Work = oRow["contact1_work"].ToString();
                    employee.ecContact2Name = oRow["contact2_name"].ToString();
                    employee.ecContact2Relationship = oRow["contact2_relationship"].ToString();
                    employee.ecContact2Home = oRow["contact2_home"].ToString();
                    employee.ecContact2Cell = oRow["contact2_cell"].ToString();
                    employee.ecContact2Work = oRow["contact2_work"].ToString();
                    employee.image = (Image)oRow["image"];

                    return employee;
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new ApplicationException();
            }
        }

        public static bool PasswordMatches(String userID, String imp_password)
        {
            SqlConnection cConnection = null;
            SqlDataAdapter cDataAdapter = null;
            DataSet cDataSet = null;

            try
            {
                String sSQL;

                cConnection = OfficeManager.DBAccess.SqlADO.GetConnection();

                sSQL = "SELECT password ";
                sSQL = sSQL + "FROM Employee ";
                sSQL = sSQL + "WHERE user_id = " + userID.ToString();

                cDataSet = OfficeManager.DBAccess.SqlADO.RunQuery(ref cConnection, ref cDataAdapter, sSQL, SQLCommandBlank,
                    SQLCommandBlank, SQLCommandBlank);

                if (cDataSet.Tables[0].Rows.Count == 0)
                {
                    return false;
                }

                else
                {
                    String password = cDataSet.Tables[0].Rows[0]["password"].ToString();

                    if (password.CompareTo(imp_password) == 0)
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }

            }

            catch
            {
                throw new ApplicationException();
            }
        }


        /*
        public static void Main(String[] args)
        {
            try
            {

                Employee myTestObject = new Employee();

                myTestObject.userID = "3";
                myTestObject.firstName = "Michael";
                myTestObject.lastName = "Mazza";
                myTestObject.middleName = "James";
                myTestObject.password = "Spicy";
                myTestObject.homePhoneNumber = "407-856-9335";
                myTestObject.cellPhoneNumber = "407-460-8883";
                myTestObject.address1 = "3724 Hunters Isle Drive";
                myTestObject.city = "Orlando";
                myTestObject.state = "FL";
                myTestObject.zipCode = 32837;
                myTestObject.gender = "Male";
                myTestObject.ssn = 555;
                myTestObject.jobID = 6;
                myTestObject.birthDate = System.Convert.ToDateTime("1961-06-01");

                EmployeeDBAccess dbAccessTest = new EmployeeDBAccess(myTestObject);
                dbAccessTest.SaveRecord();


                


            }

            catch (SqlException e)
            {
                MessageBox.Show(String.Format("Error accessing the database: {0}", e.Message));
            }

        }
         */
    }
}
