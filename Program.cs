using System;
using System.Collections.Generic;

namespace Guia3_Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polimorfismo
            //Definicion pura: muchos objestos entienden los mismos mensajes

            //Pedro, Ana
            //Pedro.come()
            //Ana.come()

            //Lenguajes tipados vs no tipados
            //var algo = 3;
            //var algo2 = "cadena";

            //int algo =3;
            //string algo2 = "cadena";

            //Instanciar: crear un objeto
            //Instancia: un objeto creado a partir de una clase

            //Gatito silvestre = new Gatito();
            //Gatito garfield = new Gatito();

            //silvestre y garfield son polimorficos por pertenecer a la misma clase

            //Planta, Homero, Lenny, PatoBalancin, MrBurns

            //Cuando hay polimorfismo en lenguajes tipados:
            //Objetos que pertenezcan a la misma clase'
            //Objetos que comparte una interfaz en comun
            //Cuando herencia

            Homero homero = new Homero(2);
            Lenny lenny = new Lenny();
            PatoBalancin pato = new PatoBalancin();
            MrBurns burns = new MrBurns();

            Planta planta = new Planta(10001, homero, burns);

            string opcion = "";
            do
            {
                Console.WriteLine(
                "1)Ver si la planta esta en peligro\n" +
                "2)Homero come dona\n" +
                "3)Homero compra donas\n" +
                "4)Lenny toma cerveza\n" +
                "5)Cambiar empleado por Homero\n" +
                "6)Cambiar empleado por Lenny\n" +
                "7)Cambiar empleado por el Pato\n" +
                "8)Despojar a burns de sus riquezas");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine(planta.estaEnPeligro());
                        break;
                    case "2":
                        homero.comer();
                        break;
                    case "3":
                        homero.comprar();
                        break;
                    case "4":
                        lenny.tomarCerverza();
                        break;
                    case "5":
                        planta.CambiarEmpleado(homero);
                        break;
                    case "6":
                        planta.CambiarEmpleado(lenny);
                        break;
                    case "7":
                        planta.CambiarEmpleado(pato);
                        break;
                    case "8":
                        burns.despojarDeSusRiquezas();
                        break;
                    default:
                        opcion = "salir";
                        break;
                }
            }
            while (opcion != "salir");
            //Calificacion: puntuacion, comentario
            //Juego: titulo, genero, ListaCalificaciones
            List<Calificacion> calificacionesAc2 = new List<Calificacion>{ new Calificacion("Buenisimo", 5), new Calificacion("El mejor",5)};
            Juego ac2 = new Juego("Assassins Creed II", calificacionesAc2);
        }
    }
}
