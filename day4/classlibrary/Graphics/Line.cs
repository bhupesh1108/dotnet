using Hardware;
namespace Drawing;
public class Line:Shape,IPrinter{
    public Point StartPoint{get;set;}
    public Point EndPoint{get;set;}
    public Line():base(){
        this.StartPoint=new Point(0,0);
        this.EndPoint=new Point(0,0);

    }
    public Line(Point p1,Point p2,int w, string c):base(w,c){
        this.StartPoint=p1;
        this.EndPoint=p2;
    }
    public override void Draw(){
        console.WriteLine("draw line");
        console.WriteLine(this);

    }
    public override string ToString(){
        return base.ToString +this.StartPoint+","+this.EndPoint;
    }
}