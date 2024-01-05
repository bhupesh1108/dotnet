using Model;
using DAL;
using System.Reflection.Metadata.Ecma335;
namespace BLL;
public class Catalog{
    public static List<Student> getAll(){

        List<Student> st=DBManager.get();
        return st;
    }
    public static bool Update(int id ,String firstname,String lastname,String email ){
        bool flag=DBManager.UpdateData(id,firstname,lastname,email);
        return flag;
    }
    
}