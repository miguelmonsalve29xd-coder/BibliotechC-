
using System;

class Program
{
    static void Main()
    {
        ShowMainMenu();
    }

    static void ShowMainMenu()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("       SISTEMA DE BIBLIOTECA");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Libros");
            Console.WriteLine("2. Usuarios");
            Console.WriteLine("3. Préstamos");
            Console.WriteLine("4. Búsquedas y reportes");
            Console.WriteLine("5. Guardar / Cargar datos");
            Console.WriteLine("6. Salir");
            Console.WriteLine("========================================");

            int option = ReadOption(1, 6);

            switch (option)
            {
                case 1:
                    ShowBooksMenu();
                    break;

                case 2:
                    ShowUsersMenu();
                    break;

                case 3:
                    ShowLoansMenu();
                    break;

                case 4:
                    ShowSearchReportsMenu();
                    break;

                case 5:
                    ShowPersistenceMenu();
                    break;

                case 6:
                    running = ConfirmExit();
                    break;
            }
        }

        Console.WriteLine("Programa finalizado.");
    }

    static int ReadOption(int min, int max)
    {
        int option;

        while (true)
        {
            Console.Write("Selecciona una opción: ");
            string input = Console.ReadLine() ?? "";

            if (int.TryParse(input, out option) &&
                option >= min && option <= max)
            {
                return option;
            }

            Console.WriteLine(
                $"Opción inválida. Ingresa un número entre {min} y {max}.");
        }
    }

    static void ShowBooksMenu()
    {
        ShowModuleMessage("Módulo de libros");
    }

    static void ShowUsersMenu()
    {
        ShowModuleMessage("Módulo de usuarios");
    }

    static void ShowLoansMenu()
    {
        ShowModuleMessage("Módulo de préstamos");
    }

    static void ShowSearchReportsMenu()
    {
        ShowModuleMessage("Módulo de búsquedas y reportes");
    }

    static void ShowPersistenceMenu()
    {
        ShowModuleMessage("Módulo de guardar y cargar datos");
    }

    static void ShowModuleMessage(string message)
    {
        Console.Clear();
        Console.WriteLine("========================================");
        Console.WriteLine(message);
        Console.WriteLine("========================================");
        Console.WriteLine("Este módulo se desarrollará en su rama feature.");
        Pause();
    }

    static bool ConfirmExit()
    {
        Console.Write("¿Deseas salir del programa? (S/N): ");
        string answer = (Console.ReadLine() ?? "").Trim().ToUpper();

        while (answer != "S" && answer != "N")
        {
            Console.Write("Respuesta inválida. Escribe S o N: ");
            answer = (Console.ReadLine() ?? "").Trim().ToUpper();
        }

        return answer == "N";
    }

    static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Presiona una tecla para volver al menú...");
        Console.ReadKey();
    }
}
