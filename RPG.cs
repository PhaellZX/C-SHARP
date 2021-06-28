using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// RESOLVER PROBLEMA DE RANDÔMICAÇÂO

public class Heroi {
  private int hp = 100;
  private int atq = 50;
  private int esp = 100;

  public int Hp{
    get {return hp;}
    set{hp = value;}
  }

  public int Atq{
    get{return atq;}
    set{atq = value;}
  }

  public int Esp{
    get{return esp;}
    set{esp = value;}
  }
}

public class Inimigo {
  private int hp = 50;
  private int atq = 1;
  private int esp = 2;

  public int Hp{
    get{return hp;}
    set{hp = value;}
  }

  public int Atq{
    get{return atq;}
    set{atq = value;}
  }

  public int Esp{
    get{return esp;}
    set{esp = value;}
  }

  public void acoesMaquina(){

       Heroi p1 = new Heroi();
       Inimigo c1 = new Inimigo();
       Random maq = new Random();

       int maquina = maq.Next(3);

      switch(maquina){
            case 1:

                  p1.Hp = p1.Hp - c1.Atq;
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.WriteLine("Dano do Vilão: " + c1.Atq);

                break;
            case 2:

                  p1.Hp = p1.Hp - c1.Esp;
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.WriteLine("Dano do Vilão: " + c1.Esp);

                break;
            case 3:

                  Console.WriteLine("Errou o Ataque");

                break;
          }
        }
}

class MainClass {
  
    public static void Main (string[] args) {

      Heroi p1 = new Heroi();
      Inimigo c1 = new Inimigo();
      int opcao, maquina;
      int cont = 1, mp = 4;

    do{    Console.ForegroundColor = ConsoleColor.White;
           Console.WriteLine("BATALHA");
         
          Console.WriteLine("Heroi: " + p1.Hp);
          Console.WriteLine(cont + "-Inimigo: " + c1.Hp);

          Console.ForegroundColor  = ConsoleColor.Blue;

          Console.WriteLine("1 - ATAQUE");
          Console.WriteLine("2 - ESPECIAL = " + mp);
          Console.WriteLine("0 - DESISTIR");

          opcao = Convert.ToInt32(Console.ReadLine());

          // HEROI

          switch(opcao){
            case 1:

                  c1.Hp = c1.Hp - p1.Atq;
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.WriteLine("Dano do Heroi: " + p1.Atq);
                  c1.acoesMaquina();
                break;
            case 2:

              c1.acoesMaquina();
              if(mp!=0){

                  c1.Hp = c1.Hp - p1.Esp  ;
                  Console.ForegroundColor  = ConsoleColor.Red;
                  Console.WriteLine("Dano do Heroi: " + p1.Esp);
                  mp--;
                  
              }else{
                  
                  Console.WriteLine("Sem Especial");
              }
                  
                break;
            case 0:
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.WriteLine("DESISTÊNCIA");

                break;
            default:
                Console.WriteLine("Valor Inválido!");
                c1.acoesMaquina();

                break;
          }
            if(c1.Hp==0||c1.Hp < 0){
                Console.WriteLine("Inimigo Derrotado");

                c1.Hp = 50 * (cont + 1);
                c1.Atq = 1 * (cont + 1);
                c1.Esp = 2 * (cont + 1);
            cont++;
              
            }

            if(cont==10||cont==20){

              Console.ForegroundColor  = ConsoleColor.Green;
              Console.WriteLine("HP e MP do heroi Aumentado!");

              p1.Hp = p1.Hp + 100;
              mp += 4;

              cont++;
            }
        }while(p1.Hp!=0&&p1.Hp > 0&&opcao!=0);
        

      Console.WriteLine("GAME OVER!");

    }
}