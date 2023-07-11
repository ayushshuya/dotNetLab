using EMP;
namespace MGR;

public class Manager :Employee{
    private double increament;
    private double netsal;

    public Manager(){

    }
    public Manager(string fName,string lName,int id,double salary,double increament)
                   :base(fName,lName,id,salary){
                    this.increament=increament;
                    this.netsal=salary+increament;}

    // public double Increament{
    // get{return this.increament;}
    // set{this.increament=value;}


    public override string ToString()
    {
        string data=base.ToString();
        return data+" "+this.increament+" "+this.netsal;
    }

    }
    
