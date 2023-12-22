int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
var cal=new Calculator(a,b);
cal.znak=Console.ReadKey().KeyChar;

switch (cal.znak)
{
    case  '+' :
    
       System.Console.WriteLine("\n"+a+"+"+b+"="+cal.sum());
       break;
     case  '-' :
       System.Console.WriteLine("\n"+a+"-"+b+"="+cal.subtruct());
       break;
        case  '*' :
       System.Console.WriteLine("\n"+a+"*"+b+"="+cal.multiply());
       break;
        case  '/' :
        System.Console.WriteLine("\n"+a+"/"+b+"="+cal.division());
       break;
}
