class User{

      public string  FirstName{ get;set;}

      public string LastName{ get;set;}
      public  string Username{ get;set;}

      public string Password{get;set;}


      public string  GetInfo()
{

    return $"name{FirstName} LastName{LastName}";
}
 
 public string Login(){



    return Password;
 }



}