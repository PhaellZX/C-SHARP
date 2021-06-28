using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester{
	
	// CLASSES
	
	   public class Personagem { // PRIVATE -> ENCAPSULAMENTO GET & SET
		
			private string nomeClasse;
			private string nome;

			public string NomeClasse {
				  
          get{return nomeClasse;}
          set{nomeClasse = value;}
          
      }

      public string Nome {
				get{return nome;}
				set{nome = value;}
      }
		}
		
		public class Cavaleiro : Personagem{
			
			 public int ataque = 20;
			 public int defesa = 10;
			 public int velocidade = 10;
			
			public void status(){
			 
			Console.WriteLine("\nCAVALEIRO\nAtaque: " + ataque + "\nDefesa: " + defesa + "\nVelocidade: " + velocidade);
				}
		}
		
		 public class Escudeiro : Personagem {
			
			 public int ataque = 10;
			 public int defesa = 20;
			 public int velocidade = 5;
			
			public void status(){
			Console.WriteLine("\nESCUDEIRO\nAtaque: " + ataque + "\nDefesa: " + defesa + "\nVelocidade: " + velocidade);
				}
		}
	
		public class Arqueiro : Personagem {
			
		  public int ataque = 25;
			public int defesa = 10;
			public int velocidade = 20;
			
			public void status(){
			Console.WriteLine("\nARQUEIRA\nAtaque: " + ataque + "\nDefesa: " + defesa + "\nVelocidade" + velocidade);
				}
		}
	public class Program{
		
        public static void Main(string[] args){
           
			// OBJETOS
			
			Personagem p = new Personagem();
			
			Cavaleiro cav1 = new Cavaleiro();
			Escudeiro esc1 = new Escudeiro();
			Arqueiro arc1 = new Arqueiro();

      cav1.status();
			esc1.status();
			arc1.status();
			
            
        }
    
	}
}