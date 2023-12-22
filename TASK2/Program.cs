var person1=new User();
person1.FirstName="sabriddin";
person1.LastName="turaev";
person1.Password="sabrik2004";
var person2=new User();
person2.FirstName="akmal";
person2.LastName="tur";
person2.Password="sabr";
var person3=new User();
person3.FirstName="sabr";
person3.LastName="turaevski";
person3.Password="sabrik";
var person4=new User();
person4.FirstName="faridun";
person4.LastName="nazriev";
person4.Password="sabrik2";
var person5=new User();
person5.FirstName="sab";
person5.LastName="tura";
person5.Password="sabrik04";

List<User>mylist=new List<User>();
mylist.Add(person1);
mylist.Add(person2);
mylist.Add(person3);
mylist.Add(person4);
mylist.Add(person5);


System.Console.WriteLine("vvedite name");
string a=Console.ReadLine();
System.Console.WriteLine("vvedite password");
string b=Console.ReadLine();


foreach (var item in mylist)
{
    if(item.FirstName==a && b==item.Password){
 
       
        System.Console.WriteLine("vhod vipolnen");
        Environment.Exit(0);
       
    }
    
}
 System.Console.WriteLine("oshibka vhoda");