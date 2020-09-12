 using System;
/*Crie uma classe que modele uma pessoa:

Atributos: nome, idade, peso e altura
Métodos: Envelhercer, engordar, emagrecer, crescer. Obs: Por padrão, a cada ano que nossa pessoa envelhece, sendo a idade dela menor que 21 anos, ela deve crescer 0,5 cm.*/

class  pessoa {
	
	private string nome;
	private int idade;
	private double peso, altura;

  public void mostra (string n, int i, double p,double a){
  nome = n;
  idade = i;
  peso = p;
  altura = a;
  }

  public void dados(){
  Console.WriteLine("Nome: {0}, idade: {1}, peso: {2}, altura: {3}", nome, idade, peso, altura);
  }

	public void envelhecer(int atual){

    if (idade < 21) {
      altura += idade*0.005-0.04;
      idade += atual;
      
    }
  }
  public int retornarenvelhecer(){
    
    return idade ;

  }
  
  public void engordar(double ganho_de_peso){
    peso += ganho_de_peso; 
  }

  public double retornar_engordar(){
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