namespace EMP;
public class Employee{
    private string firstName;
    private string lastName;
    
    private int id;

    private double salary;
    

    public Employee(){

    }
    public Employee(string fName,string lName,int id,double salary){
        this.firstName=fName;
        this.lastName=lName;
        this.id=id;
       this.salary=salary;
       

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
    

    public override string ToString()
    {
        string data=base.ToString();
        return data+this.firstName + " "+ this.lastName+ " "+ this.id +" "+
               this.salary ;
    }




}