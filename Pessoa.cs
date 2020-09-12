using System;
/*Crie uma classe que modele uma pessoa:

Atributos: nome, idade, peso e altura
Métodos: Envelhercer, engordar, emagrecer, crescer. Obs: Por padrão, a cada ano que nossa pessoa envelhece, sendo a idade dela menor que 21 anos, ela deve crescer 0,5 cm.*/

class  pessoa {
	
	public string nome;
	public int idade;
	public double peso, altura;

	public void envelhecer(int ano){

    if (idade < 21) {
      altura += ano*0.5;
    }
  }
  public int envelhecer(){
    return idade;
  }
  
  public void engordar(double ganho_de_peso){
    peso += ganho_de_peso; 
  }

  public double retorna_engordar(){
    return peso;
  }

  public void emagrecer(double peso_perdido){
    peso -= peso_perdido; 
  } 

  public double retornar_emagrecer(){
    return peso;
  }

  public void crescer(double ganho_de_altura){
    altura += ganho_de_altura;
  }

  public double retornar_crescer(){
    return altura;
  }
}