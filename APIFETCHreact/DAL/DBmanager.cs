namespace DAL;
using BOL;
using MySql.Data.MySqlClient;
public class DBmanager{
    public static List<Product> Get(){
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=@"server=localhost;port=3306;user=root;password=root;database=practice";
        String query="select *from product";
        MySqlCommand command=new MySqlCommand(query,conn);
        conn.Open();
        MySqlDataReader read=command.ExecuteReader();
        List<Product> prd=new List<Product>();
        while(read.Read()){
            int a=int.Parse(read["PRODID"].ToString());
            String desc=read["DESCRIP"].ToString();
           Product pro=new Product();
           pro.DESCRIP=desc;
           pro.PRODID=a;
           prd.Add(pro);
        }
        return prd;
    
    conn.Close();
    }
}