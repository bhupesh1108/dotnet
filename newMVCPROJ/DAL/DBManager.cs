using System.Configuration;
using Model;
using MySql.Data.MySqlClient;
using Model;
namespace DAL;
 public class DBManager{
    public static String connString=@"server=localhost;port=3306;user=root; password=root;database=dac12";
public static List<Student> get(){
    MySqlConnection conn=new MySqlConnection();
conn.ConnectionString=connString;
string query="select * from student";
conn.Open();
MySqlCommand cmd=new MySqlCommand(query,conn);
MySqlDataReader reader=cmd.ExecuteReader();
List<Student> slist=new List<Student>();
while(reader.Read()){
    Student st=new Student();
    int id=int.Parse(reader["ID"].ToString());
    String First=reader["nameFirst"].ToString();
    String Last=reader["nameLast"].ToString();
    String emailid=reader["emailID"].ToString();
    st.Id=id;
    st.Firstname=First;
    st.Lastname=Last;
    st.email=emailid;
    slist.Add(st);
}
return slist;
}

public static bool UpdateData(int id ,String firstname,String lastname,String email){
     MySqlConnection conn=new MySqlConnection();
     conn.ConnectionString=connString;
     string query="update student set namefirst=@firstname,namelast=@lastname,emailid=@email";
     MySqlCommand cmd=new MySqlCommand(query,conn);
     cmd.Parameters.AddWithValue("@firstname",firstname);
     cmd.Parameters.AddWithValue("@lastname",lastname);
     cmd.Parameters.AddWithValue("@email",email);
     int n=cmd.ExecuteNonQuery();
     if(n>0){
        return true;

     }
     return false;
}
 }