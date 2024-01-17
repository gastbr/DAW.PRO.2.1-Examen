internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Presionar 1 para Cara o cruz, 2 para Triángulo o 3 para Notas. 0 para salir:");
            Console.WriteLine();

            char tecla = (char)Console.ReadKey().Key;

            Console.WriteLine();
            Console.WriteLine();

            switch (tecla)
            {
                case '1':
                    Console.WriteLine("Cara o cruz: José vs. Pepe vs. Juan.");
                    


                    Console.WriteLine();
                    Console.WriteLine("Presionar 1 para Cara o cruz, 2 para Triángulo o 3 para Notas. 0 para salir.");
                    Console.WriteLine();

                    break;
                case '2':
                    Console.WriteLine("Ha elegido la opción 2");
                    break;
                case '3':
                    Console.WriteLine("Ha elegido la opción 3");
                    break;
                case '0':
                    Console.WriteLine("Ha elegido la opción 4");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}