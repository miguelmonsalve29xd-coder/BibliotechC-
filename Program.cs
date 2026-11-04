
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
                case 6: running = ConfirmExitAndSave(); break;
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
    bool back = false;

    while (!back)
    {
        Console.Clear();

        Console.WriteLine("========== MENÚ DE USUARIOS ==========");
        Console.WriteLine("1. Registrar usuario");
        Console.WriteLine("2. Listar usuarios");
        Console.WriteLine("3. Ver detalle de usuario (por ID/documento)");
        Console.WriteLine("4. Actualizar usuario");
        Console.WriteLine("5. Eliminar usuario");
        Console.WriteLine("6. Volver al menú principal");

        switch (ReadOption(1, 6))
        {
            case 1: RegisterUser(); break;
            case 2: ListUsers(); break;
            case 3: ViewUserDetail(); break;
            case 4: UpdateUserMenu(); break;
            case 5: DeleteUser(); break;
            case 6: back = true; break;
        }

        if (!back)
            Pause();
    }
}
static void RegisterUser()
{
    Console.WriteLine("Acción seleccionada: Registrar usuario.");
}
static void ListUsers()
{
    Console.WriteLine("Acción seleccionada: Listar usuarios.");
}
static void ViewUserDetail()
{
    Console.WriteLine("Acción seleccionada: Ver detalles del usuario.");
    Console.WriteLine("Se solicitaría el ID o documento.");
}
static void UpdateUserMenu()
{
    Console.WriteLine("========== ACTUALIZAR USUARIO ==========");
    Console.WriteLine("1. Editar nombre");
    Console.WriteLine("2. Editar contacto");
    Console.WriteLine("3. Activar / Desactivar");
    Console.WriteLine("4. Volver");

    switch (ReadOption(1, 4))
    {
        case 1: EditUserName(); break;
        case 2: EditUserContact(); break;
        case 3: ToggleUserActiveStatus(); break;
        case 4: return;
    }
}

static void EditUserName()
{
    Console.WriteLine("Acción seleccionada: Editar nombre.");
}

static void EditUserContact()
{
    Console.WriteLine("Acción seleccionada: Editar contacto.");
}

static void ToggleUserActiveStatus()
{
    Console.WriteLine("Acción seleccionada: Activar / Desactivar usuario.");
}

static void DeleteUser()
{
    Console.WriteLine("Acción seleccionada: Eliminar usuario.");
    Console.WriteLine("Validar no permitir si tiene préstamos activos.");
}


static void ShowLoansMenu()
{
    bool back = false;

    while (!back)
    {
        Console.Clear();

        Console.WriteLine("========== MENÚ DE PRÉSTAMOS ==========");
        Console.WriteLine("1. Crear préstamo");
        Console.WriteLine("2. Listar préstamos");
        Console.WriteLine("3. Ver detalle de préstamo");
        Console.WriteLine("4. Registrar devolución");
        Console.WriteLine("5. Eliminar préstamo");
        Console.WriteLine("6. Volver al menú principal");

        switch (ReadOption(1, 6))
        {
            case 1: CreateLoan(); break;
            case 2: ListLoansMenu(); break;
            case 3: ViewLoanDetail(); break;
            case 4: RegisterReturn(); break;
            case 5: DeleteLoan(); break;
            case 6: back = true; break;
        }

        if (!back)
            Pause();
    }
}

static void CreateLoan()
{
    Console.WriteLine("Acción seleccionada: Crear préstamo.");
    Console.WriteLine("Validaciones sugeridas:");
    Console.WriteLine("- Verificar que el usuario exista.");
    Console.WriteLine("- Verificar que el usuario esté activo.");
    Console.WriteLine("- Verificar que el libro exista.");
    Console.WriteLine("- Verificar que el libro esté disponible.");
    Console.WriteLine("- Verificar que el usuario no tenga restricciones.");
    Console.WriteLine("- Registrar la fecha del préstamo y devolución.");
}

static void ListLoansMenu()
{
    Console.WriteLine("========== LISTAR PRÉSTAMOS ==========");
    Console.WriteLine("1. Listar todos");
    Console.WriteLine("2. Listar activos");
    Console.WriteLine("3. Listar cerrados");
    Console.WriteLine("4. Volver");

    switch (ReadOption(1, 4))
    {
        case 1: ListLoansAll(); break;
        case 2: ListLoansActive(); break;
        case 3: ListLoansClosed(); break;
        case 4: return;
    }
}

static void ListLoansAll()
{
    Console.WriteLine("Acción seleccionada: Listar todos los préstamos.");
}

static void ListLoansActive()
{
    Console.WriteLine("Acción seleccionada: Listar préstamos activos.");
}

static void ListLoansClosed()
{
    Console.WriteLine("Acción seleccionada: Listar préstamos cerrados.");
}

static void ViewLoanDetail()
{
    Console.WriteLine("Acción seleccionada: Ver detalle de préstamo.");
    Console.WriteLine("Se solicitaría el ID del préstamo.");
}

static void RegisterReturn()
{
    Console.WriteLine("Acción seleccionada: Registrar devolución.");
    Console.WriteLine("Marcar préstamo como devuelto.");
    Console.WriteLine("Cambiar el estado del libro a disponible.");
}

