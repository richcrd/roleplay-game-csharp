using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hp_jugador = 40;
            int hp_enemigo = 20;

            int ataque_jugador = 5;
            int ataque_enemigo = 7;

            int cantidad_curacion = 5;

            Random random = new Random();

            while(hp_jugador > 0 && hp_enemigo > 0)
            {
                // Turno del jugador
                
                Console.WriteLine("##### Turno Jugador #####");
                Console.WriteLine("| HP Jugador | " + hp_jugador + " | HP Enemigo |" + hp_enemigo + "|");
                Console.WriteLine("Presiona |a| para atacar o |c| para curar");
                Console.WriteLine("-------------------------------------------------------------------"
                    + "\n");

                string opcion = Console.ReadLine();

                if(opcion == "a")
                {
                    hp_enemigo -= ataque_jugador;
                    Console.WriteLine("Jugador ataca enemigo y provoca " + ataque_jugador + " daño!");
                }
                else
                {
                    hp_jugador += cantidad_curacion;
                    Console.WriteLine("El jugador recupera " + cantidad_curacion + " puntos de curación!");
                }

                if (hp_enemigo > 0)
                {
                    Console.WriteLine("##### Turno Enemigo #####");
                    Console.WriteLine("| HP Jugador | " + hp_jugador + " | HP Enemigo |" + hp_enemigo + "|");
                    Console.WriteLine("-------------------------------------------------------------------"
                     + "\n");
                    int opcion_enemigo = random.Next(0, 2);

                    if (opcion_enemigo == 0)
                    {
                        hp_jugador -= ataque_enemigo;
                        Console.WriteLine("El enemigo ataca y provoca " + ataque_enemigo + " daño!");
                    }
                    else
                    {
                        hp_enemigo += cantidad_curacion;
                        Console.WriteLine("El enemigo recupera " + cantidad_curacion + " puntos de curación!");
                    }
                }
            }
            if (hp_jugador > 0)
            {
                Console.WriteLine("Felicidades, has ganado!");
                Console.WriteLine("Tu HP: " + hp_jugador + " HP del enemigo: " + hp_enemigo);
            }
            else
            {
                Console.WriteLine("Has perdido!");
            }
        }
    }
}
