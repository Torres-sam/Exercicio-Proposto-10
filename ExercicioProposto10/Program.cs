using System;
using System.Threading.Channels;

namespace MyApp
{
    internal class ExercicioProposto10
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a hora inicial e final do jogo: ");
            string[] horas = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(horas[0]);
            int horaFinal = int.Parse(horas[1]);
            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao =  24 - horaInicial + horaFinal;
            }
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}