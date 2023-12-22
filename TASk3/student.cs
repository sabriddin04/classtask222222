class student{


     string name;
     int age;
     
     double averageGrade;

    public student(string a,int b,double c)
    {
        name=a;
        age=b;
        averageGrade=c;
    }
    public string GetInfo(){

       return $"ИМЯ:{name},ВОЗРАСТ:{age},СРЕДНЯЯ ОЦЕНКА:{averageGrade}";


    }
    public bool IsExcellentStudent(){

       if(averageGrade>4){return true;}
       else return false;


    }




}