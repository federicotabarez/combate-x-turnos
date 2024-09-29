
using System;
using System.ComponentModel.Design;
using System.Timers;

//estadisticas

   
    int VidaJugador = 10;
    int VidaEnemigo = 20;
    int AtaqueJugador = 7;
    int AtaqueEnemigo = 5;
    int DefensaJugador = 5;
    int DefensaEnemigo = 6;
    string input = " ";
    Random random = new Random();
    int Esquivar = random.Next(0, 100);
// int atacar;
int OpcionEnemigo = random.Next(1, 3);



    //opciones en consola
    Console.WriteLine("el enemigo esta apunto de atacar, que desea hacer");
    Console.WriteLine("1. atacar");
    Console.WriteLine("2. defenderse");
    Console.WriteLine("3. esquivar");
    input = Console.ReadLine();
    Console.Clear();

//DECISIONES JUGADOR AL LLEGAR A 0 NO TERMINA SI NO ESPERA HASTA EL PRXIMO TURNO 
if (VidaJugador > 0 || VidaEnemigo > 0)
{
    switch (input)
    {
        case "1":
            Console.WriteLine("el jugador ataco");
            DefensaEnemigo = AtaqueJugador - DefensaEnemigo;
            VidaEnemigo = VidaEnemigo - AtaqueJugador;
            Console.WriteLine("la vida actual del enemigo es de " + VidaEnemigo + " puntos");

            break;
        case "2":
            Console.WriteLine("el jugador defendio");
            DefensaJugador = DefensaJugador + 5;
            Console.WriteLine("la defensa actual del jugador es de " + DefensaJugador);

            break;
        case "3":
            if (Esquivar > 40)
                Console.WriteLine("el jugador esquivo con exito");
            else
                Console.WriteLine("el jugador fallo en esquivar");
            break;
    }
}

else
{
    Console.WriteLine("el JUGADOR PERDIO");
}
                //decisisones enemigo

                if (VidaEnemigo > 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("turno del enemigo");
                    Console.WriteLine("----------------------");
                    Console.WriteLine(" ");
                    switch (OpcionEnemigo)
                    {
                        case 1:
                            Console.WriteLine("el enemigo ataca al jugador ");
                            DefensaJugador = AtaqueEnemigo - DefensaJugador;
                            VidaJugador = VidaJugador - AtaqueEnemigo;
                            Console.WriteLine("la vida del jugador es de:" + VidaJugador);
                            break;
                        case 2:
                            Console.WriteLine("el enemigo se defiende del jugador");
                            DefensaEnemigo = DefensaEnemigo + 5;
                            Console.WriteLine("la defensa del enemigo es de " + DefensaEnemigo);
                            break;
                        case 3:
                            if (Esquivar > 40)
                                Console.WriteLine("el enemigo esquivo con exito");

                            else
                                Console.WriteLine("el enemigo esquivo sin exito");
                            break;
                    }

                }
        