static void DeleteLoan()
{
    Console.WriteLine("Acción seleccionada: Eliminar préstamo.");
    Console.WriteLine("Reglas sugeridas:");
    Console.WriteLine("- Validar que el préstamo exista.");
    Console.WriteLine("- Verificar que no afecte el historial.");
    Console.WriteLine("- No eliminar préstamos activos sin autorización.");
}



static void ShowSearchReportsMenu()
{
    bool back = false;

    while (!back)
    {
        Console.Clear();

        Console.WriteLine("======= BÚSQUEDAS Y REPORTES =======");
        Console.WriteLine("1. Buscar libro");
        Console.WriteLine("2. Buscar usuario");
        Console.WriteLine("3. Reportes");
        Console.WriteLine("4. Volver al menú principal");

        switch (ReadOption(1, 4))
        {
            case 1: SearchBook(); break;
            case 2: SearchUser(); break;
            case 3: ReportsMenu(); break;
            case 4: back = true; break;
        }

        if (!back)
            Pause();
    }
}

static void SearchBook()
{
    Console.WriteLine("Acción seleccionada: Buscar libro.");
    Console.WriteLine("Criterios de búsqueda:");
    Console.WriteLine("- Título.");
    Console.WriteLine("- Autor.");
    Console.WriteLine("- ID.");
    Console.WriteLine("- Categoría.");
}

static void SearchUser()
{
    Console.WriteLine("Acción seleccionada: Buscar usuario.");
    Console.WriteLine("Criterios de búsqueda:");
    Console.WriteLine("- Nombre.");
    Console.WriteLine("- ID o documento.");
}

static void ReportsMenu()
{
    bool back = false;

    while (!back)
    {
        Console.Clear();

        Console.WriteLine("========== REPORTES ==========");
        Console.WriteLine("1. Reporte por usuario");
        Console.WriteLine("2. Reporte por libro");
        Console.WriteLine("3. Reporte de préstamos vencidos");
        Console.WriteLine("4. Resumen general");
        Console.WriteLine("5. Volver");

        switch (ReadOption(1, 5))
        {
            case 1: ReportByUser(); break;
            case 2: ReportByBook(); break;
            case 3: ReportOverdue(); break;
            case 4: ReportSummary(); break;
            case 5: back = true; break;
        }

        if (!back)
            Pause();
    }
}

static void ReportByUser()
{
    Console.WriteLine("Acción seleccionada: Generar reporte por usuario.");
}

static void ReportByBook()
{
    Console.WriteLine("Acción seleccionada: Generar reporte por libro.");
}

static void ReportOverdue()
{
    Console.WriteLine("Acción seleccionada: Generar reporte de préstamos vencidos.");
}

static void ReportSummary()
{
    Console.WriteLine("Acción seleccionada: Generar resumen general.");
}


static void ShowPersistenceMenu()
{
    bool back = false;

    while (!back)
    {
        Console.Clear();

        Console.WriteLine("======= GUARDAR / CARGAR DATOS =======");
        Console.WriteLine("1. Guardar datos");
        Console.WriteLine("2. Cargar datos");
        Console.WriteLine("3. Reiniciar datos");
        Console.WriteLine("4. Volver al menú principal");

        switch (ReadOption(1, 4))
        {
            case 1:
                SaveData();
                break;

            case 2:
                LoadData();
                break;

            case 3:
                ResetData();
                break;

            case 4:
                back = true;
                break;
        }

        if (!back)
            Pause();
    }
}

static void SaveData()
{
    Console.WriteLine("Acción seleccionada: Guardar datos.");
    Console.WriteLine("Simulación: los datos se guardarían en el sistema.");
}

static void LoadData()
{
    Console.WriteLine("Acción seleccionada: Cargar datos.");
    Console.WriteLine("Simulación: los datos se cargarían desde el sistema.");
}

static void ResetData()
{
    ConfirmResetData();
}

static void ConfirmResetData()
{
    Console.Write("¿Estás seguro de reiniciar los datos? (S/N): ");

    string answer = (Console.ReadLine() ?? "").Trim().ToUpper();

    while (answer != "S" && answer != "N")
    {
        Console.Write("Respuesta inválida. Ingresa S o N: ");
        answer = (Console.ReadLine() ?? "").Trim().ToUpper();
    }

    if (answer == "S")
    {
        Console.WriteLine("Simulación: los datos serían reiniciados.");
    }
    else
    {
        Console.WriteLine("Operación cancelada. Los datos se conservan.");
    }
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

    static bool ConfirmExitAndSave()
{
    string answer;

    do
    {
        Console.Write("¿Guardar antes de salir? (S/N): ");
        answer = (Console.ReadLine() ?? "").Trim().ToUpper();

        if (answer != "S" && answer != "N")
        {
            Console.WriteLine("Respuesta inválida. Ingresa S o N.");
        }

    } while (answer != "S" && answer != "N");

    if (answer == "S")
    {
        SaveData();
    }
    else
    {
        Console.WriteLine("Saliendo sin guardar.");
    }

    return false;
}



    static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Presiona una tecla para continuar...");
        Console.ReadKey();
    }
}
