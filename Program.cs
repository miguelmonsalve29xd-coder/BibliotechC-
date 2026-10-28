
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
                case 1: ShowBooksMenu(); break;
                case 2: ShowUsersMenu(); break;
                case 3: ShowLoansMenu(); break;
                case 4: ShowSearchReportsMenu(); break;
                case 5: ShowPersistenceMenu(); break;
                case 6: running = ConfirmExit(); break;
            }
        }

        Console.WriteLine("Programa finalizado.");
    }

    static void ShowBooksMenu()
    {
        bool back = false;

        while (!back)
        {
            Console.Clear();
            Console.WriteLine("========== MENÚ DE LIBROS ==========");
            Console.WriteLine("1. Registrar libro");
            Console.WriteLine("2. Listar libros");
            Console.WriteLine("3. Ver detalle por ID/ISBN");
            Console.WriteLine("4. Actualizar libro");
            Console.WriteLine("5. Eliminar libro");
            Console.WriteLine("6. Volver al menú principal");

            switch (ReadOption(1, 6))
            {
                case 1: RegisterBook(); break;
                case 2: ListBooksMenu(); break;
                case 3: ViewBookDetail(); break;
                case 4: UpdateBookMenu(); break;
                case 5: DeleteBook(); break;
                case 6: back = true; break;
            }

            if (!back)
                Pause();
        }
    }

    static void RegisterBook()
    {
        Console.WriteLine("Acción seleccionada: registrar un libro.");
        Console.WriteLine("Simulación: se registrarían los datos del libro.");
    }

    static void ListBooksMenu()
    {
        Console.WriteLine("========== LISTAR LIBROS ==========");
        Console.WriteLine("1. Listar todos");
        Console.WriteLine("2. Listar disponibles");
        Console.WriteLine("3. Listar prestados");
        Console.WriteLine("4. Volver");

        switch (ReadOption(1, 4))
        {
            case 1: ListBooksAll(); break;
            case 2: ListBooksAvailable(); break;
            case 3: ListBooksBorrowed(); break;
            case 4: return;
        }
    }

    static void ListBooksAll()
    {
        Console.WriteLine("Acción seleccionada: listar todos los libros.");
    }

    static void ListBooksAvailable()
    {
        Console.WriteLine("Acción seleccionada: listar libros disponibles.");
    }

    static void ListBooksBorrowed()
    {
        Console.WriteLine("Acción seleccionada: listar libros prestados.");
    }

    static void ViewBookDetail()
    {
        Console.WriteLine("Acción seleccionada: consultar detalle de un libro.");
        Console.WriteLine("Se solicitaría el ID o ISBN del libro.");
    }

    static void UpdateBookMenu()
    {
        Console.WriteLine("========== ACTUALIZAR LIBRO ==========");
        Console.WriteLine("1. Editar título");
        Console.WriteLine("2. Editar autor");
        Console.WriteLine("3. Editar año / categoría");
        Console.WriteLine("4. Volver");

        switch (ReadOption(1, 4))
        {
            case 1: EditBookTitle(); break;
            case 2: EditBookAuthor(); break;
            case 3: EditBookYearCategory(); break;
            case 4: return;
        }
    }

    static void EditBookTitle()
    {
        Console.WriteLine("Acción seleccionada: editar título del libro.");
    }

    static void EditBookAuthor()
    {
        Console.WriteLine("Acción seleccionada: editar autor del libro.");
    }

    static void EditBookYearCategory()
    {
        Console.WriteLine("Acción seleccionada: editar año y categoría.");
    }

    static void DeleteBook()
    {
        Console.WriteLine("Acción seleccionada: eliminar libro.");
        Console.WriteLine("Validar no permitir si está prestado.");
    }

    static void ShowUsersMenu()
    {
        ShowModuleMessage("Módulo de usuarios pendiente de desarrollo.");
    }

    static void ShowLoansMenu()
    {
        ShowModuleMessage("Módulo de préstamos pendiente de desarrollo.");
    }

    static void ShowSearchReportsMenu()
    {
        ShowModuleMessage("Módulo de búsquedas y reportes pendiente.");
    }

    static void ShowPersistenceMenu()
    {
        ShowModuleMessage("Módulo de guardar y cargar pendiente.");
    }

    static void ShowModuleMessage(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
        Pause();
    }

    static int ReadOption(int min, int max)
    {
        while (true)
        {
            Console.Write("Selecciona una opción: ");
            string input = Console.ReadLine() ?? "";

            if (int.TryParse(input, out int option) &&
                option >= min && option <= max)
            {
                return option;
            }

            Console.WriteLine(
                $"Opción inválida. Ingresa un número entre {min} y {max}.");
        }
    }

    static bool ConfirmExit()
    {
        Console.Write("¿Guardar antes de salir? (S/N): ");
        string answer = (Console.ReadLine() ?? "").Trim().ToUpper();

        while (answer != "S" && answer != "N")
        {
            Console.Write("Respuesta inválida. Ingresa S o N: ");
            answer = (Console.ReadLine() ?? "").Trim().ToUpper();
        }

        if (answer == "S")
            SaveData();

        return answer == "N";
    }

    static void SaveData()
    {
        Console.WriteLine("Simulación: se guardarían los datos.");
    }

    static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Presiona una tecla para continuar...");
        Console.ReadKey();
    }
}
