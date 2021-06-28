using System;

public class Pokemon {

  private string nome;
  private string tipo;
  private int ataque;
  private int defesa;
  private int velocidade;

  public string Nome{
    get{return nome;}
    set{nome = value;}
  }

  public string Tipo{
    get{return tipo;}
    set{tipo = value;}
  }

  public int Ataque{
    get{return ataque;}
    set{ataque = value;}
  }

  public int Defesa{
    get{return defesa;}
    set{defesa = value;}
  }

  public int Velocidade{
    get{return velocidade;}
    set{velocidade = value;}
  }

  /*public void usarTecnica(){
    
    Console.WriteLine("Nenhuma Técnica selecionada");

  }*/
}

public class Chamander : Pokemon{

    private string tm1 = "Arranhar";
    private string tm2 = "Encarar";
    private string tm3 = "Labaredas";
    private string tm4 = "---------";

    public string Tm1{
      get{return tm1;}
      set{tm1 = value;}
    } 

    public string Tm2{
      get{return tm2;}
      set{tm2 = value;}
    }

    public string Tm3{
      get{return tm3;}
      set{tm3 = value;}
    }

    public string Tm4{
      get{return tm4;}
      set{tm4 = value;}
    }

    public void usarTecnica(){

      Console.WriteLine (tm3);

    }
}

public class Squirtle : Pokemon{

    private string tm1 = "Agarrar";
    private string tm2 = "Caudada";
    private string tm3 = "Jato da Água";
    private string tm4 = "Bolhas";

    public string Tm1{
      get{return tm1;}
      set{tm1 = value;}
    } 

    public string Tm2{
      get{return tm2;}
      set{tm2 = value;}
    }

    public string Tm3{
      get{return tm3;}
      set{tm3 = value;}
    }

    public string Tm4{
      get{return tm4;}
      set{tm4 = value;}
    }

    public void usarTecnica(){

      Console.WriteLine (tm4);

    }
}

public class Bubasaur : Pokemon{

    private string tm1 = "Agarrar";
    private string tm2 = "Folha Navalha";
    private string tm3 = "Chicote de cipó";
    private string tm4 = "dupla - Facada";

    public string Tm1{
      get{return tm1;}
      set{tm1 = value;}
    } 

    public string Tm2{
      get{return tm2;}
      set{tm2 = value;}
    }

    public string Tm3{
      get{return tm3;}
      set{tm3 = value;}
    }

    public string Tm4{
      get{return tm4;}
      set{tm4 = value;}
    }

    public void usarTecnica(){

        Console.WriteLine (tm2);
    }
}

class MainClass {
  public static void Main (string[] args) {
    
    Chamander p1 = new Chamander();
    Squirtle p2 = new Squirtle();
    Bubasaur p3 = new Bubasaur();

    p1.usarTecnica();
    p2.usarTecnica();
    p3.usarTecnica();

    }
}