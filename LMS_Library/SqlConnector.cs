using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace LMS_Library
{
    public class SqlConnector
    {
        public static string connectionString = "Server=DESKTOP-NIPH6M9\\SQLEXPRESS;Database=LMS_DB;Trusted_Connection=True;";

        private SqlConnection connection = new SqlConnection();
        private SqlCommand command = new SqlCommand();
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlDataReader reader;
        private SqlTransaction dbTrasaction;
        private string sqlQuery,output="";
        


            //TODO - Create Connection
            //create function that reads login data from the database and store it in LoginModel
            public SqlConnector()
            {

            }
            public void createConn()
            {

                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.ConnectionString = connectionString;
                        connection.Open();
                    }


                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public void closeConn()
            {
                connection.Close();
                //MessageBox.Show("Connection CLosed");
            }

            public void readDataThroughAdapter(string query, DataTable tableName)
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        createConn();
                    }
                    command.Connection = connection;
                    command.CommandText = query;
                    command.CommandType = CommandType.Text;

                    adapter = new SqlDataAdapter(command);
                    adapter.Fill(tableName);


                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        //TODO - Execute Query and read data from database
        public class InsertData : SqlConnector
        {

            public int login(string username, string password, string type)
            {
                string user_db, pass_db, type_db;
                //string query; 
                //if(type == 'admin')
                //{
                //    query = "SELECT * FROM Login WHERE Type = 'admin'";

                //}
                int ID = 0;
                LoginModel lm = new LoginModel();
                createConn();
                sqlQuery = "Select * from Login WHERE username = '" + username +
                    "' AND password = '" + password +
                    "' AND Type = '" + type + "'";
                try 
                {

                command = new SqlCommand(sqlQuery, connection);
                reader = command.ExecuteReader();
                
                    reader.Read();
                    ID = int.Parse(reader[0].ToString());

                    //MessageBox.Show(reader.GetValue(0) + "-" + reader.GetValue(1) + "-" + reader.GetValue(2) + "-" + reader.GetValue(3));

                    //closeConn();
                    //if (user_db == username
                    //    && pass_db == password
                    //    && type_db == type)
                    //{
                    //    closeConn();
                    //    return true;
                        //output = reader.GetValue(0) + " - " + reader.GetValue(1) + " - " + reader.GetValue(2);
                        //MessageBox.Show(output);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Invalid Login Attempt");
                    //    closeConn();
                    //    return false;
                    //}
                    //MessageBox.Show($"UserName:{username} Password: {password} Type{type}");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception\r\n" + e.Message);
                }
                closeConn();
                return ID;
            }
            public bool AddClass(ClassModel cm)
            {
                createConn();
                try
                {
                    command = new SqlCommand("Class_Insert", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Semester", cm.Semester);
                    command.Parameters.AddWithValue("@Section", cm.Section);
                    command.Parameters.AddWithValue("@Department", cm.Department);

                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                closeConn();
                return false;
            }
            public void AddStudent(StudentModel std)
            {
                createConn();
                try
                {
                    command = new SqlCommand("Student_Insert", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", std.FirstName);
                    command.Parameters.AddWithValue("@LastName", std.LastName);
                    command.Parameters.AddWithValue("@FatherName", std.FatherName);
                    command.Parameters.AddWithValue("@Contact", std.Contact);
                    command.Parameters.AddWithValue("@Email", std.Email);
                    command.Parameters.AddWithValue("@DepName", std.Department);
                    command.Parameters.AddWithValue("@Semester", std.Semester);
                    command.Parameters.AddWithValue("@Section", std.Section);

                    command.ExecuteNonQuery();


                    MessageBox.Show("Successfully Submitted");

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                closeConn();
            }
            public void AddCourse(CourseModel cm)
            {
                createConn();
                try
                {
                    command = new SqlCommand("Course_Insert", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CourseCode", cm.CourseCode);
                    command.Parameters.AddWithValue("@Title", cm.Title);
                    command.Parameters.AddWithValue("@Department", cm.Department);

                    command.ExecuteNonQuery();
                    MessageBox.Show("SUCCESS");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                closeConn();
            }
            public void AddTeacher(TeacherModel tm)
            {
                //            nvarchar(30),
                //@LastName nvarchar(30),
                //@Contact nvarchar(20),
                //@Email nvarchar(50),
                //@Qualification nvarchar(30),
                //@JoinDate date,
                //   @Department nvarchar(30),
                //@Salary decimal(18, 0),
                //@Address nvarchar(200)try{
                createConn();
                try
                {
                    command = new SqlCommand("spLogin_Insert", connection);

                    command.CommandType = CommandType.StoredProcedure;

                    //SqlParameter login_id_param = new SqlParameter("@id", SqlDbType.Int);
                    //login_id_param.Direction = ParameterDirection.Output;
                    //command.Parameters.Add(login_id_param);
                    command.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;

                    command.Parameters.Add("@username", SqlDbType.NVarChar).Value = tm.username;
                    command.Parameters.Add("@password", SqlDbType.NVarChar).Value = tm.password;
                    //command.Parameters.AddWithValue("@password", tm.password);
                    //command.Parameters.AddWithValue("@username", tm.username);
                    command.Parameters.Add("@type", SqlDbType.NVarChar).Value = "teacher";
                    command.ExecuteNonQuery();
                    //int loginID = (int)login_id_param.Value;
                    int loginID = int.Parse(command.Parameters["@id"].Value.ToString());

                    MessageBox.Show("Login ID = " + loginID.ToString());

                    command = new SqlCommand("teacher_insert", connection);
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@firstname", tm.FirstName);
                    command.Parameters.AddWithValue("@lastname", tm.LastName);
                    command.Parameters.AddWithValue("@contact", tm.Contact);
                    command.Parameters.AddWithValue("@email", tm.Email);
                    command.Parameters.AddWithValue("@qualification", tm.Qualification);
                    //  command.Parameters.AddWithValue("@joindate", tm.JoinDate);
                    command.Parameters.AddWithValue("@department", tm.Department);
                    //   command.Parameters.AddWithValue("@salary", tm.Salary);
                    command.Parameters.AddWithValue("@address", tm.Address);
                    command.Parameters.AddWithValue("@cnic", tm.CNIC);

                    command.Parameters.AddWithValue("@LoginID", loginID);

                    command.ExecuteNonQuery();


                    MessageBox.Show("Successfully Submitted");

                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }

                closeConn();
            }

            public void AllocateCourse(int teacher_ID, int class_ID, string course_ID)
            {
                createConn();
                try
                {
                    command = new SqlCommand("AllocateClass", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("TID", teacher_ID);
                    command.Parameters.AddWithValue("CID", class_ID);
                    command.Parameters.AddWithValue("CrID", course_ID);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Data Added Successfully");
                }
                catch (Exception e)
                {
                    MessageBox.Show("OHOOO\r\n" + e.Message);
                }
                closeConn();
            }

            public bool UploadMaterial(MaterialModel m)
            {
                createConn();
                try
                {
                    string description = m.Description;
                    string fileName = m.Name;
                    byte[] bytes = m.data;
                    // string contentType = "";

                    string type = m.type;
                    int ccid = m.class_ID;

                    command = new SqlCommand("spMaterial_Upload", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@type",SqlDbType.NVarChar).Value = type;
                    command.Parameters.Add("@data",SqlDbType.VarBinary).Value = bytes;
                    command.Parameters.Add("@Name",SqlDbType.NVarChar).Value = fileName;
                    command.Parameters.Add("@description",SqlDbType.NVarChar).Value = description;
                    command.Parameters.Add("@ClassID",SqlDbType.Int).Value = ccid;
                    command.ExecuteNonQuery();
                    closeConn();
                    return true;

                }
                catch(Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }
         
        public class GetData:SqlConnector
        {
            /// <summary>
            /// Get Courses by department
            /// </summary>
            /// <param name="dep"></param>
            /// <returns></returns>
            public List<CourseModel> GetCourses(string dep)
            {
                List<CourseModel> lcm = new List<CourseModel>();
                CourseModel cmd;
                createConn();
                try
                {
                    command = new SqlCommand("spCourses_GetByDep", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@dep", dep);

                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        
                        cmd = new CourseModel();
                        cmd.CourseCode = reader[0].ToString();
                        cmd.Title = reader[1].ToString();
                        cmd.Department = dep;
                        lcm.Add(cmd);
                    }

                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                closeConn();
                return lcm;
            }
            /// <summary>
            /// Get Classes(Semester Section Department)
            /// </summary>
            /// <param name="dep"></param>
            /// <returns></returns>
            public List<ClassModel> GetClasses(string dep)
            {
                ClassModel cm;
                List<ClassModel> lcm = new List<ClassModel>();

                createConn();
                try
                {
                    command = new SqlCommand("spClass_GetByDep",connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@dep", dep);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cm = new ClassModel();
                        cm.ID = int.Parse(reader[0].ToString());
                        cm.Semester = int.Parse(reader[1].ToString());
                        cm.Section = reader[2].ToString()[0];
                        cm.Department = dep;
                        lcm.Add(cm);
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                closeConn();

                return lcm;
            }
            /// <summary>
            /// Get all the Teacher Department
            /// For Admin
            /// </summary>
            /// <param name="dep">Department</param>
            /// <returns>List of Teahers</returns>
            public List<TeacherModel> GetTeacher(string dep="")
            {
                List<TeacherModel> ltm = new List<TeacherModel>();
                TeacherModel tm;
                createConn();
                try
                {
                    command = new SqlCommand("spTeacher_GetByDep", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@dep", dep);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        tm = new TeacherModel();
                        tm.ID = int.Parse(reader[0].ToString());
                        tm.FirstName = reader[1].ToString();
                        tm.LastName = reader[2].ToString();
                        tm.Contact = reader[3].ToString();
                        tm.Email = reader[4].ToString();
                        tm.Qualification = reader[5].ToString();
                        tm.Department = dep;
                        tm.Address = reader[7].ToString();
                        tm.CNIC = reader[8].ToString();

                        ltm.Add(tm);
                    }
                }catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                closeConn();
                return ltm;
            }
            
            public TeacherModel GetTeacher_GetByLoginID(int loginID)
            {
                TeacherModel tm = new TeacherModel();

                createConn();
                try
                {
                    command = new SqlCommand("spTeacher_GetByLoginID", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@LoginID", loginID);
                    reader = command.ExecuteReader();
                    reader.Read();
                    
                        tm = new TeacherModel();
                        tm.ID = int.Parse(reader[0].ToString());
                        tm.FirstName = reader[1].ToString();
                        tm.LastName = reader[2].ToString();
                        tm.Contact = reader[3].ToString();
                        tm.Email = reader[4].ToString();
                        tm.Qualification = reader[5].ToString();
                        tm.Department = reader[6].ToString();
                        tm.Address = reader[7].ToString();
                        tm.CNIC = reader[8].ToString();
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                closeConn();

                return tm;
            }

            public StudentModel Student_GetByLoginID(int loginID)
            {
                StudentModel sm = new StudentModel();

                createConn();
                try
                {
                    command = new SqlCommand("spStudent_GetByLoginID", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@LoginID", loginID);
                    reader = command.ExecuteReader();
                    reader.Read();

                    sm = new StudentModel();
                    sm.ID = int.Parse(reader[0].ToString());
                    sm.FirstName = reader[1].ToString();
                    sm.LastName = reader[2].ToString();
                    sm.FatherName = reader[3].ToString();
                    sm.Contact = reader[4].ToString();
                    sm.Email = reader[5].ToString();
                    
                    sm.Department = reader[6].ToString();
                    sm.ClassID = int.Parse(reader[7].ToString());
                    sm.LoginID = int.Parse(reader[8].ToString());
                    sm.Address = reader[9].ToString();

                 }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                closeConn();

                return sm;
            }


            public LoginModel GetLoginInfo(int Login_ID)
            {
                LoginModel lm = new LoginModel();
                createConn();
                try
                {
                    command = new SqlCommand("spGetLoginInfo", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ID", Login_ID);
                    reader = command.ExecuteReader();
                    reader.Read();

                    lm.loginID = Login_ID;
                    lm.username = reader[1].ToString();
                    lm.password = reader[2].ToString();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                closeConn();
                return lm;

            }
            /// <summary>
            /// Get Students By Class 
            /// </summary>
            /// <param name="CM">Class Model which includes Semester Section & Depart</param>
            /// <returns></returns>
            public List<TeacherModel> SearchTeacher(string value, string sb)
            {
                List<int> deps = new List<int>();
                int ID = 0;
                string FName = "", LName = "", CNIC = "";
                List<TeacherModel> ltm = new List<TeacherModel>();
                if (sb.ToUpper() == "ID")
                    ID = int.Parse(value);
                else if (sb.ToUpper() == "FIRSTNAME")
                    FName = value;
                else if (sb.ToUpper() == "LASTNAME")
                    LName = value;
                else if (sb.ToUpper() == "CNIC")
                    CNIC = value;
                else { }

                createConn();
                try
                {
                    command = new SqlCommand("spTeacher_Search", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ID",ID);
                    command.Parameters.AddWithValue("@FirstName", FName);
                    command.Parameters.AddWithValue("@LastName", LName);
                    command.Parameters.AddWithValue("@CNIC", CNIC);

                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TeacherModel t = new TeacherModel();
                        t.ID = int.Parse(reader[0].ToString());
                        t.FirstName = reader[1].ToString();
                        t.LastName = reader[2].ToString();
                        t.Contact = reader[3].ToString();
                        t.Email = reader[4].ToString();
                        t.Qualification = reader[5].ToString();
                        deps.Add(int.Parse(reader[6].ToString()));
                        //t.Department = reader[6].ToString();
                        t.Address = reader[7].ToString();
                        t.CNIC = reader[8].ToString();
                        t.loginID = int.Parse(reader[9].ToString());
                        ltm.Add(t);
                    }
                    reader.Close();
                    for(int i=0;i<ltm.Count;i++)
                    {
                        ltm[i].Department = GetDepByID(deps[i]);
                        LoginModel lm = GetLoginInfo(ltm[i].loginID);
                        ltm[i].username = lm.username;
                        ltm[i].password = lm.password;
                    }

                }catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }


                return ltm;
            }
            public List<StudentModel> GetStudentByClass(int classID)
            { 
                List<StudentModel> lsm = new List<StudentModel>();
                StudentModel sm;
                createConn();
                try
                {

                    command = new SqlCommand("spStudent_GetByClass", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    //command.Parameters.AddWithValue("@dep", CM.Department);
                    //command.Parameters.AddWithValue("@semester", CM.Semester);
                    //command.Parameters.AddWithValue("@section", CM.Section);
                    command.Parameters.AddWithValue("@classID", classID);
                    ClassModel c;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        
                        sm = new StudentModel();
                        sm.ID = int.Parse(reader[0].ToString());
                        sm.FirstName = reader[1].ToString();
                        sm.LastName = reader[2].ToString();
                        sm.FatherName = reader[3].ToString();
                        sm.Contact = reader[4].ToString();
                        sm.Email = reader[5].ToString();
                        sm.ClassID = int.Parse(reader[7].ToString());
                        
                        //sm.Department = GetDepByID(int.Parse(reader[6].ToString()));
                        
                        lsm.Add(sm);
                    }

                    reader.Close();
                    for(int i=0;i<lsm.Count;i++)
                    {
                        c = new ClassModel();
                        c = GetClassByID(lsm[i].ClassID);
                        lsm[i].Semester = c.Semester;
                        lsm[i].Section = c.Section;
                        lsm[i].Department = c.Department;
                        
                    }
                    
                }
                catch(Exception e)
                {
                    throw new Exception(e.Message);
                }
                closeConn();
                return lsm;
            }

            /// <summary>
            /// Function to Get Courses of a Teacher From Table ClassCourse
            /// whose columns are ClassID CourseID and Teacher ID
            /// </summary>
            /// <param name="teacherID">WE want to get teacher courses so teacher id is passed</param>
            /// <returns>it returns the list of Teacher Courses</returns>
            public List<TeacherCourseModel> GetTeacherCourses(int teacherID)
            {
                List<TeacherCourseModel> ltcm = new List<TeacherCourseModel>();
                TeacherCourseModel tcm;
                createConn();
                
                try
                {//spTeacher_GetCourses returns CourseCode and ClassID
                    command = new SqlCommand("spTeacher_GetCourse",connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@teacherID", teacherID);
                    reader = command.ExecuteReader();
                    
                    //TODO- GET TEACHER COURSES
                    while (reader.Read())
                    {
                        tcm = new TeacherCourseModel();
                        //It returns CourseCode so we neet to get Course Title Too
                        //To get Course Title Call method GetCourseByID
                        tcm.CCID = int.Parse(reader[0].ToString());
                        tcm.Course.CourseCode = reader[1].ToString();

                        //To Get Class Details Call method GetClassByID
                        tcm.Class.ID = int.Parse(reader[2].ToString());

                        ltcm.Add(tcm);
                    }
                    reader.Close();
                    for(int i = 0; i < ltcm.Count; i++)
                    {
                        ltcm[i].Class = GetClassByID(ltcm[i].Class.ID);
                        ltcm[i].Course = GetCourseByID(ltcm[i].Course.CourseCode);
                    }

                }catch(SqlException e)
                {
                    MessageBox.Show(e.Message);
                }
                closeConn();

                return ltcm;
            }
            public List<TeacherCourseModel> GetAllAlocCourses(string val, string sb)
            {
                List<TeacherCourseModel> ltcm = new List<TeacherCourseModel>();
                TeacherCourseModel ltm;
                createConn();
                try
                {
                    command = new SqlCommand("spGetAlocCourses", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("val", val);

                    if (sb.ToLower() == "dep")
                    {
                        command.Parameters.AddWithValue("@sb", "dep");
                    }

                    else if (sb.ToLower() == "classid")
                        command.Parameters.AddWithValue("@sb", "ClassID");

                    else if (sb.ToLower() == "courseid")
                        command.Parameters.AddWithValue("@sb", "CourseID");

                    else if (sb.ToLower() == "teacherid")
                        command.Parameters.AddWithValue("@sb", "TeacherID");



                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ltm = new TeacherCourseModel();
                        ltm.Class.ID = int.Parse(reader[1].ToString());
                        ltm.Course.CourseCode = reader[2].ToString();
                        ltm.teacher.ID = int.Parse(reader[3].ToString());
                        ltcm.Add(ltm);
                    }
                    reader.Close();
                    
                    for(int i= 0; i < ltcm.Count; i++)
                    {
                        ltcm[i].Class = GetClassByID(ltcm[i].Class.ID);
                        ltcm[i].Course = GetCourseByID(ltcm[i].Course.CourseCode);
                        ltcm[i].teacher = SearchTeacher(ltcm[i].teacher.ID.ToString(), "id")[0];

                    }

                }catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

                return ltcm;
            } 

            public List<StudentModel> GetStudents_ByCCID(int ccid)
            {
                List<StudentModel> lsm = new List<StudentModel>();
                createConn();
                try
                {
                    StudentModel sm;
                    
                    command = new SqlCommand("spStudents_GetByCCID",connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CCID", ccid);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        sm = new StudentModel();
                        sm.ID = int.Parse(reader[0].ToString());
                        sm.FirstName = reader[1].ToString();
                        sm.LastName = reader[2].ToString();
                        sm.Contact = reader[4].ToString();
                        sm.FatherName = reader[3].ToString();
                        sm.Department = reader[6].ToString();
                        sm.ClassID = int.Parse(reader[7].ToString());
                        sm.Email = reader[5].ToString();
                        sm.LoginID = int.Parse(reader[8].ToString());

                        lsm.Add(sm);
                    }
                }catch(Exception e)
                {
                    throw new Exception(e.Message);
                }

                return lsm;
            }
            public CourseModel GetCourseByID(string ID)
            {
                SqlDataReader rd;
                CourseModel cm = new CourseModel();
                createConn();
                try
                {
                    command = new SqlCommand("spCourse_GetByID", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", ID);
                    rd= command.ExecuteReader();
                    if (rd.Read())
                    {
                        cm.Title = rd[0].ToString();
                        cm.Department = rd[1].ToString();
                    }
                    rd.Close();
                    cm.Department = GetDepByID(int.Parse(cm.Department));
                    cm.CourseCode = ID;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                closeConn();
                return cm;
            }
            public ClassModel GetClassByID(int ID)
            {
                SqlDataReader rd;
                ClassModel cm = new ClassModel();
                createConn();
                try
                {
                    command = new SqlCommand("spClass_GetByID", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", ID);
                    rd = command.ExecuteReader();
                    if (rd.Read())
                    {
                        cm.Semester = int.Parse(rd[1].ToString());
                        cm.Section = rd[2].ToString()[0];
                        cm.Department = rd[3].ToString();
                        //rd.Close();
                    }
                    rd.Close();
                    cm.Department = GetDepByID(int.Parse(cm.Department));

                }catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                closeConn();
                cm.ID = ID;
                return cm;
                
            }
            private string GetDepByID(int ID)
            {
                SqlDataReader rd;
                string name="";
                createConn();
                try
                {
                    command = new SqlCommand("spDepartment_GetByID",connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", ID);
                    rd = command.ExecuteReader();
                    if (rd.Read())
                    {
                        name = rd[0].ToString();
                    }
                    rd.Close();

                }catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                closeConn();
                return name;
            }

            public int GetClassID(ClassModel cm)
            {
                try
                {
                    createConn();
                    command = new SqlCommand("spGetClassID", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@dep", cm.Department);
                    command.Parameters.AddWithValue("@semester", cm.Semester);
                    command.Parameters.AddWithValue("@section", cm.Section);

                    reader = command.ExecuteReader();
                    int id = int.Parse(reader[0].ToString());
                    closeConn();
                    return id;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    closeConn();
                    return 0;
                }
            }
            //public int getStudentClassID(int std_Id)
            //{
            //    int classID = 0;
            //    createConn();
            //    try
            //    {
            //        command = new SqlCommand("spStudent_GetClassID")
            //    }


            //    return classID;
            //}
            //TODO - Get student courses via class ID 
            //select * from class course then get course and teacher and return it
            public List<StudentCoursesModel> getStudentCourses(int classID)
            {
                List<StudentCoursesModel> lscm = new List<StudentCoursesModel>();

                createConn();
                try
                {
                    command = new SqlCommand("@spGetStudentCourses", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@classID", classID);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        StudentCoursesModel cm = new StudentCoursesModel();
                        cm.CCID = int.Parse(reader[0].ToString());
                       // cm.Class = 
                    }

                }catch(Exception e)
                { throw new Exception(e.Message); }


                return lscm;
            }

            public List<MaterialModel> GetMaterial(int ccid)
            {

                List<MaterialModel> lmm = new List<MaterialModel>();
                MaterialModel mm = new MaterialModel();
                createConn();
                try
                {
                    command = new SqlCommand("spMaterialGet", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CCID", ccid);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        mm = new MaterialModel();
                        mm.Material_ID = int.Parse(reader[0].ToString());
                        mm.data = (byte[])reader[1];
                        mm.Name = reader[2].ToString();
                        mm.Description = reader[3].ToString();
                        mm.type = reader[4].ToString();

                        lmm.Add(mm);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                return lmm;
            }
        }

        public class Update:SqlConnector
        {
            public bool UpdatePassword(LoginModel lm, string newPass)
            {

                createConn();
                try
                {
                    command = new SqlCommand("spLoginUpdate");
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@loginID", lm.loginID);
                    command.Parameters.AddWithValue("@password", lm.password);
                    command.Parameters.AddWithValue("@newPass", newPass);
                    command.ExecuteNonQuery();


                }catch(Exception e)
                {
                    throw new Exception(e.Message);
                    
                }
                return true;

                
            }
            public bool UpdateCourse(CourseModel cm, string code)
            {
                createConn();
                try
                {
                    command = new SqlCommand("spCourse_Update", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@code", code);
                    command.Parameters.AddWithValue("@CourseCode", cm.CourseCode);
                    command.Parameters.AddWithValue("@Title", cm.Title);

                    command.ExecuteNonQuery();
                    closeConn();

                }catch(Exception e)
                {
                    closeConn();
                    return false;
                }

                return true;
            }
            public bool UpdateTeacher(TeacherModel tm)
            {

                createConn();
                try
                {

                    command = new SqlCommand("spTeacher_Update", connection);
                    command.CommandType = CommandType.StoredProcedure;



                    command.Parameters.AddWithValue("@TID", tm.ID);
                    command.Parameters.AddWithValue("@FName", tm.FirstName);
                    command.Parameters.AddWithValue("@LName", tm.LastName);
                    command.Parameters.AddWithValue("@contact", tm.Contact);
                    command.Parameters.AddWithValue("@email", tm.Email);
                    command.Parameters.AddWithValue("@qualif", tm.Qualification);
                    command.Parameters.AddWithValue("@Address", tm.Address);
                    command.Parameters.AddWithValue("@cnic", tm.CNIC);
                    command.Parameters.AddWithValue("@LID", tm.loginID);
                    command.Parameters.AddWithValue("@username", tm.username);
                    command.Parameters.AddWithValue("@password", tm.password);

                    command.ExecuteNonQuery();

                    closeConn();
                    return true;
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                closeConn();
                
                return false;
            }
            public bool DeleteTeacher(int teacherID, int loginID)
            {
                createConn();
                try
                {
                    command = new SqlCommand("spTeacher_Delete",connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TID", teacherID);
                    command.Parameters.AddWithValue("@LID", loginID);
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                closeConn();
                return true;
            }
            public bool DeleteTeacherCourse(TeacherCourseModel tm)
            {
                createConn();

                tm.Class.ID = new GetData().GetClassID(tm.Class);

                try
                {
                    command = new SqlCommand("spTeacher_DeleteCourse",connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@classID", tm.Class.ID);
                    command.Parameters.AddWithValue("@courseCode", tm.Course.CourseCode);

                    command.ExecuteNonQuery();
                    closeConn();
                    return true;

                }catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                closeConn();
                return false ;
            }
            public bool DeleteCourse(string Code)
            {

                createConn();
                try
                {
                    command = new SqlCommand("spTeacher_Delete", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Code",Code);
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    return false;

                }
                closeConn();
                return true;


            }
        }
        
    }
}
