using MySql.Data.MySqlClient;

using Microsoft.AspNetCore.Mvc;



public class DBManager{
  
    public static int Validate(string name, string pass){

 MySqlConnection conn=new MySqlConnection();
conn.ConnectionString="server=192.168.10.150;port=3306;user=dac12;password=welcome;database=dac12";

String query="select id from Login where name=@name and password=@pass";

MySqlCommand command=new MySqlCommand(query,conn);
command.Parameters.AddWithValue("@name",name);
command.Parameters.AddWithValue("@pass",pass);
conn.Open();

MySqlDataReader read=command.ExecuteReader();

int a=0;
while(read.Read()){
    // Console.WriteLine(read.Read());
    // Console.WriteLine(read["name"].ToString());
 a=int.Parse(read["id"].ToString());
 Console.WriteLine(a);
  
}
return a;

                            


    }
}