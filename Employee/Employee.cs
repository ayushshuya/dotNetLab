namespace EMP;
public class Employee{
    private string firstName;
    private string lastName;
    
    private int id;

    private double salary;
    private double hra;
    

    public Employee(){

    }
    public Employee(string fName,string lName,int id,double salary,double hra){
        this.firstName=fName;
        this.lastName=lName;
        this.id=id;
       this.salary=salary;
       this.hra=hra;
       

    }

    public string FirstName{
        get{return this.firstName;}
        set{this.firstName=value;}
    }
    public string LastName{
        get{return this.lastName;}
        set{this.lastName=value;}
    }
    public int ID{
        get{return this.id;}
        set{this.id=value;}
    }
    
    public double Salary{
        get{return this.salary;}
        set{this.salary=value;}
    }
    public double Hra{
        get{return this.hra;}
        set{this.hra=value;}
    }
    public virtual double ComputeSal(){
        double sal=salary+hra;
        return sal;
    }

    public override string ToString()
    {
        string data=base.ToString();
        return data+this.firstName + " "+ this.lastName+ " "+ this.id +" "+
               this.salary+" "+this.hra+" "+ComputeSal() ;
    }




}