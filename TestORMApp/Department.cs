namespace BOL;
//[Table("departments")]
//Entity Class ( POCO Object)
public class Department{
    public int Deptno{get;set;}
    public string? Dname{get;set;}  //naullable type
    public string? Loc{get;set;}
}
