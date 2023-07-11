using EMP;
namespace MGR;

public class Manager :Employee{
    private double incentive;
   

    public Manager(){

    }
    public Manager(string fName,string lName,int id,double salary,double hra,double incentive)
                   :base(fName,lName,id,salary,hra){
                    this.incentive=incentive;
                    }

    // public double Increament{
    // get{return this.increament;}
    // set{this.increament=value;}

    public override double ComputeSal()
    {
        return base.ComputeSal()+incentive;
    }
    public override string ToString()
    {
        string data=base.ToString()+" incentive is "+incentive;
        return data;
    }

    }
    
