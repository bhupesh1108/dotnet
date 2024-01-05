namespace Drawing;
public abstract class Shape{
    public shape(){
        this.color=black;
        this.width=0;
    }
    public Shape(int w, string c ){
        this.color=c;
        this.width=w;
    }
    public string color{get;set;}
    public int width{get;set;}
    public abstract void Draw();
    public override string ToString(){
        return "width="+this.width+", color="+this.color;
    }
}