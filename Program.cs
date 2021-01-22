using System;



namespace desafio1

{

 class programa

 {

   static void Main(string[] args)

   {

     double kmL = 12.0;

     double tempoGasto = 0.0;

     double velocidadeMedia = 0.0;

     double distancia = 0.0;

     double combustivel = 0.0;

     string valor;

     string[] valores;



     valor = Console.ReadLine();

     valores = valor.Split(' ');



     double.TryParse(valores[0], out tempoGasto);

     double.TryParse(valores[1], out velocidadeMedia);



     distancia = tempoGasto * velocidadeMedia;

     combustivel = Math.Round((distancia / kmL),3);



     Console.WriteLine(string.Format("{0:0.000}", combustivel));

   }

 }

}