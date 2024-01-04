
namespace BLL;
using BOL;
using DAL;

public class catalogmanager{
    public  static List<Product> getALL(){
        List<Product> pr=DBmanager.Get();
        return pr;
    }
}