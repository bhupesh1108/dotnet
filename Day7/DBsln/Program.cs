using MySql.Data.MySqlClient;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("wellcome to dataBAse app");

        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = "server=192.168.10.150;port=3306;user=dac12;Password=welcome;database=Dac12";
        string query="select * from products";
        
MySqlCommand command = new MySqlCommand(query, connection);

try{
    connection.Open();
MySqlDataReader reader=command.ExecuteReader();

while(reader.Read()){
     int id=int.Parse(reader["ProductID"].ToString());
     string name=reader["ProductName"].ToString();
     Console.Write(id+" ");
     Console.WriteLine(name);
}}catch(Exception e){
    Console.WriteLine(e.Message);
}
finally{
    connection.Close();
}
    }
}