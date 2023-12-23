using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_csharp_calculo_de_pegada_carbono.Models
{
  public class Program
  {
static void Main()
{

    string nome = Console.ReadLine();
    double quilometrosPorDia = double.Parse(Console.ReadLine());
    int horasDeEletronicos = int.Parse(Console.ReadLine());
    int refeicoesComCarne = int.Parse(Console.ReadLine());


    double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);
      

    Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");

 
    Console.ReadLine();
  }


  static double CalcularPegadaDeCarbono(double quilometrosPorDia, double horasDeEletronicos, double refeicoesComCarne)
{
   double pegadaTransportes = quilometrosPorDia * 365 * 0.2;
   double pegadaEletronicos = horasDeEletronicos * 0.1;
   double pegadaDaCarne = refeicoesComCarne * 0.5; 
   return pegadaTransportes + pegadaEletronicos + pegadaDaCarne;
}

  }
}