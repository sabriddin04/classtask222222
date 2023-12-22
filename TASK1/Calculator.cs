class Calculator{

     int First;
     int Second;
    public char znak;

    public Calculator(int a,int b )
    {
        First=a;
        Second=b;
    }
   public int sum(){
        return First+Second;
    }
    public  int subtruct(){
        return First-Second;
    }
   public   int multiply(){
        return First*Second;
    }
   public   int division(){
        return First/Second;
    }


}