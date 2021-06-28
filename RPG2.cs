using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MainClass {

     public static void acoesMaquina(int HP){

       Random maq = new Random();

      switch(maq.Next(2+1)){
            case 1:

                  HP = HP - 5;
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.WriteLine("Dano do Vilão: 5");

                break;
            case 2:

                  HP = HP - 10;
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.WriteLine("Dano do Vilão: 10");

                break;
            case 3:

                  Console.WriteLine("Errou o Ataque");

                break;
          }
    
}
  
    public static void Main (string[] args) {

      int HP_Humano = 100, HP_Maquina = 50;

      int opcao, maquina;
      int cont = 1, MP = 4;

    do{    Console.ForegroundColor = ConsoleColor.White;
           Console.WriteLine("BATALHA");
         
          Console.WriteLine("Heroi: " + HP_Humano);
          Console.WriteLine(cont + "-Inimigo: " + HP_Maquina);

          Console.ForegroundColor  = ConsoleColor.Blue;

          Console.WriteLine("1 - ATAQUE");
          Console.WriteLine("2 - ESPECIAL = " + MP);
          Console.WriteLine("0 - DESISTIR");

          opcao = Convert.ToInt32(Console.ReadLine());

          // HEROI

          switch(opcao){
            case 1:

                  HP_Maquina = HP_Maquina - 50;
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.WriteLine("Dano do Heroi: 50");
                  acoesMaquina(HP_Humano);
                break;
            case 2:

              acoesMaquina(HP_Humano);
              if(MP!=0){

                  HP_Maquina = HP_Maquina - 100;
                  Console.ForegroundColor  = ConsoleColor.Red;
                  Console.WriteLine("Dano do Heroi: 100");
                  MP--;
                  
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
                acoesMaquina(HP_Humano);

                break;
          }
            if(HP_Maquina==0||HP_Maquina < 0){
                Console.WriteLine("Inimigo Derrotado");

                for(int i = 0; i <= cont; i++){

                HP_Maquina = HP_Maquina + 50;
              }
            cont++;
              
            }

            if(cont==10||cont==20){

              Console.ForegroundColor  = ConsoleColor.Green;
              Console.WriteLine("HP e MP do heroi Aumentado!");

              HP_Humano = HP_Humano + 100;
              MP += 4;

              cont++;
            }
        }while(HP_Humano!=0&&HP_Humano > 0&&opcao!=0);
        

      Console.WriteLine("GAME OVER!");
      Console.ReadKey();
    }
}