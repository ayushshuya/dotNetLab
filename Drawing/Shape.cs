namespace Drawing{

public abstract class Shape{

    public int width;
    public String color;
    public abstract void Draw(); 

    public Shape(){
        this.width=2;
        this.color="black";
    }

    public Shape(int w,string c){
    this.width=w;
    this.color=c;
    
    }

}
}