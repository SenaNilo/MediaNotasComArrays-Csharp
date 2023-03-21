using System;

class Program {
  public static void Main (string[] args) {
    //Programa para calcular a média de notas usando arrays
    double[] md=new double[4];
    double soma=0, md_tt;
    for(int i=0; i<4; i++){
      do{
        Console.WriteLine("Digite a {0}ª nota", i+1);
        md[i]=double.Parse(Console.ReadLine());
        soma=soma+md[i];
        if(md[i]<0 || md[i]>10){
          Console.WriteLine("Digite de novo", i+1);
        }
      }while(md[i]<0 || md[i]>10);
    }
    md_tt=soma/4;
    Console.WriteLine("A média final é {0:F2}", md_tt);
    if(md_tt>=6){
      Console.WriteLine("Aprovado");
    }
    else{
      Console.WriteLine("Reprovado");
    }
  }
}