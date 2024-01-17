using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaExamen
{
    internal public static class CaraCruz
    {

        int empates = 0;
        private static int field;

        public static event EventHandler Event;

        static CaraCruz()
        {
            throw new System.NotImplementedException();
        }

        public static int Property
        {
            get => default;
            set
            {
            }
        }

        public static int Property1
        {
            get => default;
            set
            {
            }
        }

        int lanzaMoneda(String jugador)
        {
            int resCaraCruz;
            resCaraCruz = floor(random(0, 2));
            if (resCaraCruz == 0)
            {
                print(jugador + ": CARA");
            }
            else if (resCaraCruz == 1)
            {
                print(jugador + ": CRUZ");
            }
            else
            {
                print(jugador + ": ERROR");
            }
            return resCaraCruz;
        }

        void caraCruz(String jug0, String jug1, String jug2)
        {
            int[] res = new int[3];

            res[0] = lanzaMoneda(jug0);
            print(" | ");
            res[1] = lanzaMoneda(jug1);
            print(" | ");
            res[2] = lanzaMoneda(jug2);
            print(" | ");

            if (res[0] + res[1] + res[2] == 0 || res[0] + res[1] + res[2] == 3)
            {
                print("EMPATE");
                empates++;
            }
            else if (res[0] == res[1] && res[0] != res[2])
            {
                print("Gana " + jug2);
            }
            else if (res[0] == res[2] && res[0] != res[1])
            {
                print("Gana " + jug1);
            }
            else if (res[1] == res[2] && res[0] != res[1])
            {
                print("Gana " + jug0);
            }
            else
            {
                print("ERROR");
            }

            println();
        }

        void cienCaraCruz(String jug0, String jug1, String jug2)
        {
            empates = 0;
            for (int i = 0; i < 100; i++)
            {
                print(i + 1 + ": ");
                caraCruz(jug0, jug1, jug2);
            }

            println();
            println("Porcentaje de empates: " + empates + "%");
        }


    }

    internal public static class CopyOfCaraCruz
    {

        int empates = 0;
        private static int field;

        public static event EventHandler Event;

        static CopyOfCaraCruz()
        {
            throw new System.NotImplementedException();
        }

        public static int Property
        {
            get => default;
            set
            {
            }
        }

        public static int Property1
        {
            get => default;
            set
            {
            }
        }

        int lanzaMoneda(String jugador)
        {
            int resCaraCruz;
            resCaraCruz = floor(random(0, 2));
            if (resCaraCruz == 0)
            {
                print(jugador + ": CARA");
            }
            else if (resCaraCruz == 1)
            {
                print(jugador + ": CRUZ");
            }
            else
            {
                print(jugador + ": ERROR");
            }
            return resCaraCruz;
        }

        void caraCruz(String jug0, String jug1, String jug2)
        {
            int[] res = new int[3];

            res[0] = lanzaMoneda(jug0);
            print(" | ");
            res[1] = lanzaMoneda(jug1);
            print(" | ");
            res[2] = lanzaMoneda(jug2);
            print(" | ");

            if (res[0] + res[1] + res[2] == 0 || res[0] + res[1] + res[2] == 3)
            {
                print("EMPATE");
                empates++;
            }
            else if (res[0] == res[1] && res[0] != res[2])
            {
                print("Gana " + jug2);
            }
            else if (res[0] == res[2] && res[0] != res[1])
            {
                print("Gana " + jug1);
            }
            else if (res[1] == res[2] && res[0] != res[1])
            {
                print("Gana " + jug0);
            }
            else
            {
                print("ERROR");
            }

            println();
        }

        void cienCaraCruz(String jug0, String jug1, String jug2)
        {
            empates = 0;
            for (int i = 0; i < 100; i++)
            {
                print(i + 1 + ": ");
                caraCruz(jug0, jug1, jug2);
            }

            println();
            println("Porcentaje de empates: " + empates + "%");
        }


    }
}
