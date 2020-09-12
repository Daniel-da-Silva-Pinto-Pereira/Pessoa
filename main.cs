using System;

class MainClass {
  public static void Main (string[] args) {
   pessoa novapessoa = new pessoa();
   
   novapessoa.mostra("Daniel",18,69,1.82);
   novapessoa.dados();
   
   novapessoa.envelhecer(1); 
   novapessoa.engordar(10);
   novapessoa.dados();
   

   novapessoa.emagrecer(5);
   novapessoa.crescer(0.05);
   novapessoa.dados();
   


  }
}